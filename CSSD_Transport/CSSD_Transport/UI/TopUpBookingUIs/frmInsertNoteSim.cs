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
    public partial class frmInsertNoteSim : Form
    {
        float amountInserted;
        public frmInsertNoteSim()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn5Pounds_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            amountInserted = 5.0f;
        }

        private void btn10Pounds_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            amountInserted = 10.0f;
        }

        private void btn20Pounds_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            amountInserted = 20.0f;
        }

        private void btn50Pounds_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            amountInserted = 50.0f;
        }
    }
}
