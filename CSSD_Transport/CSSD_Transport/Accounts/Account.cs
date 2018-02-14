using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Accounts
{
    [Serializable]
	public class Account
	{
		private string username, password, type;
		private float creditAmount;

        public Account() { }
        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        
		public string getUsername() => username;
		public string getPass() => password;
		public string getType() => type;
		public float getCreditAmount() => creditAmount;

		public void updateBalance(float a)
		{

		}

		public void forgotAccount()
		{

		}

		public void processTopUp(float a, string m)
		{

		}
	}
}
