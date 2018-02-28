using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Singleton

namespace CSSD_Transport.Transaction
{
	[Serializable]
	public class SetOfTransactions
	{
		private static SetOfTransactions instance;

		private List<Transaction> transactions = new List<Transaction>();

		private SetOfTransactions() { }

		public static SetOfTransactions Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new SetOfTransactions();
				}
				return instance;
			}
			set
			{
				instance = value;
			}
		}

		public void addTransaction(Transaction t)
		{
			transactions.Add(t);
		}

		public Transaction findTransaction(int id)
		{
			return transactions.Find(i => i.getID() == id);
		}
	}
}
