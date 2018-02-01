using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Journey
{
	class FareRules
	{
		private float minAmount;
		private int dayPassNum;

		private FareRules aFareFule;

		FareRules() { }

		public float calculateFare(string from, string to)
		{
            throw new NotImplementedException();
        }

		public float calculateDiscount(int n)
		{
            throw new NotImplementedException();
        }

		public float getMinAmount() => minAmount;

		public int getNumForDayPass() => dayPassNum;

		public FareRules getFareRules() => aFareFule;

	}
}
