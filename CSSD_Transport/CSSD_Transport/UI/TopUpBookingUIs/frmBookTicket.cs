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
            // Set data sources of the combo boxes to the stations on the selected line
            cboStart.DataSource = RailMap.Instance.getStationNames(cboLine.SelectedValue.ToString());
            cboDestination.DataSource = RailMap.Instance.getStationNames(cboLine.SelectedValue.ToString());
            // Set nice defaults, Kings Cross -> Embankment
            cboStart.SelectedIndex = 4;
            cboDestination.SelectedIndex = 11;
            // Sets nice defaults for time, the current day but an hour ahead
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

                if (startLocation.getLocation() == endLocation.getLocation())
                {
                    MessageBox.Show("Cannot have the same location from/to!", "", MessageBoxButtons.OK);
                }
                else
                {
                    DateTime departureDate = dtpStartDate.Value;
                    DateTime departureTime = dtpStartTime.Value;

                    DateTime departure = new DateTime(departureDate.Year, departureDate.Month, departureDate.Day, departureTime.Hour, departureTime.Minute, 0);
                    if (DateTime.Compare(departure, DateTime.Now) >= 0)
                    {
                        // Make ticket and add it to set of all tokens
                        Token bookingToken = new Ticket(startLocation, endLocation, bookingAccount, departure);
                        SetOfTokens.Instance.addToken(bookingToken);
                        // Updates the account balance - user won't be charged again at the gate               
                        bookingAccount.updateBalance(-(tripCost));
                    }
                    else
                    {
                        MessageBox.Show("Date/Time is in the past!", "", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {   // Account doesn't have enough funds
                MessageBox.Show("Not enough funds on your account!", "", MessageBoxButtons.OK);
            }
        }

        private void cboLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStart.DataSource = RailMap.Instance.getStationNames(cboLine.SelectedValue.ToString());
            cboDestination.DataSource = RailMap.Instance.getStationNames(cboLine.SelectedValue.ToString());
        }

        /// <summary>Preview UI design pattern, it all updates on selection changes</summary>
        private void cboStart_SelectedValueChanged(object sender, EventArgs e)
        {            
            tripCost = FareRules.Instance.calculateFare(cboLine.SelectedValue.ToString(), cboStart.SelectedValue.ToString(), cboDestination.SelectedValue?.ToString());
            lblBookingCost.Text = "Cost of Booking: " + tripCost;
        }

        /// <summary>Preview UI design pattern, it all updates on selection changes</summary>
        private void cboDestination_SelectedValueChanged(object sender, EventArgs e)
        {
            tripCost = FareRules.Instance.calculateFare(cboLine.SelectedValue.ToString(), cboStart.SelectedValue.ToString(), cboDestination.SelectedValue?.ToString());
            lblBookingCost.Text = "Cost of Booking: " + tripCost;
        }
    }
}
