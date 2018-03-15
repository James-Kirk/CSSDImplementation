using CSSD_Transport.Journeys;
using CSSD_Transport.Util;
using System;
using System.Windows.Forms;

namespace CSSD_Transport.UI.Travel_UI
{
    public partial class frmRailTravelSim : Form
    {
        string currentStation;
        float totalTravelCost = 0;
        int tokenId;
        GoogleMap googleMap;

        public frmRailTravelSim(string station, int tokenId)
        {
            InitializeComponent();
            this.tokenId = tokenId;
            cboBoxLine.DataSource = RailMap.Instance.getLineNames();
            cboBoxStation.DataSource = RailMap.Instance.getStationNames(cboBoxLine.SelectedValue.ToString());
            this.currentStation = station;
            updateCurrentLocation();
            googleMap = new GoogleMap(currentStation, this);
            lblCurrentTravelCosts.Text = "Current Cost: 0.00";
            lblNewCost.Text = "New Cost: 0.00";
        }

        private void cboBoxLine_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            cboBoxStation.DataSource = RailMap.Instance.getStationNames(cboBoxLine.SelectedValue.ToString());
            lblNewCost.Text = "New Cost: "+ (totalTravelCost + 
                FareRules.Instance.calculateFare(cboBoxLine.SelectedValue.ToString(), currentStation, cboBoxStation.SelectedValue.ToString())).ToString("F2");
        }

        private void btnTravel_Click(object sender, System.EventArgs e)
        {
            totalTravelCost += FareRules.Instance.calculateFare(cboBoxLine.SelectedValue.ToString(), currentStation,cboBoxStation.SelectedValue.ToString());
            currentStation = cboBoxStation.SelectedValue.ToString();
            updateCurrentLocation();
        }

        private void updateCurrentLocation()
        {
            lblCurrentStation.Text = "Current Station: " + currentStation;
            lblCurrentTravelCosts.Text = "Current Cost: " + totalTravelCost.ToString("F2");
            if (googleMap != null) { googleMap.updateLocation(currentStation); }
        }

        private void cboBoxStation_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            lblNewCost.Text = "New Cost: " + (totalTravelCost +
              FareRules.Instance.calculateFare(cboBoxLine.SelectedValue.ToString(), currentStation, cboBoxStation.SelectedValue.ToString())).ToString("F2");
            if (googleMap != null) { googleMap.updateDestination(cboBoxStation.SelectedValue.ToString()); }
        }

        private void btnExitStation_Click(object sender, System.EventArgs e)
        {
            this.Close();
            new frmGateExit(cboBoxLine.SelectedValue.ToString(), currentStation, tokenId).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRailTravelSim_Load(object sender, EventArgs e)
        {

        }
    }
}
