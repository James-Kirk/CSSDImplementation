using CSSD_Transport.Equipment;
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
    public partial class frmGateExit : Form
    {
        string currentLine, currentLocation;
        int tokenId;
        public frmGateExit(string line, string currentLocation, int tokenId)
        {
            currentLine = line;
            this.currentLocation = currentLocation;
            this.tokenId = tokenId;
            InitializeComponent();
        }

        private void btnExitGate_Click(object sender, EventArgs e)
        {
            float currentBalance = 0;
            DigitalReader currentReader = new DigitalReader("Bus", currentLocation);
            try
            {
                currentBalance = currentReader.readTokenAtExit(tokenId, currentLine);// to return float
                if (currentBalance < 0)
                {
                    MessageBox.Show("Invalid Token/Insufficient funds");
                }
                else if (currentBalance >= 0)
                {
                    MessageBox.Show("Remaining Balance: " + currentBalance);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
