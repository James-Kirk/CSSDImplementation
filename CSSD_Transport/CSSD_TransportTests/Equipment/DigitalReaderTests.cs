using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSSD_Transport.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSSD_Transport.Accounts;
using CSSD_Transport.Journeys;

namespace CSSD_Transport.Equipment.Tests
{
    [TestClass()]
    public class DigitalReaderTests
    {   
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void digitalReaderConstructionTestInvalidType()
        {
            var reader = new DigitalReader("Waffle Iron", 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void digitalReaderConstructionTestAnotherInvalidType()
        {
            var reader = new DigitalReader("All of the bees", 6);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void digitalReaderConstructionNullType()
        {
            var reader = new DigitalReader(null, 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void digitalReaderConstructorAlreadyExistingId()
        {
            var reader = new DigitalReader("Train", 1);
            var anotherReader = new DigitalReader("Bus", 1);
        }

        [TestMethod()]
        public void readTokenAtEntryTestBasicBus()
        {
            var reader = new DigitalReader("Bus", 1);
            Assert.AreEqual(true, reader.readTokenAtEntry(2));
        }

        [TestMethod()]
        public void readTokenAtEntryTestBasicTrain()
        {
            var reader = new DigitalReader("Train", 1);
            Assert.AreEqual(true, reader.readTokenAtEntry(2));
        }

        [TestMethod()]
        public void readTokenAtEntryTestInvalidId()
        {
            var reader = new DigitalReader("Bus", 3);
            Assert.AreEqual(false, reader.readTokenAtEntry(-999999));
            Assert.AreEqual(false, reader.readTokenAtEntry(999999));
        }

        [TestMethod()]
        public void readTokenAtEntryTestInsufficientFunds()
        {
            var reader = new DigitalReader("Bus", 4);
            Assert.AreEqual(false, reader.readTokenAtEntry(1));
        }

        [TestMethod()]
        public void readTokenAtExitTestBasic()
        {
            var reader = new DigitalReader("Train", 1);
            reader.setLocation(new Journeys.Location("Baker Street"));
            reader.readTokenAtEntry(2);
            reader.setLocation(new Journeys.Location("Great Portland Street")); // may be using this wrong for RailMap?
            Account anAccount = SetOfAccounts.Instance.findAccount("James", "Bob");
            float expectedBalance = anAccount.getBalance() - FareRules.Instance.getCostPerStation();
            Assert.AreEqual(expectedBalance, reader.readTokenAtExit(2));
        }

        [TestMethod()]
        public void readTokenAtExitTestMultipleStops()
        {
            var reader = new DigitalReader("Train", 1);
            reader.setLocation(new Journeys.Location("Baker Street"));
            reader.readTokenAtEntry(2);
            reader.setLocation(new Journeys.Location("Kings Cross"));
            Account anAccount = SetOfAccounts.Instance.findAccount("James", "Bob");
            float expectedBalance = anAccount.getBalance() - (FareRules.Instance.getCostPerStation() * 2);
            Assert.AreEqual(expectedBalance, reader.readTokenAtExit(2));
        }

        [TestMethod()]
        public void readTokenAtExitTestSameStopNoCharge()
        {
            var reader = new DigitalReader("Train", 1);
            reader.setLocation(new Journeys.Location("Baker Street"));
            reader.readTokenAtEntry(2);
            Account anAccount = SetOfAccounts.Instance.findAccount("James", "Bob");
            float expectedBalance = anAccount.getBalance();
            Assert.AreEqual(expectedBalance, reader.readTokenAtExit(2));
        }

        [TestMethod()]
        public void readTokenAtExitTestSameStopCharged()
        {
            var reader = new DigitalReader("Train", 1);
            reader.setLocation(new Journeys.Location("Baker Street"));
            reader.readTokenAtEntry(2);
            DateTime aDateTime = DateTime.Now.AddMinutes(15);
            reader.setCurrentTime(aDateTime);
            Account anAccount = SetOfAccounts.Instance.findAccount("James", "Bob");
            float expectedBalance = anAccount.getBalance() - FareRules.Instance.getCostPerStation();
            Assert.AreEqual(expectedBalance, reader.readTokenAtExit(2)); 
        }

        [TestMethod()]
        [ExpectedException(typeof(KeyNotFoundException))]   // TODO update this exceptio to whatever Alex thinks best exception is
        public void readTokenAtExitTestNoEntryScan()
        {
            var reader = new DigitalReader("Train", 1);
            reader.readTokenAtExit(2);
        }

        [TestMethod()]
        public void readTokenAtExitInsufficientFunds()
        {
            var reader = new DigitalReader("Train", 1);
            reader.setLocation(new Journeys.Location("Baker Street"));
            reader.readTokenAtEntry(3); // Doom guy has enough to get on but not enough to complete a journey
            reader.setLocation(new Journeys.Location("Kennington"));
            float expectedResult = -1f;
            Assert.AreEqual(expectedResult, reader.readTokenAtExit(3));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void readTokenAtExitTestInvalidId()
        {
            var reader = new DigitalReader("Bus", 1);
            reader.readTokenAtExit(-999999);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void readTokenAtExitTestAnotherInvalidId()
        {
            var reader = new DigitalReader("Bus", 1);
            reader.readTokenAtExit(999999);
        }

        [TestMethod()]
        public void getReaderTypeTestBasic()
        {
            var reader = new DigitalReader("Bus", 1);
            var anotherReader = new DigitalReader("Train", 2);
            Assert.AreEqual("Bus", reader.getReaderType());
            Assert.AreEqual("Train", anotherReader.getReaderType());
        }

        [TestMethod()]
        public void getTimeTestBasic()
        {
            var reader = new DigitalReader("Bus", 1);
            Assert.AreEqual(DateTime.Now.ToString("HH:mm"), reader.getTime());
        }

        [TestMethod()]
        public void getDateTestBasic()
        {
            var reader = new DigitalReader("Bus", 1);
            Assert.AreEqual(DateTime.Now.ToString("yyyy-MM-dd"), reader.getDay());
        }

        // create journey tests

    }
}