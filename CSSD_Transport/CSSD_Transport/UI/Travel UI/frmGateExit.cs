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
        public frmGateExit(string line, string currentLocation)
        {
            currentLine = line;
            this.currentLocation = currentLocation;
            InitializeComponent();
        }

        private void btnExitGate_Click(object sender, EventArgs e)
        {
            float currentBalance = 0;
            DigitalReader currentReader = new DigitalReader("Bus", 1, currentLocation);
            try
            {
                currentBalance = currentReader.readTokenAtExit(2, currentLine);// to return float
                if (currentBalance < 0)
                {
                    MessageBox.Show("Insufficient funds");
                }
                else if (currentBalance > 0)
                {
                    MessageBox.Show("Remaining Balance: " + currentBalance);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
