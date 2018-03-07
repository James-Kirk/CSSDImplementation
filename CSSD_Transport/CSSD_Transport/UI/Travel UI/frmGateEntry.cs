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
    public partial class frmGateEntry : Form
    {
        public frmGateEntry()
        {
            InitializeComponent();
        }

        private void btnEnterGate_Click(object sender, EventArgs e)
        {
            DigitalReader currentReader = new DigitalReader();
            if(currentReader.readTokenAtEntry(1))
            {
                MessageBox.Show("Gate Open");
            }
            else
            {
                MessageBox.Show("Insufficent Funds");
            }
        }
    }
}
