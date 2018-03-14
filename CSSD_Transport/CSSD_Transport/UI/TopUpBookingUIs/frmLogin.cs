using CSSD_Transport.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSD_Transport.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSimSmartCard_Click(object sender, EventArgs e)
        {
            /*
            if (btnSimSmartCard.Text == "Cancel")
            {
                btnSimSmartCard.Text = "Simulate Smart Card";
                txtPin.Visible = false;
                btnConfirm.Visible = false;
            }
            else
            {
                btnSimSmartCard.Text = "Cancel";
                txtPin.Visible = true;
                btnConfirm.Visible = true;
            }
            */
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //SOME FORM OF PASS HASHING SHOULD BE DONE HERE
            Account a = login(txtUsername.Text, txtPin.Text);
            if (a != null)
            {
                frmMainMenu mm = new frmMainMenu(a);
                mm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Pin");
            }
            
        }

        private Account login(string user, string pass)
        {
           return AccountServer.processLogin(user, pass);
        }

        private void txtPin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnConfirm_Click(sender, e);
            }
        }
    }
}
