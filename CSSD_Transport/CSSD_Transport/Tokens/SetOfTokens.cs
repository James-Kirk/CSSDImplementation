using CSSD_Transport.Accounts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSSD_Transport.Tokens
{
	public class SetOfTokens
	{
		private List<Token> tokens = new List<Token>();
		private static SetOfTokens instance;

		public SetOfTokens()
        {
            tokens.Add(new SmartCard(1, (SetOfAccounts.Instance.findAccount("Leroy", "Jenkins")), false, 0));
            tokens.Add(new SmartCard(2, (SetOfAccounts.Instance.findAccount("James", "Bob")), false, 0));
            tokens.Add(new SmartCard(3, (SetOfAccounts.Instance.findAccount("Doom", "Guy")), false, 0));
        }

		public static SetOfTokens Instance
		{
			get { return instance == null ? instance = new SetOfTokens() : instance; }

			set { instance = value; }
		}

		public void addToken(Token t)
		{
			tokens.Add(t);
		}

		public Token findToken(int id)
		{
			return tokens.Find(i => i.getID() == id);
		}
	}
}
