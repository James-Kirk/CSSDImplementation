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
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                throw new ArgumentException();
            this.username = username;
            this.password = password;
            this.creditAmount = 0.0f;
        }
        
		public string getUsername() => username;
		public string getPass() => password;
		public string getType() => type;
		public float getCreditAmount() => creditAmount;

		/// <summary>
		/// Updates the accounts balance by a given number
		/// </summary>
		/// <param name="amount">The amount to update by (float)</param>
		public void updateBalance(float amount)
		{
            if (amount == 0)
                throw new ArgumentException();
            this.creditAmount += amount;
		}

        public float getBalance()
        {
            return this.creditAmount;
        }
        
		/// <summary>
		/// Processes a top-up via the PaymentHandler
		/// </summary>
		/// <param name="amount">The amount to top-up</param>
		/// <param name="m">String m</param>
		/// <returns></returns>
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
