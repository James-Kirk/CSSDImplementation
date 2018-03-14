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
            tokens.Add(new SmartCard((SetOfAccounts.Instance.findAccount("Leroy", "Jenk")),  false, 0));
            tokens.Add(new SmartCard((SetOfAccounts.Instance.findAccount("James", "1234")),  false, 0));
            tokens.Add(new SmartCard((SetOfAccounts.Instance.findAccount("Doom", "Guys")),  false, 0));
        }

		public static SetOfTokens Instance
		{
			get { return instance ?? (instance = new SetOfTokens()); }

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

        public List<String> getAccountTickets(Account a)
        {
            List<Token> tks = tokens.FindAll(t => t.getAccount() == a && t.getType() == TokenType.Ticket);
            List<Ticket> tickets = new List<Ticket>();

            foreach (Token t in tks)
            {
                tickets.Add((Ticket)t);
            }

            List<String> ticketStrings = new List<String>();
            foreach (Ticket t in tickets)
            {
                if (!t.getPrintedStatus())
                {
                    ticketStrings.Add(t.getID().ToString() + " " + t.getStart().getLocation() + " -> " + t.getEnd().getLocation() + " @ " + t.getDepartureString());
                }
            }

            return ticketStrings;
        }
	}
}
