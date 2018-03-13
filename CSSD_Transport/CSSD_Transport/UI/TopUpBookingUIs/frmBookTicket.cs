using CSSD_Transport.Journeys;
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
        float tripCost = 0.0f;

        public frmBookTicket(frmMainMenu prev)
        {
            InitializeComponent();
            cboLine.DataSource = RailMap.Instance.getLineNames();
            lblBookingCost.Text = "Cost of Booking: 0.00";
            this.frmPrevious = prev;
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

        }

        private void cboLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStart.DataSource = RailMap.Instance.getStationNames(cboLine.SelectedValue.ToString());
            cboDestination.DataSource = RailMap.Instance.getStationNames(cboLine.SelectedValue.ToString());
        }
    }
}
