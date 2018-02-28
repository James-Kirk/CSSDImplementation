using System;
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
		public Account getAccount()
		{
            //TODO: Account is top-level and token is a passenger class
            //Account also needs to be protected to be accessed properly
            
            //TODO: why would we want to return new NormalAccount here? or was this just to  make it compile properly?
            // commented it out becuase I make normalAccount take 2 parameters for constructor now - EF
            // return new NormalAccount();
            return null;
        }

        public Journey getRecentJourney()
		{
			//TODO: Nothing in design
			return new Journey();
		}

		public float getAmountForJourneys()
		{
			//TODO: Nothing in design
			return 0.0f;
		}

		public void updateAccountBalance(float a)
		{
			//TODO: Nothing in design
		}
	}
}
