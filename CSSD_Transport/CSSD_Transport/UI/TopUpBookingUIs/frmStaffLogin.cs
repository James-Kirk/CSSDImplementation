using CSSD_Transport.UI.TopUpBookingUIs;
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
    public partial class frmStaffLogin : Form
    {
        public frmStaffLogin()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            new frmCreateStaffAccount().ShowDialog();
        }
    }
}
