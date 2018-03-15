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
        frmBegin prevForm;
        public frmStaffLogin(frmBegin prev)
        {
            InitializeComponent();
            this.prevForm = prev;
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
            prevForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(SetOfStaffAccounts.Instance.FindStaffAccount(txtUsername.Text, txtPin.Text) != null)
            {
                new frmStaffUI(this).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }

        private void frmStaffLogin_VisibleChanged(object sender, EventArgs e)
        {
            txtPin.Text = "";
            txtUsername.Text = "";
        }
    }
}
