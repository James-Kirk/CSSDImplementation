using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Accounts
{
	public static class AccountServer
	{

        public static Account processLogin(string name, string password)
        {
            return SetOfAccounts.Instance.findAccount(name, password);
        }
	}
}
