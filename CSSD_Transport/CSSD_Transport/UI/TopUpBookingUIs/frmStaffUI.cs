using CSSD_Transport.Journeys;
using CSSD_Transport.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSD_Transport.UI
{
    public partial class frmStaffUI : Form
    {
        frmStaffLogin prevForm;
        public frmStaffUI(frmStaffLogin prev)
        {
            InitializeComponent();
            this.lsbJourneys.DataSource = formatData(SetOfJourneys.Instance.getAllJourneys());
            this.cboLineFilter.DataSource = RailMap.Instance.getLineNames();
            this.lblPassengers.Text += this.lsbJourneys.Items.Count;
            this.prevForm = prev;
        }

        private List<string> formatData(List<Journey> journeys)
        {
            var data = new List<string>();
            foreach (var js in journeys)
            {
                data.Add(js.getStartLocation()+" To " + js.getEndLocation() + " On " + js.getStartDate().ToShortDateString() +" At "+ js.getStartDate().ToShortTimeString() + " Total Travel Time: "+ (js.getEndDate().Subtract(js.getStartDate()).TotalMinutes.ToString("N0")) + " Minutes");
            }
            return data;
        }

        private void cboLineFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStationFilter.DataSource = RailMap.Instance.getStationNames(cboLineFilter.SelectedValue.ToString());
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (ckbDateFilter.Checked)
            {
                if (ckbStationFilter.Checked)
                {
                    this.lsbJourneys.DataSource = formatData(SetOfJourneys.Instance.getJourneysByDate(dtpDateFilter.Value, SetOfJourneys.Instance.getJourneysByStations(cboStationFilter.SelectedValue.ToString())));
                    this.lblPassengers.Text = "Total Travelers on " + dtpDateFilter.Value.ToShortDateString() + " Via " + cboStationFilter.SelectedValue.ToString() + ": " + this.lsbJourneys.Items.Count;
                }
                else
                {
                    this.lsbJourneys.DataSource = formatData(SetOfJourneys.Instance.getJourneysByDate(dtpDateFilter.Value, SetOfJourneys.Instance.getAllJourneys()));
                    this.lblPassengers.Text = "Total Travelers on " + dtpDateFilter.Value.ToShortDateString() +  ": " + this.lsbJourneys.Items.Count;
                }
            }
            else if (ckbStationFilter.Checked)
            {
                this.lsbJourneys.DataSource = formatData(SetOfJourneys.Instance.getJourneysByStations(cboStationFilter.SelectedValue.ToString()));
                this.lblPassengers.Text = "Total Travelers Via " + cboStationFilter.SelectedValue.ToString() + ": " + this.lsbJourneys.Items.Count;
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            this.lsbJourneys.DataSource = formatData(SetOfJourneys.Instance.getAllJourneys());
            this.lblPassengers.Text = "Total Number Of Travelers: " + this.lsbJourneys.Items.Count;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm.Show();
        }


    }
}
