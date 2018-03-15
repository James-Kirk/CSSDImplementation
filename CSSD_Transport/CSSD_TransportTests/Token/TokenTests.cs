using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSSD_Transport.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSSD_Transport.Tokens;
using CSSD_Transport.Accounts;
using CSSD_Transport.Journeys;
using CSSD_Transport.Util;

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
        public void hasSufficientCreditTestTicket()
        {
            tokenSetup();
            bool expected = true;
            tk = new Ticket(RailMap.Instance.getLocation("Baker Street"), RailMap.Instance.getLocation("Kings Cross"), ac1, DateTime.Now);
            bool actual = tk.hasSufficientCredit();
            Assert.AreEqual(expected, actual);
           
        }
        [TestMethod()]
        public void hasSufficientCreditTestSmartCard()
        {
            tokenSetup();
            ac1.updateBalance(3);
            bool expected = false;
            sc = new SmartCard(ac1, false, 0);
            bool actual = sc.hasSufficientCredit();
            Assert.AreEqual(expected, actual);
            ac1.updateBalance(5);
            expected = true;
            actual = sc.hasSufficientCredit();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void incrementJourneyTestSmartCard()
        {
            tokenSetup();
            sc = new SmartCard(ac1, false, 0);
            sc.incrementJourney();
            int expected = 1;
            int actual = sc.getNumOfJourneys();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setScannedTestSmartCard()
        {
            tokenSetup();
            sc = new SmartCard(ac1, false, 0);
            sc.setScanned(true);
            bool expected = true;
            bool actual = sc.getScannedStatus();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void setScannedTestTicket()
        {
            tokenSetup();
            tk = new Ticket(RailMap.Instance.getLocation("Baker Street"), RailMap.Instance.getLocation("Kings Cross"), ac1, DateTime.Now);
            tk.setScanned(true);
            bool expected = true;
            bool actual = tk.getScannedStatus();
            Assert.AreEqual(expected, actual);
        }
    }
}