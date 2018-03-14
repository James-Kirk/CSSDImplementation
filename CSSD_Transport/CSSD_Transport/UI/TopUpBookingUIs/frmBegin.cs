using System;
using System.Windows.Forms;

namespace CSSD_Transport.UI
{
    public partial class frmBegin : Form
    {
        public frmBegin()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            frmLogin frmLog = new frmLogin(this);
            frmLog.Show();
            this.Visible = false;
        }
    }
}
