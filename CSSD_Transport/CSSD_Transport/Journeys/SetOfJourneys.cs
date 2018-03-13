using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Journeys
{
	public class SetOfJourneys : List<Journey>
    {
        public float getAmountForAllJourneys()
		{
			float sum = 0;
            foreach(var J in this)
			{
				sum += J.getAmountPaid();
			}

			return sum;
        }
		public Journey findMostRecentJourney()
		{
			return this[this.Count];
        }

        public Journey findTokensMostRecentJourney(int id)
        {
            List<Journey> a = (List<Journey>)this.Where(n => n.getTokenId() == id);
            return a[a.Count - 1];
        }
	}
}
