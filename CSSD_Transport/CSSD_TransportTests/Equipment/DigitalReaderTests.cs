using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSSD_Transport.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Equipment.Tests
{
    [TestClass()]
    public class DigitalReaderTests
    {
        [TestMethod()]
        public void readTokenAtEntryTestBasicBus()
        {
            var reader = new DigitalReader("Bus", 1);
            Assert.AreEqual(true, reader.readTokenAtEntry(2));
        }

        [TestMethod()]
        public void readTokenAtEntryTestBasicTrain()
        {
            var reader = new DigitalReader("Train", 2);
            Assert.AreEqual(true, reader.readTokenAtEntry(2));
        }

        [TestMethod()]
        public void readTokenAtEntryTestInvalidId()
        {
            var reader = new DigitalReader("Bus", 3);
            Assert.AreEqual(false, reader.readTokenAtEntry(999999));
        }

        [TestMethod()]
        public void readTokenAtEntryTestInsufficientFunds()
        {
            var reader = new DigitalReader("Bus", 4);
            Assert.AreEqual(false, reader.readTokenAtEntry(1));
        }

        [TestMethod()]
        public void readTokenAtEntryTestInvalidType()
        {
            var reader = new DigitalReader("Waffle Iron", 5);
            Assert.Fail();
        }
    }
}