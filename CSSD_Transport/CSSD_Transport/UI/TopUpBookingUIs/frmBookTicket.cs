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
        }

        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            frmPrevious.Visible = true;
            this.Close();
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            tripCost = FareRules.Instance.calculateFare(cboLine.SelectedValue.ToString(), cboStart.SelectedValue.ToString(), cboDestination.SelectedValue.ToString());
            lblBookingCost.Text = "Cost of Booking: " + tripCost;
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            tripCost = FareRules.Instance.calculateFare(cboLine.SelectedValue.ToString(), cboStart.SelectedValue.ToString(), cboDestination.SelectedValue.ToString());
            if (tripCost <= bookingAccount.getBalance())
            {   // Account has enough funds
                Location startLocation = RailMap.Instance.getLocation(cboStart.SelectedValue.ToString());
                Location endLocation = RailMap.Instance.getLocation(cboDestination.SelectedValue.ToString());

                DateTime departureDate = dtpStartDate.Value;
                DateTime departureTime = dtpEndTime.Value;
                DateTime arrivalDate = dtpEndDate.Value;
                DateTime arrivalTime = dtpStartTime.Value;

                DateTime departure = new DateTime(departureDate.Year, departureDate.Month, departureDate.Day, departureTime.Hour, departureTime.Minute, 0);
                DateTime arrival = new DateTime(arrivalDate.Year, arrivalDate.Month, arrivalDate.Day, arrivalTime.Hour, arrivalTime.Minute, 0);

                Token bookingToken = new Ticket(startLocation, endLocation, bookingAccount, 73);
                SetOfTokens.Instance.addToken(bookingToken);

                Journey bookedJourney = new Journey(bookingToken, startLocation.ToString(), endLocation.ToString(), departure, arrival, tripCost);
                // Remove moneys from account
                bookingAccount.updateBalance(-(tripCost));
                bookedJourney.setPaid(true);
                //SetOfJourneys.Instance.addJourney(bookedJourney);
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
    }
}
