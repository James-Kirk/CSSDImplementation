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
            //SetOfAccounts.Instance.addAccount(new Account("Ellie", "password"));
            //Serialization.saveAll();
            //Serialization.loadAll();
        }
    }
}
