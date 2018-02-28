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

        public static Account processLogin(string name, string password)
        {
            return accounts.findAccount(name, password);
        }
	}
}
