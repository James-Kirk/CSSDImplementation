using CSSD_Transport.Accounts;
using CSSD_Transport.Journeys;
using CSSD_Transport.Tokens;
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
    public partial class frmTrips : Form
    {
        frmMainMenu frmPrevious;
        Account account;
        public frmTrips(frmMainMenu prev, Account account)
        {
            InitializeComponent();
            frmPrevious = prev;
            this.account = account;
            lbxMyTrips.DataSource = SetOfTokens.Instance.getAccountTickets(account);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmPrevious.Visible = true;
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            String selection = lbxMyTrips.GetItemText(lbxMyTrips.SelectedItem);
            String[] splits = selection.Split(' ');
            int tokenId = Int32.Parse(splits[0]);

            Ticket ticket = (Ticket)SetOfTokens.Instance.findToken(tokenId);
            ticket.setPrintedStatus(true);
            lbxMyTrips.DataSource = null;
            lbxMyTrips.DataSource = SetOfTokens.Instance.getAccountTickets(account);
        }
    }
}
