using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Journeys
{
	public class Journey
	{
		private int journeyID;
		private Token.Token tokenUsed;
		private string fromLocation;
		private string toLocation;
		private DateTime startDate;
		private DateTime toDate;
		private float amountPaid;

		public string getStartLocation() => fromLocation;

		public string getEndLocation() => toLocation;

		public int getTokenId() => tokenUsed.getID();

		//TODO: Added param i, not present in UML
		public void setAmountPaid(int i) => amountPaid = i;

		public void setToLocation(string s) => toLocation = s;

		public void setEndDate(DateTime d) => toDate = d;
	}
}
