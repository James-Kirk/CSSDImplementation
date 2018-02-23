using System;
using System.Collections.Generic;
using System.Text;

namespace CSSD_Transport.Accounts
{
	[Serializable]
	public class NormalAccount : Account
	{
		private DateTime DOB;

		public DateTime getDOB() => DOB;

		public void forgotAccount()
		{

		}
	}
}
