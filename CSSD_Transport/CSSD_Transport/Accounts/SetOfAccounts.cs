using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Accounts
{
	public class SetOfAccounts : List<Account>
	{
		public Account findAccount(string username, string password)
		{
			return this.Find(i => i.getUsername() == username && i.getPass() == password);
		}
	}
}
