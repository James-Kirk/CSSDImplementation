using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSSD_Transport.Tokens
{
	public class SetOfTokens
	{
		private List<Token> tokens = new List<Token>();
		private static SetOfTokens instance;

		public SetOfTokens() { }

		public static SetOfTokens Instance
		{
			get { return instance == null ? instance = new SetOfTokens() : instance; }

			set { instance = value; }
		}

		public Token findToken(int id)
		{
			return tokens.Find(i => i.getID() == id);
		}
	}
}
