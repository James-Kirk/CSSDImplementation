using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSSD_Transport.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSSD_Transport.Accounts;
using CSSD_Transport.Journeys;
using CSSD_Transport.Util;
using CSSD_Transport.Tokens;

namespace CSSD_Transport.Equipment.Tests
{
    [TestClass()]
    public class DigitalReaderTests
    {
        private NormalAccount ac;
        private SmartCard sc;
        private NormalAccount ac2;
        private SmartCard sc2;

        [TestInitialize]
        public void digitalReaderSetup()
        {
            ac = new NormalAccount("Ben", "Watt", DateTime.Now);
            sc = new SmartCard(ac, false, 0);
            ac2 = new NormalAccount("Alex", "Ogde", DateTime.Now);
            sc2 = new SmartCard(ac2, false, 0);

            SetOfAccounts.Instance.addAccount(ac);
            SetOfAccounts.Instance.addAccount(ac2);
            SetOfTokens.Instance.addToken(sc);
            SetOfTokens.Instance.addToken(sc2);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void digitalReaderConstructionTestInvalidType()
        {
            var reader = new DigitalReader("Waffle Iron", "Victoria");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void digitalReaderConstructionTestAnotherInvalidType()
        {
            var reader = new DigitalReader("All of the bees", "Victoria");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void digitalReaderConstructionNullType()
        {
            var reader = new DigitalReader(null, "Victoria");
        }

        [TestMethod()]
        public void readTokenAtEntryTestBasicBus()
        {
            sc.updateAccountBalance(10);
            var reader = new DigitalReader("Bus", "Victoria");
            Assert.AreEqual(true, reader.readTokenAtEntry(sc.getID()));
        }

        [TestMethod()]
        public void readTokenAtEntryTestBasicTrain()
        {
            sc.updateAccountBalance(10);
            var reader = new DigitalReader("Train", "Victoria");
            Assert.AreEqual(true, reader.readTokenAtEntry(sc.getID()));
        }

        [TestMethod()]
        public void readTokenAtEntryTestInvalidId()
        {
            var reader = new DigitalReader("Bus", "Victoria");
            Assert.AreEqual(false, reader.readTokenAtEntry(-999999));
            Assert.AreEqual(false, reader.readTokenAtEntry(999999));
        }

        [TestMethod()]
        public void readTokenAtEntryTestInsufficientFunds()
        {
            var reader = new DigitalReader("Bus", "Victoria");
            Assert.AreEqual(false, reader.readTokenAtEntry(sc2.getID()));
        }

        [TestMethod()]
        public void readTokenAtExitTestBasic()
        {
            sc.updateAccountBalance(10);
            var reader = new DigitalReader("Train", "Victoria");
            reader.setLocation(RailMap.Instance.getLocation("Baker Street"));
            reader.readTokenAtEntry(sc.getID());
            reader.setLocation(RailMap.Instance.getLocation("Great Portland Street"));
            float expectedBalance = ac.getBalance() - FareRules.Instance.getCostPerStation();
            Assert.AreEqual(expectedBalance, reader.readTokenAtExit(sc.getID(), "Circle"));
        }
         
        [TestMethod()]
        public void readTokenAtExitTestMultipleStops()
        {
            sc.updateAccountBalance(10);
            var reader = new DigitalReader("Train", "Victoria");
            reader.setLocation(RailMap.Instance.getLocation("Baker Street"));
            reader.readTokenAtEntry(sc.getID());
            reader.setLocation(RailMap.Instance.getLocation("Kings Cross"));
            float expectedBalance = ac.getBalance() - (FareRules.Instance.getCostPerStation() * 3);
            Assert.AreEqual(expectedBalance, reader.readTokenAtExit(sc.getID(), "Circle"));
        }

        [TestMethod()]
        public void readTokenAtExitTestSameStopNoCharge()
        {
            sc.updateAccountBalance(10);
            var reader = new DigitalReader("Train", "Victoria");
            reader.setLocation(RailMap.Instance.getLocation("Baker Street"));
            reader.readTokenAtEntry(sc.getID());
            float expectedBalance = ac.getBalance();
            Assert.AreEqual(expectedBalance, reader.readTokenAtExit(sc.getID(), "Circle"));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]  
        public void readTokenAtExitTestNoEntryScan()
        {
            var reader = new DigitalReader("Train", "Victoria");
            reader.readTokenAtExit(sc.getID(), "Circle");
        }

        [TestMethod()]
        public void readTokenAtExitInsufficientFunds()
        {
            sc2.updateAccountBalance(5);
            var reader = new DigitalReader("Train", "Victoria");
            reader.setLocation(RailMap.Instance.getLocation("Baker Street"));
            reader.readTokenAtEntry(sc2.getID());
            reader.setLocation(RailMap.Instance.getLocation("Victoria"));
            float expectedResult = -1f;
            Assert.AreEqual(expectedResult, reader.readTokenAtExit(sc2.getID(), "Circle"));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void readTokenAtExitTestInvalidId()
        {
            var reader = new DigitalReader("Bus", "Victoria");
            reader.readTokenAtExit(-999999,"Circle");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void readTokenAtExitTestAnotherInvalidId()
        {
            var reader = new DigitalReader("Bus", "Victoria");
            reader.readTokenAtExit(999999, "Circle");
        }

        // public void readTokenAtExitTestDifferentLines

        // public void readTokenAtExitTestDayPassAllowed

        [TestMethod()]
        public void getReaderTypeTestBasic()
        {
            var reader = new DigitalReader("Bus", "Victoria");
            var anotherReader = new DigitalReader("Train", "Victoria");
            Assert.AreEqual("Bus", reader.getReaderType());
            Assert.AreEqual("Train", anotherReader.getReaderType());
        }

        [TestMethod()]
        public void getTimeTestBasic()
        {
            var reader = new DigitalReader("Bus", "Victoria");
            Assert.AreEqual(DateTime.Now.ToString("HH:mm"), reader.getTime().ToString("HH:mm"));
        }

        [TestMethod()]
        public void getDateTestBasic()
        {
            var reader = new DigitalReader("Bus", "Victoria");
            Assert.AreEqual(DateTime.Now.ToString("yyyy-MM-dd"), reader.getDay().ToString("yyyy-MM-dd"));
        }

        // create journey tests
        
    }
}