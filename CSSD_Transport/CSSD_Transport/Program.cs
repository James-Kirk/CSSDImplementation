using CSSD_Transport.UI;
using CSSD_Transport.UI.Travel_UI;
using CSSD_Transport.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSD_Transport
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmMain());
            //Application.Run(new frmBegin());
            Application.Run(new frmStaffUI());
            //Application.Run(new frmGateEntry());
            Serialization.saveAll();
        }
	}
}
