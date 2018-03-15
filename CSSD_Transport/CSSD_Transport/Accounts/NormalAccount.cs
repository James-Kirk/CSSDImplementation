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

        // call base constructor
        public NormalAccount(string u, string p, DateTime dob) : base(u, p) { this.DOB = dob; this.type = "Normal";}

		public void forgotAccount()
		{

		}
	}
}
