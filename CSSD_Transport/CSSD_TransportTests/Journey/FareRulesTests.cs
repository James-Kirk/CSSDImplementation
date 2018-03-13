using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSSD_Transport.Journey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Util;
using CSSD_Transport.Journeys;

namespace CSSD_Transport.Journeys.Tests
{
    [TestClass()]
    public class FareRulesTests
    {
		[TestMethod()]
		public void calculateFareTest()
		{
			string Line1 = "Circle";
			string Loc1 = "Aldgate";
			string Loc2 = "Westminster";

			float fareActual = FareRules.Instance.calculateFare(Line1, Loc1, Loc2);

			float fareExpected = (float)(0.75 * 4);

			Assert.AreEqual(fareActual, fareExpected);

		}

        [TestMethod()]
        public void calculateDiscountTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getMinAmountTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getNumForDayPassTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getFareRulesTest()
        {
            Assert.Fail();
        }
    }
}