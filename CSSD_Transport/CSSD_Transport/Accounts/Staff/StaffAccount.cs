using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Accounts
{
    [Serializable]
	public class StaffAccount
	{
        private string username, password;

        public StaffAccount(string usernameIn, string passwordIn)
        {
            this.username = usernameIn;
            this.password = passwordIn;
            SetOfStaffAccounts.Instance.AddStaffAccount(this);
        }

        public string getUsername() => username;
        public string getPassword() => password;
    }
}
