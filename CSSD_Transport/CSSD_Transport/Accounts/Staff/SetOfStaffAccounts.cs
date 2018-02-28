using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Accounts
{
    [Serializable]
	public class SetOfStaffAccounts
	{
        private List<StaffAccount> accounts = new List<StaffAccount>();
        private static SetOfStaffAccounts instance;

        //private constructor disallows the class being instantiated 
        private SetOfStaffAccounts() { }

        public void AddStaffAccount(StaffAccount a)
        {
            this.accounts.Add(a);
        }

        // Only allows 1 set of accounts to be created.
        public static SetOfStaffAccounts Instance
        {
            get { return instance == null ? instance = new SetOfStaffAccounts() : instance; }

            set { instance = value; }
        }

        public StaffAccount FindStaffAccount(string username, string password)
        {
            return accounts.Find(i => i.getUsername() == username && i.getPassword() == password);
        }
	}
}
