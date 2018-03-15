using CSSD_Transport.UI.Travel_UI;
using CSSD_Transport.Util;
using System;
using System.Windows.Forms;

namespace CSSD_Transport.UI
{
    public partial class frmBegin : Form
    {
        public frmBegin()
        {
            InitializeComponent();
            cbxBeginLine.DataSource = RailMap.Instance.getLineNames();
            cbxStart.DataSource = RailMap.Instance.getStationNames(cbxBeginLine.SelectedValue.ToString());
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            frmLogin frmLog = new frmLogin(this);
            frmLog.Show();
            this.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            frmGateEntry frmEntry = new frmGateEntry(this, cbxStart.SelectedValue.ToString());
            frmEntry.Show();
            this.Visible = false;
        }

        private void btnStaffLogin_Click(object sender, EventArgs e)
        {
            frmStaffLogin frmStaff = new frmStaffLogin(this);
            frmStaff.Show();
            this.Visible = false;
        }

        private void cbxBeginLine_SelectedValueChanged(object sender, EventArgs e)
        {
            cbxStart.DataSource = RailMap.Instance.getStationNames(cbxBeginLine.SelectedValue.ToString());
        }
    }
}
