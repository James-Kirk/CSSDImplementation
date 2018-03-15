using CSSD_Transport.Accounts;
using CSSD_Transport.UI.TopUpBookingUIs;
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
    public partial class frmMainMenu : Form
    {
        public Account currentAccount;
        private frmLogin prev;
        public frmMainMenu(Account currentAccount, frmLogin prev)
        {
            this.currentAccount = currentAccount;
            this.prev = prev;
            InitializeComponent();
            lblWelcome.Text = "Welcome " + this.currentAccount.getUsername() + "!";
        }

        private void btnMyTrips_Click(object sender, EventArgs e)
        {
            frmTrips trips = new frmTrips(this, currentAccount);
            this.Visible = false;
            trips.Show();
        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            frmTopUp topUp = new frmTopUp(this);
            topUp.Show();
            this.Visible = false;
        }

        private void btnBookTickets_Click(object sender, EventArgs e)
        {
            frmBookTicket bookTicket = new frmBookTicket(this, currentAccount);
            bookTicket.Show();
            this.Visible = false;   
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            prev.Visible = true;
            this.Close();
        }
    }
}
