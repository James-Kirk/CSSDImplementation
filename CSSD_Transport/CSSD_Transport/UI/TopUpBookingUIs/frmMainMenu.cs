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
        public frmMainMenu(Account currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();
        }

        private void btnMyTrips_Click(object sender, EventArgs e)
        {
            frmTrips trips = new frmTrips(this);
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
            frmBookTicket bookTicket = new frmBookTicket(this);
            bookTicket.Show();
            this.Visible = false;
        }
    }
}
