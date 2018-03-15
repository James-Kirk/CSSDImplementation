using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Accounts;
using CSSD_Transport.Journeys;

namespace CSSD_Transport.Tokens
{
    [Serializable]
    public class SmartCard : Token
	{
        public SmartCard(Account aTokenUser, bool newScanned, int aJourneyCounter)
        {
            tokenID = tokenCount;
            tokenCount++;
            tokenUser = aTokenUser;
            tokenType = TokenType.SmartCard;
            scanned = newScanned;
            journeyCounter = aJourneyCounter;
        }

		public Account getAccount()
		{
            return tokenUser;

        }

        public Journey getRecentJourney()
		{
            //TODO: Nothing in design
            throw new NotImplementedException();
        }


		public float getAmountForJourneys()
		{
			//TODO: Nothing in design
			return 0.0f;
		}

		public void updateAccountBalance(float a)
		{
            this.tokenUser.updateBalance(a);
		}
	}
}
