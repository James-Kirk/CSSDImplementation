using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Tokens;

namespace CSSD_Transport.Journeys
{
    [Serializable]
    public class Journey
	{
		private static uint idCounter = 0;

		private uint journeyID;
		private Token tokenUsed;
		private string fromLocation;
		private string toLocation;
		private DateTime startDate;
		private DateTime endDate;
		private float amountPaid;
        private bool pre_paid = false;

        public Journey(Token t, String aFromLocation, String aToLocation, DateTime aStartDate, DateTime aEndDate, float paid)
        {
			journeyID = ++idCounter;
            tokenUsed = t;
            fromLocation = aFromLocation;
            toLocation = aToLocation;
            startDate = aStartDate;
            endDate = aEndDate;
            amountPaid = paid;
        }

		public uint getID() => journeyID;

        public DateTime getStartDate() => startDate;
        public DateTime getEndDate() => endDate;

        public string getStartLocation() => fromLocation;

		public string getEndLocation() => toLocation;

		public int getTokenId() => tokenUsed.getID();

		//TODO: Added param i, not present in UML
		public void setAmountPaid(float i) => amountPaid = i;

		public void setToLocation(string s) => toLocation = s;

		public void setEndDate(DateTime d) => endDate = d;

		public float getAmountPaid() => amountPaid;

        public void setPaid(bool paid) => pre_paid = paid;

        public bool getPaid() => pre_paid;
	}
}
