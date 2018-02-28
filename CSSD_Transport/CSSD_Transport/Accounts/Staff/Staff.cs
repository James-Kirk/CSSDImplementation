using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Accounts.Staff
{
	class Staff
	{
        private string staffName, staffPosition;

        public string getStaffName() => staffName;
        public string getStaffPosition() => staffPosition;

        // TODO: shitty name. I THINK this is for staff to override the gate controls
        //       incase of some fault. -EF
        public void invalidTokenScanned()
        {

        }
        //TODO: I'd merge this with staffAccount.cs 
        //      I see no need for 2 separate classes - EF
	}
}
