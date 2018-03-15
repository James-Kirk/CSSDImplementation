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
        private frmBegin prev;

        public frmLogin(frmBegin prev)
        {
            InitializeComponent();
            this.prev = prev;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //SOME FORM OF PASS HASHING SHOULD BE DONE HERE
            Account a = login(txtUsername.Text, txtPin.Text);
            if (a != null)
            {
                frmMainMenu mm = new frmMainMenu(a, this);
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

        private void frmLogin_VisibleChanged(object sender, EventArgs e)
        {
            txtPin.Text = "";
        }

        private void btnBackToSim_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSimSmartCard_Click(object sender, EventArgs e)
        {
            prev.Visible = true;
            this.Close();
        }
    }
}
