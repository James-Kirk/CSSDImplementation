﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSSD_Transport.Accounts
{
    [Serializable]
	public abstract class Account
	{
		protected string username, password, type;
		private float creditAmount;
        // Ellie likes ass
        public Account() { }
        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        
		public string getUsername() => username;
		public string getPass() => password;
		public string getType() => type;
		public float getCreditAmount() => creditAmount;

		public void updateBalance(float a)
		{

		}

		public void processTopUp(float a, string m)
		{

		}
	}
}
