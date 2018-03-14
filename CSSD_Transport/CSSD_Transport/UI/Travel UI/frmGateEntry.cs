using CSSD_Transport.Equipment;
using CSSD_Transport.Journeys;
using CSSD_Transport.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSD_Transport.UI.Travel_UI
{
    public partial class frmGateEntry : Form
    {
        int tokenId = 2;
        public frmGateEntry()
        {
            InitializeComponent();
        }

        private void btnEnterGate_Click(object sender, EventArgs e)
        {
            DigitalReader currentReader = new DigitalReader("Bus", 1 , "Victoria");
            if(currentReader.readTokenAtEntry(tokenId))
            {
                MessageBox.Show("Gate Open");
                new frmRailTravelSim().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Insufficent Funds");
            }
        }
    }
}
