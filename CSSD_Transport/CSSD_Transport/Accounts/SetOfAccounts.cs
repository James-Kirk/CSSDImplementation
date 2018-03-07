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
        private SetOfAccounts()
		{
			//TEMPORARY
			//This hardcode adds the accounts to the system, but should really be handled by Serialisation!
			accounts.Add(new NormalAccount("James", "Bob", DateTime.Now));
			accounts.Add(new NormalAccount("Doom", "Guy", DateTime.Now));
			accounts.Add(new NormalAccount("Leroy", "Jenkins", DateTime.Now));
		}

        // Only allows 1 set of accounts to be created.
        public static SetOfAccounts Instance
        {
            get { return instance == null ? instance = new SetOfAccounts() : instance; }
           
            set { instance = value; }
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
