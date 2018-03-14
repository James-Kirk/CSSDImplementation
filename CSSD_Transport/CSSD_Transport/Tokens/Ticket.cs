using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Journeys;
using CSSD_Transport.Accounts;

namespace CSSD_Transport.Tokens
{
	public class Ticket : Token
	{
        private Location start, end;
        private DateTime departure;

        public Ticket(Location start, Location end, Account aTokenUser, int id, DateTime departure )
        {
            this.start = start;
            this.end = end;
            this.tokenUser = aTokenUser;
            tokenType = TokenType.Ticket;
        }

        public Location getStart() => start;
        public Location getEnd() => end;
    }
}
