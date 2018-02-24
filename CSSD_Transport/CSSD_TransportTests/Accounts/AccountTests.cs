using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSSD_Transport.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Accounts.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void getUsernameTest()
        {
            // Setup
            var account = new NormalAccount("Will Smith", "Fre$hPrince", DateTime.Now);
            string expected = "Will Smith";

            // Method
            string actual = account.getUsername();

            // Assertion
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getPassTest()
        {
            // Setup
            var account = new NormalAccount("Will Smith", "Fre$hPrince", DateTime.Now);
            string expected = "Fre$hPrince";

            // Method
            string actual = account.getPass();

            // Assertion
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void getTypeTest()
        {
            // Setup
            var account = new NormalAccount("Will Smith", "Fre$hPrince", DateTime.Now);
            string expected = "Normal";
            var anonAccount = new AnonymousAccount();
            string anonExpected = "Anonymous";

            // Method
            string actual = account.getType();
            string anonActual = anonAccount.getType();

            // Assertion
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(anonExpected, anonActual);
        }

        [TestMethod()]
        public void getCreditAmountTest()
        {
            // Setup
            var account = new NormalAccount("Will Smith", "Fre$hPrince", DateTime.Now);
            float expected = 30;

            // Method
            float actual = account.getCreditAmount();

            // Assertion
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void updateBalanceTest()
        {
            // Setup
            var account = new NormalAccount("Will Smith", "Fre$hPrince", DateTime.Now);
            float expected = 30;
            float negativeExpected = 10;

            // Method
            account.updateBalance(15);
            float actual = account.getCreditAmount();
            account.updateBalance(-20);
            float negativeActual = account.getCreditAmount();

            // Assertion
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(negativeExpected, negativeActual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void updateBalanceNullTest()
        {
            // Setup
            var account = new NormalAccount("Will Smith", "Fre$hPrince", DateTime.Now);

            // Method
            account.updateBalance(0);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void createNullUsernameAccountTest()
        {
            var account = new NormalAccount(null, "Fre$hPrince", DateTime.Now);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void createNullPasswordAccountTest()
        {
            var account = new NormalAccount("Will Smith", null, DateTime.Now);
        }
    }
}