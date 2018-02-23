using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSSD_Transport.Token
{
	public class SetOfTokens : List<Token>
	{
		public Token findToken(int id)
		{
			return this.Find(i => i.getID() == id);
		}
	}
}
