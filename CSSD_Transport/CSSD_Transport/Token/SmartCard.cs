using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Accounts;
using CSSD_Transport.Journeys;

namespace CSSD_Transport.Token
{
	public class SmartCard : Token
	{
		public Account getAccount()
		{
			//TODO: Account is top-level and token is a passenger class
			//Account also needs to be protected to be accessed properly
			return new NormalAccount();
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
