using CSSD_Transport.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSD_Transport.UI.TopUpBookingUIs
{
    public partial class frmCreateStaffAccount : Form
    {
        public frmCreateStaffAccount()
        {
            InitializeComponent();
        }

        private int checkPasswordStrength()
        {
            int passwordStrength = 0;
            if (txtPass.TextLength < 7)
                return -1;
            if (txtPass.TextLength > 14)
                passwordStrength++;
            if (txtPass.Text.Any(char.IsLower))
                passwordStrength++;
            if (txtPass.Text.Any(char.IsUpper))
                passwordStrength++;
            if (txtPass.Text.Any(char.IsNumber))
                passwordStrength++;
            if (txtPass.Text.Contains("123"))
                passwordStrength--;
            if (txtPass.Text.Any(char.IsSymbol))
                passwordStrength++;
            return passwordStrength;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            int passStrength = checkPasswordStrength();
            if (txtPass.TextLength == 0)
            {
                lblPassStrengthVal.Text = "";
            }
            else
            {
                switch (passStrength)
                {
                    case -1:
                        lblPassStrengthVal.ForeColor = Color.Black;
                        lblPassStrengthVal.Text = "Password Too Short";
                        break;
                    case 0:
                        lblPassStrengthVal.ForeColor = Color.Red;
                        lblPassStrengthVal.Text = "Very Weak";
                        break;
                    case 1:
                        lblPassStrengthVal.ForeColor = Color.Red;
                        lblPassStrengthVal.Text = "Very Weak";
                        break;
                    case 2:
                        lblPassStrengthVal.ForeColor = Color.OrangeRed;
                        lblPassStrengthVal.Text = "Weak";
                        break;
                    case 3:
                        lblPassStrengthVal.ForeColor = Color.Orange;
                        lblPassStrengthVal.Text = "Fair";
                        break;
                    case 4:
                        lblPassStrengthVal.ForeColor = Color.PaleGreen;
                        lblPassStrengthVal.Text = "Good";
                        break;
                    case 5:
                        lblPassStrengthVal.ForeColor = Color.Green;
                        lblPassStrengthVal.Text = "Strong";
                        break;
                }
            }
            
            
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text.Equals(txtPass.Text))
            {
                lblPassMatchVal.Text = "✓";
                lblPassMatchVal.ForeColor = Color.Green;
            }
            else
            {
                lblPassMatchVal.Text = "X";
                lblPassMatchVal.ForeColor = Color.Red;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateStaffAccount_Click(object sender, EventArgs e)
        {
            //if (SetOfStaffAccounts)
            //{

           // }
        }
    }
}
