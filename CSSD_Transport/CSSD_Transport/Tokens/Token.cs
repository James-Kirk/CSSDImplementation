using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Accounts;
using CSSD_Transport.Journeys;

namespace CSSD_Transport.Tokens
{

	public enum TokenType
	{
		SmartCard, Pass, Ticket, Biometric
	}

	public abstract class Token
	{
		protected int tokenID;
		protected Account tokenUser;
		protected TokenType tokenType;
		protected bool scanned;
		protected int journeyCounter;
		protected bool discounted;

		public bool getScannedStatus() => scanned;

		public TokenType getType() => tokenType;

		public int getNumOfJourneys() => journeyCounter;

		public int getID() => tokenID;

		public bool hasDiscount() => discounted;
        
		public bool hasSufficientCredit()
        {
            float min = FareRules.Instance.getFareRules().getMinAmount();
            float accountCredit = tokenUser.getBalance();
            if (accountCredit < min)
                return false;
            else
                return true;
        }

		public void incrementJourney() => journeyCounter++;

		public void setScanned(bool s) => scanned = s;

	}
}
