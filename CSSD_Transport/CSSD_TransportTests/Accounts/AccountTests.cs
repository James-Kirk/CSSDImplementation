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
            // TODO: Once account has a constructor, need to add in parameters
            var account = new Account();
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
            // TODO: Once account has a constructor, need to add in parameters
            var account = new Account();
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
            // TODO: Once account has a constructor, need to add in parameters
            var account = new Account();
            string expected = "Normal";
            var anonAccount = new Account();
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
            // TODO: Once account has a constructor, need to add in parameters
            var account = new Account();
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
            // TODO: Once account has a constructor, need to add in parameters
            var account = new Account();
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
    }
}