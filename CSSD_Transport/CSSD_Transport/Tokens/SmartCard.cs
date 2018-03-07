﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Accounts;
using CSSD_Transport.Journeys;

namespace CSSD_Transport.Tokens
{
	public class SmartCard : Token
	{
        public SmartCard(int id, Account aTokenUser, string aTokenType, bool newScanned, int aJourneyCounter)
        {
            tokenID = id;
            tokenUser = aTokenUser;
            tokenType = aTokenType;
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
