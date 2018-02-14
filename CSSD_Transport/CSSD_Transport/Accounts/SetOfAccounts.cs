using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Accounts
{
    [Serializable]
    public class SetOfAccounts
	{
        private List<Account> accounts = new List<Account>();
        private static SetOfAccounts instance;
        private SetOfAccounts() { }

        // Only allows 1 set of accounts to be created.
        public static SetOfAccounts Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SetOfAccounts();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public void addAccount(Account a)
        {
            this.accounts.Add(a);
        }

		public Account findAccount(string username, string password)
		{
			return accounts.Find(i => i.getUsername() == username && i.getPass() == password);
		}
	}
}
