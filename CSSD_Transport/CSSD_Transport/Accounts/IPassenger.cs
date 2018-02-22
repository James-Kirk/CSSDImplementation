using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Accounts
{
	public interface IPassenger
	{
		string getUsername();
		string getPass();
		string getType();
		float getCreditAmount();

		void updateBalance(float a);
		void forgotAccount();
		void processTopUp(float a, string m);
	}
}
