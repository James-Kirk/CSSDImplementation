using CSSD_Transport.Accounts;
using CSSD_Transport.Tokens;
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

        public void addJourney(Journey j)
        {
            journeys.Add(j);
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
            List<Journey> journeysToday = new List<Journey>();
            foreach (var item in journeys)
            {
                if (item.getTokenId() == id)
                {
                    journeysToday.Add(item);
                }
            }
            foreach (var J in journeysToday)
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
            List<Journey> js = new List<Journey>();
            foreach (var item in journeys)
            {
                if (item.getTokenId() == id)
                {
                    js.Add(item);
                }
            }
            if (js.Any())
                return js.Last();
            return null;
            //List<Journey> a = (List<Journey>)journeys.Where(n => n.getTokenId() == id);
            //return a[a.Count - 1];
        }

        public List<Journey> getAllJourneys()
        {
            return journeys;
        }

        public List<Journey> getJourneysByStations(string stationName)
        {
            return journeys.FindAll(j => j.getStartLocation() == stationName || j.getEndLocation() == stationName);
        }

        public List<Journey> getJourneysByDate(DateTime dt , List<Journey> js)
        {
            return js.FindAll(j => j.getStartDate().Date == dt.Date || j.getEndDate().Date == dt.Date);
        }
    }
}
