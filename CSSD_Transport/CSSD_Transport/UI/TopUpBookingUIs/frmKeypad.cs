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
    public partial class frmKeypad : Form
    {
        public frmKeypad()
        {
            InitializeComponent();
        }

        private void btnKeypad1_Click_1(object sender, EventArgs e)
        {
            txtAmount.Text += 1;
        }

        private void btnKeypad2_Click(object sender, EventArgs e)
        {
            txtAmount.Text += 2;
        }

        private void btnKeypad3_Click(object sender, EventArgs e)
        {

        }

        private void btnKeypad4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
