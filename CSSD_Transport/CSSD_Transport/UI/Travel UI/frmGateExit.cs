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
        public frmGateExit()
        {
            InitializeComponent();
        }

        private void btnExitGate_Click(object sender, EventArgs e)
        {
            float currentBalance = 0;
            DigitalReader currentReader = new DigitalReader("Bus", 1);
            try
            {
                currentReader.readTokenAtExit(1);// to return float
                if (currentBalance < 0)
                {
                    MessageBox.Show("Insufficient funds");
                }
                else if (currentBalance > 0)
                {
                    MessageBox.Show("Remaining Balance: " + currentBalance);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Smart card unregistered, please visit imformation helpdesk");
            }
           
        }
    }
}
