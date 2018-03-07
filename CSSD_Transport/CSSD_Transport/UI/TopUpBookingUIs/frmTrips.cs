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
    public partial class frmTrips : Form
    {
        frmMainMenu frmPrevious;
        public frmTrips(frmMainMenu prev)
        {
            frmPrevious = prev;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmPrevious.Visible = true;
            this.Close();
        }
    }
}
