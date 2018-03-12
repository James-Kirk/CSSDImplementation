using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Util;

namespace CSSD_Transport.Journeys
{
	public class FareRules
	{
		private const float minAmount = 5.0f; 
		private const int dayPassNum = 7;
		private const float costPerStation = 0.75f;

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

		public float calculateFare(string lineName, string from, string to)
		{
			int distance = RailMap.Instance.getDistance(lineName, from, to);
			return (distance * costPerStation);
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
