using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Journeys
{
	public class FareRules
	{
		private float minAmount;
		private int dayPassNum;

		private FareRules aFareFule;

		FareRules() { }

		public float calculateFare(string from, string to)
		{
			return 0.0f;
		}

		public float calculateDiscount(int n)
		{
			return 0.0f;
		}

		public float getMinAmount() => minAmount;

		public int getNumForDayPass() => dayPassNum;

		public FareRules getFareRules() => aFareFule;

	}
}
