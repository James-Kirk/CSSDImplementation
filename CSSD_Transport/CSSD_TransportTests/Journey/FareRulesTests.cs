using Microsoft.VisualStudio.TestTools.UnitTesting;
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
		public void calculateFareSeperateLines()
		{
			string Line1 = "Circle";
			string Loc1 = "Aldgate";
			string Loc2 = "Brixton";

			float fareActual = FareRules.Instance.calculateFare(Line1, Loc1, Loc2);

			float fareExpected = -1 * FareRules.Instance.getCostPerStation();

			Assert.AreEqual(fareActual, fareExpected);
		}

		[TestMethod()]
		public void calculateFareSameStation()
		{
			string Line1 = "Circle";
			string Loc1 = "Aldgate";
			string Loc2 = "Aldgate";

			float fareActual = FareRules.Instance.calculateFare(Line1, Loc1, Loc2);

			float fareExpected = 0 * FareRules.Instance.getCostPerStation();

			Assert.AreEqual(fareActual, fareExpected);
		}

		[TestMethod()]
        public void calculateDiscountTest()
        {
			Assert.AreEqual(FareRules.Instance.getDayPassCost(), FareRules.Instance.calculateDiscount(5));
        }

        [TestMethod()]
        public void getMinAmountTest()
        {
			Assert.AreEqual(5.0f, FareRules.Instance.getMinAmount());
        }

        [TestMethod()]
        public void getNumForDayPassTest()
        {
			Assert.AreEqual(FareRules.Instance.getNumForDayPass(), 7);
        }

        [TestMethod()]
        public void getFareRulesTest()
        {
			Assert.AreEqual(FareRules.Instance, FareRules.Instance.getFareRules());
        }
    }
}