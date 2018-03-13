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
            txtCurrentBalance.Text = prev.currentAccount.getBalance().ToString("N2");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmPrevious.Visible = true;
            this.Close();
        }

        private void btnInsertNote_Click(object sender, EventArgs e)
        {
            frmInsertNoteSim insertNote = new frmInsertNoteSim();
             insertNote.ShowDialog();
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(frmPrevious.currentAccount.processTopUp(Convert.ToSingle(txtTopUpAmount.Text), ""))
            {
                paymentComplete();
            }
        }

        private void paymentComplete()
        {
            txtCurrentBalance.Text = frmPrevious.currentAccount.getBalance().ToString("N2");
            lblTopUpAmount.Visible = false;
            btnPayAgain.Visible = true;
            txtTopUpAmount.Visible = false;
        }

        private void btnPayAgain_Click(object sender, EventArgs e)
        {

        }
    }
}
