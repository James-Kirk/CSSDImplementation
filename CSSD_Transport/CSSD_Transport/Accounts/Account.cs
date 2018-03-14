using System;
using System.Collections.Generic;
using System.Text;

namespace CSSD_Transport.Accounts
{
    [Serializable]
	public abstract class Account
	{
		protected string username, password, type;

		private float creditAmount;

        public Account() { }
        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.creditAmount = 0.0f;
        }
        
		public string getUsername() => username;
		public string getPass() => password;
		public string getType() => type;
		public float getCreditAmount() => creditAmount;

		public void updateBalance(float amount)
		{
            this.creditAmount += amount;
		}

        public float getBalance()
        {
            return this.creditAmount;
        }
        
		public bool processTopUp(float amount, string m)
		{
            if(Transaction.PaymentHandler.authorise(amount, m, ""))
            {
                updateBalance(amount);
                return true;
            }
            return false; 
        } 
	}
}
