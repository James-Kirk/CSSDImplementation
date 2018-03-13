using CSSD_Transport.Journeys;
using CSSD_Transport.Util;

using System.Windows.Forms;

namespace CSSD_Transport.UI.Travel_UI
{
    public partial class frmRailTravelSim : Form
    {
        string currentStation;
        float totalTravelCost = 0;
        public frmRailTravelSim()
        {
            InitializeComponent();
            cboBoxLine.DataSource = RailMap.Instance.getLineNames();
            cboBoxStation.DataSource = RailMap.Instance.getStationNames(cboBoxLine.SelectedValue.ToString());
            currentStation = "Victoria";
            updateCurrentLocation();
            lblCurrentTravelCosts.Text = "Current Cost: 0.00";
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
        }

        private void cboBoxStation_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            lblNewCost.Text = "New Cost: " + (totalTravelCost +
              FareRules.Instance.calculateFare(cboBoxLine.SelectedValue.ToString(), currentStation, cboBoxStation.SelectedValue.ToString())).ToString("F2");
        }
    }
}
