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

namespace CSSD_Transport.Equipment.Tests
{
    [TestClass()]
    public class DigitalReaderTests
    {   
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void digitalReaderConstructionTestInvalidType()
        {
            var reader = new DigitalReader("Waffle Iron", 5, "Victoria");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void digitalReaderConstructionTestAnotherInvalidType()
        {
            var reader = new DigitalReader("All of the bees", 6, "Victoria");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void digitalReaderConstructionNullType()
        {
            var reader = new DigitalReader(null, 1, "Victoria");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void digitalReaderConstructorAlreadyExistingId()
        {
            var reader = new DigitalReader("Train", 1, "Victoria");
            var anotherReader = new DigitalReader("Bus", 1, "Victoria");
        }

        [TestMethod()]
        public void readTokenAtEntryTestBasicBus()
        {
            var reader = new DigitalReader("Bus", 1, "Victoria");
            Assert.AreEqual(true, reader.readTokenAtEntry(2));
        }

        [TestMethod()]
        public void readTokenAtEntryTestBasicTrain()
        {
            var reader = new DigitalReader("Train", 1, "Victoria");
            Assert.AreEqual(true, reader.readTokenAtEntry(2));
        }

        [TestMethod()]
        public void readTokenAtEntryTestInvalidId()
        {
            var reader = new DigitalReader("Bus", 3, "Victoria");
            Assert.AreEqual(false, reader.readTokenAtEntry(-999999));
            Assert.AreEqual(false, reader.readTokenAtEntry(999999));
        }

        [TestMethod()]
        public void readTokenAtEntryTestInsufficientFunds()
        {
            var reader = new DigitalReader("Bus", 4, "Victoria");
            Assert.AreEqual(false, reader.readTokenAtEntry(1));
        }

        [TestMethod()]
        public void readTokenAtExitTestBasic()
        {
            var reader = new DigitalReader("Train", 1, "Victoria");
            reader.setLocation(RailMap.Instance.getLocation("Baker Street"));
            reader.readTokenAtEntry(2);
            reader.setLocation(RailMap.Instance.getLocation("Great Portland Street"));
            Account anAccount = SetOfAccounts.Instance.findAccount("James", "Bob");
            float expectedBalance = anAccount.getBalance() - FareRules.Instance.getCostPerStation();
            Assert.AreEqual(expectedBalance, reader.readTokenAtExit(2, "Circle"));
        }
         
        [TestMethod()]
        public void readTokenAtExitTestMultipleStops()
        {
            var reader = new DigitalReader("Train", 1, "Victoria");
            reader.setLocation(RailMap.Instance.getLocation("Baker Street"));
            reader.readTokenAtEntry(2);
            reader.setLocation(RailMap.Instance.getLocation("Kings Cross"));
            Account anAccount = SetOfAccounts.Instance.findAccount("James", "Bob");
            float expectedBalance = anAccount.getBalance() - (FareRules.Instance.getCostPerStation() * 3);
            Assert.AreEqual(expectedBalance, reader.readTokenAtExit(2, "Circle"));
        }

        [TestMethod()]
        public void readTokenAtExitTestSameStopNoCharge()
        {
            var reader = new DigitalReader("Train", 1, "Victoria");
            reader.setLocation(RailMap.Instance.getLocation("Baker Street"));
            reader.readTokenAtEntry(2);
            Account anAccount = SetOfAccounts.Instance.findAccount("James", "Bob");
            float expectedBalance = anAccount.getBalance();
            Assert.AreEqual(expectedBalance, reader.readTokenAtExit(2, "Circle"));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]  
        public void readTokenAtExitTestNoEntryScan()
        {
            var reader = new DigitalReader("Train", 1, "Victoria");
            reader.readTokenAtExit(2, "Circle");
        }

        [TestMethod()]
        public void readTokenAtExitInsufficientFunds()
        {
            var reader = new DigitalReader("Train", 1, "Victoria");
            reader.setLocation(RailMap.Instance.getLocation("Baker Street"));
            reader.readTokenAtEntry(3); // Doom guy has enough to get on but not enough to complete a journey
            reader.setLocation(RailMap.Instance.getLocation("Victoria"));
            float expectedResult = -1f;
            Assert.AreEqual(expectedResult, reader.readTokenAtExit(3, "Circle"));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void readTokenAtExitTestInvalidId()
        {
            var reader = new DigitalReader("Bus", 1, "Victoria");
            reader.readTokenAtExit(-999999,"Circle");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void readTokenAtExitTestAnotherInvalidId()
        {
            var reader = new DigitalReader("Bus", 1, "Victoria");
            reader.readTokenAtExit(999999, "Circle");
        }

        // public void readTokenAtExitTestDifferentLines

        // public void readTokenAtExitTestDayPassAllowed

        [TestMethod()]
        public void getReaderTypeTestBasic()
        {
            var reader = new DigitalReader("Bus", 1, "Victoria");
            var anotherReader = new DigitalReader("Train", 2, "Victoria");
            Assert.AreEqual("Bus", reader.getReaderType());
            Assert.AreEqual("Train", anotherReader.getReaderType());
        }

        [TestMethod()]
        public void getTimeTestBasic()
        {
            var reader = new DigitalReader("Bus", 1, "Victoria");
            Assert.AreEqual(DateTime.Now.ToString("HH:mm"), reader.getTime().ToString("HH:mm"));
        }

        [TestMethod()]
        public void getDateTestBasic()
        {
            var reader = new DigitalReader("Bus", 1, "Victoria");
            Assert.AreEqual(DateTime.Now.ToString("yyyy-MM-dd"), reader.getDay().ToString("yyyy-MM-dd"));
        }

        // create journey tests
        
    }
}