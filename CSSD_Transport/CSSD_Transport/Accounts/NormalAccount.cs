using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Accounts
{
	class NormalAccount : Account
    {
        //TODO: just a note, what a shitty class lol. DOB is never even used. - EF
        private DateTime DOB;
        
        public DateTime getDOB() => DOB;
    }
}
