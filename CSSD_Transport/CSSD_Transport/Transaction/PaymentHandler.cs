using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSD_Transport.Transaction
{
	public static class PaymentHandler
	{
        // TODO: note i've changed from UML void to bool. made more sense to 
        // return true or false indicating if payment worked. - EF
        public static bool authorise(float a, string m, string e)
        {
            return true;
        }
	}
}
