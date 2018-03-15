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
        private SmartCard sc2;
        private NormalAccount ac1;
        private NormalAccount ac2;

        [TestInitialize()]
        public void tokenSetup()
        {
            ac1 = new NormalAccount("Ben", "Watt", DateTime.Now);
            ac2 = new NormalAccount("Ellie", "Full", DateTime.Now);
            tk = new Ticket(new Journeys.Location("Kings Cross"), new Journeys.Location("Victoria"), ac1, DateTime.Now);
            sc = new SmartCard(ac2, false, 0);
            sc2 = new SmartCard(ac2, false, 1);
        }

        [TestMethod()]
        public void getScannedStatusTestBasic()
        {
            Assert.AreEqual(false, sc.getScannedStatus());
            Assert.AreEqual(false, tk.getScannedStatus());
        }

        [TestMethod()]
        public void getTypeTestTicketAndSmartCard()
        {
            Assert.AreEqual(tk.getType(), TokenType.Ticket);
            Assert.AreEqual(sc.getType(), TokenType.SmartCard);
        }

        [TestMethod()]
        public void getNumOfJourneysTestZero()
        {
            Assert.AreEqual(sc.getNumOfJourneys(), 0);
            Assert.AreEqual(tk.getNumOfJourneys(), 0);
        }

        [TestMethod()]
        public void getNumOfJourneysTestMultiple()
        {
            Assert.AreEqual(sc2.getNumOfJourneys(), 1);
        }

        [TestMethod()]
        public void getIDTest()
        {
            Assert.AreEqual(tk.getID(), 12);
            Assert.AreEqual(sc.getID(), 13);
        }

        [TestMethod()]
        public void hasDiscountTest()
        {
            Assert.AreEqual(tk.hasDiscount(), false);
            Assert.AreEqual(sc.hasDiscount(), false);
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