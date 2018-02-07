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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnMyTrips_Click(object sender, EventArgs e)
        {
            frmTrips trips = new frmTrips();
            this.Visible = false;
            trips.Show();
        }
    }
}
