using CSSD_Transport.Accounts;
using CSSD_Transport.Journeys;
using CSSD_Transport.Tokens;
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

namespace CSSD_Transport.UI.TopUpBookingUIs
{
    public partial class frmBookTicket : Form
    {
        frmMainMenu frmPrevious;
        Account bookingAccount;
        float tripCost = 0.0f;

        public frmBookTicket(frmMainMenu prev, Account currentAccount)
        {
            InitializeComponent();
            cboLine.DataSource = RailMap.Instance.getLineNames();
            lblBookingCost.Text = "Cost of Booking: 0.00";
            this.frmPrevious = prev;
            this.bookingAccount = currentAccount;
            cboStart.DataSource = RailMap.Instance.getStationNames(cboLine.SelectedValue.ToString());
            cboDestination.DataSource = RailMap.Instance.getStationNames(cboLine.SelectedValue.ToString());
            cboStart.SelectedIndex = 4;
            cboDestination.SelectedIndex = 11;
            dtpStartDate.Value = DateTime.Now;
            dtpStartTime.Value = DateTime.Now.AddHours(1);
        }

        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            frmPrevious.Visible = true;
            this.Close();
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            tripCost = FareRules.Instance.calculateFare(cboLine.SelectedValue.ToString(), cboStart.SelectedValue.ToString(), cboDestination.SelectedValue.ToString());
            if (tripCost <= bookingAccount.getBalance())
            {   // Account has enough funds
                Location startLocation = RailMap.Instance.getLocation(cboStart.SelectedValue.ToString());
                Location endLocation = RailMap.Instance.getLocation(cboDestination.SelectedValue.ToString());

                DateTime departureDate = dtpStartDate.Value;
                DateTime departureTime = dtpStartTime.Value;

                DateTime departure = new DateTime(departureDate.Year, departureDate.Month, departureDate.Day, departureTime.Hour, departureTime.Minute, 0);

                Token bookingToken = new Ticket(startLocation, endLocation, bookingAccount, 73, departure);
                SetOfTokens.Instance.addToken(bookingToken);

                // Need to do pricing properly
                bookingAccount.updateBalance(-(tripCost));
            }
            else
            {   // Account doesn't have enough funds
                
            }
        }

        private void cboLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStart.DataSource = RailMap.Instance.getStationNames(cboLine.SelectedValue.ToString());
            cboDestination.DataSource = RailMap.Instance.getStationNames(cboLine.SelectedValue.ToString());
        }

        private void cboStart_SelectedValueChanged(object sender, EventArgs e)
        {            
            tripCost = FareRules.Instance.calculateFare(cboLine.SelectedValue.ToString(), cboStart.SelectedValue.ToString(), cboDestination.SelectedValue?.ToString());
            lblBookingCost.Text = "Cost of Booking: " + tripCost;
        }

        private void cboDestination_SelectedValueChanged(object sender, EventArgs e)
        {
            tripCost = FareRules.Instance.calculateFare(cboLine.SelectedValue.ToString(), cboStart.SelectedValue.ToString(), cboDestination.SelectedValue?.ToString());
            lblBookingCost.Text = "Cost of Booking: " + tripCost;
        }
    }
}
