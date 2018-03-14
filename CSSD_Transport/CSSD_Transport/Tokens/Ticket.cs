using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Journeys;

namespace CSSD_Transport.Tokens
{
	public class Ticket : Token
	{
        private Location start, end;

        public Ticket(Location start, Location end)
        {
            this.start = start;
            this.end = end;
            tokenType = TokenType.Ticket;
        }

        public Location getStart() => start;
        public Location getEnd() => end;
    }
}
