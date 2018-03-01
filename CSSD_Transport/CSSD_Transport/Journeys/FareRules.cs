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
		private int dayPassNum; // number of journeys required before a day pass discount is applied

        private static FareRules aFareRule;

		FareRules() { }

        // Singleton
        public static FareRules Instance
        {
            get
            {
                if (aFareRule == null)
                {
                    aFareRule = new FareRules();
                }
                return aFareRule;
            }
        }

		public float calculateFare(string from, string to)
		{
            throw new NotImplementedException();
        }

		public float calculateDiscount(int n)
		{
			return 0.0f;
		}

		public float getMinAmount() => minAmount;

		public int getNumForDayPass() => dayPassNum;

		public FareRules getFareRules() => aFareRule;

	}
}
