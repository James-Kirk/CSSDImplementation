﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Accounts
{
	class AccountServer
	{
        private SetOfAccounts accounts;

        public bool processLogin(string name, string password)
        {
            //TODO: serialisation stuff to implement here. - EF
            //TODO: UML says void, but personally I'd return true/false. - EF

            // CRC cards suggest we call 'findAccount' from SetOfAccounts.cs in this class
            if (accounts.findAccount(name, password) == null)
            {
                return false;
            }

            return false;
        }
	}
}
