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
            //TODO: serialisation stuff to implement here. - EF
            //TODO: UML says void, but personally I'd return true/false. - EF

            // CRC cards suggest we call 'findAccount' from SetOfAccounts.cs in this class
            if (accounts.findAccount(name, password) != null)
            {
                return true;
            }

            return false;
        }
	}
}
