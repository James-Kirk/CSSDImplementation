using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Accounts
{
	[Serializable]
	public class NormalAccount : Account
	{
		private DateTime DOB;

		public DateTime getDOB() => DOB;
	}
}
