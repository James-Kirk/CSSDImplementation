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
        public void getReaderTypeTestBasic()
        {
            var reader = new DigitalReader("Bus", 1);
            var anotherReader = new DigitalReader("Train", 2);
            Assert.AreEqual("Bus", reader.getReaderType());
            Assert.AreEqual("Train", anotherReader.getReaderType());
        }

        [TestMethod()]
        public void entryPermittedTestBasic()
        {
            var reader = new DigitalReader("Bus", 1);
            Assert.AreEqual(true, reader.entryPermitted());
        }

        [TestMethod()]
        public void entryDeniedTestBasic()
        {
            var reader = new DigitalReader("Bus", 1);
            Assert.AreEqual(false, reader.entryDenied());
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