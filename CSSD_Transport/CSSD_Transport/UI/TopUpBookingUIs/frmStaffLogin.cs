using CSSD_Transport.Accounts;
using CSSD_Transport.UI.TopUpBookingUIs;
using CSSD_Transport.Util;
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
    public partial class frmStaffLogin : Form
    {
        public frmStaffLogin()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            new frmCreateStaffAccount().ShowDialog();
            txtPin.Text = "";
            txtUsername.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(SetOfStaffAccounts.Instance.FindStaffAccount(txtUsername.Text, txtPin.Text) != null)
            {
                new frmStaffUI().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }
    }
}
