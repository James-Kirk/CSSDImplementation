using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Accounts
{
	public static class AccountServer
	{
        private static SetOfAccounts accounts;

        public static bool processLogin(string name, string password)
        {
            if (accounts.findAccount(name, password) != null)
            {
                return true;
            }

            return false;
        }
	}
}
