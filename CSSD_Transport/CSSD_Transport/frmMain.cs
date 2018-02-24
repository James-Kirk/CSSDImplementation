using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSSD_Transport.Accounts;

namespace CSSD_Transport
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

        private void frmMain_Load(object sender, EventArgs e)
        {
            //this will need to be called at the very beginning of program ALWAYS
            Serialization.loadAll();

            // USE TO CREATE A STAFF ACCOUNT
            // StaffAccount staffAccount = new StaffAccount("EllieFuller", "password");

            // USE TO CREATE A NORMAL ACCOUNT
            // SetOfAccounts.Instance.addAccount(new NormalAccount("smelon", "password", DateTime.Now));

            // USE FOR STAFF LOGIN FUNCTIONALITY
            // StaffAccount x = SetOfStaffAccounts.Instance.FindStaffAccount("EllieFuller", "password");

            // USE FOR NORMAL PERSON LOGIN FUNCTIONALITY
            // Account y = SetOfAccounts.Instance.findAccount("smelon", "password");

            //this will need to be called at the very end of program ALWAYS
            Serialization.saveAll();
        }
    }
}
