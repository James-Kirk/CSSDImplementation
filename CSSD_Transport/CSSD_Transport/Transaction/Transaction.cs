using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Transaction
{
	public class Transaction
	{
		public static int counter = 0;

		private int transactionID;
		private string transactionType;
		private float transactionAmount;

		public Transaction()
		{
			transactionID = counter++;
		}

		public Transaction(string type, float amount)
		{
			transactionID = counter++;
			transactionType = type;
			transactionAmount = amount;
		}

		public int getID() => transactionID;
		public string getType() => transactionType;
		public float getAmount() => transactionAmount;

		public void setID(int id) => transactionID = id;
		public void setType(string type) => transactionType = type;
		public void setAmount(float amount) => transactionAmount = amount;


	}
}
