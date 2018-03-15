using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Journeys;
using CSSD_Transport.Accounts;

namespace CSSD_Transport.Tokens
{
    [Serializable]
    public class Ticket : Token
	{
        private Location start, end;
        private DateTime departure;
        private bool printed;

        public Ticket(Location start, Location end, Account aTokenUser, DateTime departure)
        {
            this.start = start;
            this.end = end;
            this.tokenUser = aTokenUser;
            this.departure = departure;
            this.printed = false;
            tokenType = TokenType.Ticket;
            tokenID = tokenCount;
            tokenCount++;
        }

        public String getDepartureString()
        {
            return departure.ToString();
        }
        
        public bool getPrintedStatus()
        {
            return printed;
        }

        public void setPrintedStatus(bool status)
        {
            this.printed = status;
        }

        public Location getStart() => start;
        public Location getEnd() => end;
    }
}
