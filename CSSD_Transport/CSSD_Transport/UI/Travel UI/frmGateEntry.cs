using CSSD_Transport.Equipment;
using CSSD_Transport.Journeys;
using CSSD_Transport.Tokens;
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

namespace CSSD_Transport.UI.Travel_UI
{
    public partial class frmGateEntry : Form
    {
        int tokenId = 2;
        String start;
        frmBegin prev;
        public frmGateEntry(frmBegin prev, String start)
        {
            InitializeComponent();
            this.start = start;
            this.prev = prev;
            cbxTokens.DataSource = SetOfTokens.Instance.getTokens();
        }

        private void btnEnterGate_Click(object sender, EventArgs e)
        {
            DigitalReader currentReader = new DigitalReader("Bus", 1 , this.start);
            tokenId = (int)cbxTokens.SelectedValue;
            if(currentReader.readTokenAtEntry(tokenId))
            {
                MessageBox.Show("Gate Open");
                new frmRailTravelSim(start, tokenId).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Entry Token/Insufficient Funds");
            }
        }
    }
}
