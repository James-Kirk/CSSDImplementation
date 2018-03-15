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

        /// <summary>Preview UI design pattern, it all updates on selection changes</summary>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // gets and parses the selection for just the token ID
            String selection = lbxMyTrips.GetItemText(lbxMyTrips.SelectedItem);
            String[] splits = selection.Split(' ');
            int tokenId = Int32.Parse(splits[0]);

            // finds the ticket, marks it as printed to prevent printing multiple times then refreshes the list box
            Ticket ticket = (Ticket)SetOfTokens.Instance.findToken(tokenId);
            ticket.setPrintedStatus(true);
            lbxMyTrips.DataSource = null;
            lbxMyTrips.DataSource = SetOfTokens.Instance.getAccountTickets(account);
        }
    }
}
