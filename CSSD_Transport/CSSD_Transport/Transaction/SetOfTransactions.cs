using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Transaction
{
	class SetOfTransactions : List<Transaction>
	{
		public Transaction findTransaction(int id)
		{
			//return this.Find(i => i.getID() == id);
			return new Transaction();
		}
	}
}
