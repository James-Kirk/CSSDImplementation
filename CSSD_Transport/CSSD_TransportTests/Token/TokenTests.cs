using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSSD_Transport.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSSD_Transport.Tokens;
using CSSD_Transport.Accounts;

namespace CSSD_Transport.Token.Tests
{
    [TestClass()]
    public class TokenTests
    {
        private Ticket tk;
        private SmartCard sc;
        private NormalAccount ac1;
        private NormalAccount ac2;

        [TestInitialize()]
        public void tokenSetup()
        {
            ac1 = new NormalAccount("Ben", "Watt", DateTime.Now);
            ac2 = new NormalAccount("Ellie", "Full", DateTime.Now);
            tk = new Ticket(new Journeys.Location("Kings Cross"), new Journeys.Location("Victoria"), ac1, DateTime.Now);
            sc = new SmartCard(ac2, false, 0);
        }

        [TestMethod()]
        public void getScannedStatusTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getTypeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getNumOfJourneysTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getIDTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void hasDiscountTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void hasSufficientCreditTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void incrementJourneyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void setScannedTest()
        {
            Assert.Fail();
        }
    }
}