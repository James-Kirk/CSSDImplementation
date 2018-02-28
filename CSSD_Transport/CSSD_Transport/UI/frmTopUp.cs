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
    public partial class frmTopUp : Form
    {
        frmMainMenu frmPrevious;
        public frmTopUp(frmMainMenu prev)
        {
            this.frmPrevious = prev;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmPrevious.Visible = true;
            this.Close();
        }

        private void btnInsertNote_Click(object sender, EventArgs e)
        {
            ShowDialog(new frmInsertNoteSim());
        }

        private void btnEnterTopUpAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
