using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Journeys
{
    [Serializable]
	public class SetOfJourneys
    {
        private List<Journey> journeys = new List<Journey>();
        private static SetOfJourneys instance;

        SetOfJourneys() { }

        public static SetOfJourneys Instance
        {
            get { return instance ?? (instance = new SetOfJourneys()); }

            set { instance = value; }
        }

        public float getAmountForAllJourneys()
		{
			float sum = 0;
            foreach(var J in journeys)
			{
				sum += J.getAmountPaid();
			}

			return sum;
        }
        public float getAmountForAllJourneys(int id)
        {
            float sum = 0;
            List<Journey> a = (List<Journey>)journeys.Where(n => n.getTokenId() == id);
            foreach (var J in a)
            {
                sum += J.getAmountPaid();
            }

            return sum;
        }
        public Journey findMostRecentJourney()
		{
			return journeys[journeys.Count];
        }

        public Journey findTokensMostRecentJourney(int id)
        {
            List<Journey> a = (List<Journey>)journeys.Where(n => n.getTokenId() == id);
            return a[a.Count - 1];
        }
	}
}
