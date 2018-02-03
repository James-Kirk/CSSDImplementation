using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Accounts;

namespace CSSD_Transport.Token
{
	class SmartCard : Token
	{
		public Account getAccount()
		{
			//TODO: Account is top-level and token is a passenger class
			//Account also needs to be protected to be accessed properly
		}

		public Journey.Journey getRecentJourney()
		{
			//TODO: Nothing in design
		}

		public float getAmountForJourneys()
		{
			//TODO: Nothing in design
		}

		public void updateAccountBalance(float a)
		{
			//TODO: Nothing in design
		}
	}
}
