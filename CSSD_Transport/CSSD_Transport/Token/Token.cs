using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Token
{
	class Token
	{
		private int tokenID;
		protected Accounts.Passenger tokenUser;
		private string tokenType;
		private bool scanned;
		private int journeyCounter;
		private bool discounted;

		//Public Member Getters (Expression Bodied Member)

		public bool getScannedStatus() => scanned;

		public string getType() => tokenType;

		public int getNumOfJourneys() => journeyCounter;

		public int getID() => tokenID;

		public bool hasDiscount() => discounted;

		//TODO: wut?
		public bool hasSufficientCredit() => false;

		public void incrementJourney() => journeyCounter++;

		public void setScanned(bool s) => scanned = s;

	}
}
