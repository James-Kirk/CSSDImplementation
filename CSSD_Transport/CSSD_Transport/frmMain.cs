using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSSD_Transport.Accounts;

namespace CSSD_Transport
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

        private void frmMain_Load(object sender, EventArgs e)
        {
            //this will need to be called at the very beginning of program ALWAYS
            Serialization.loadAll();

            // USE TO CREATE A STAFF ACCOUNT
            // StaffAccount staffAccount = new StaffAccount("EllieFuller", "password");

            // USE TO CREATE A NORMAL ACCOUNT
            // SetOfAccounts.Instance.addAccount(new NormalAccount("smelon", "password", DateTime.Now));

            // USE FOR STAFF LOGIN FUNCTIONALITY
            // StaffAccount x = SetOfStaffAccounts.Instance.FindStaffAccount("EllieFuller", "password");

            // USE FOR NORMAL PERSON LOGIN FUNCTIONALITY
            Account account = SetOfAccounts.Instance.findAccount("smelon", "password");

            //CHECK CURRENT BALANCE FUNCTIONALITY
            account.getBalance();

            // TOP UP FUNCTIONALITY
            // It seems stupid passing in the same amount in twice. not good programming - you could mistype and the amount is different.
            // This is why i originally called processTopUp in the backend so it's less error prone - EF
            float topUpAmount = 5.5f;
            if (account.processTopUp(topUpAmount, "NoIdeaWotThisStringIsForFML")) { account.updateBalance(topUpAmount); }

            AnonymousAccount anon = new AnonymousAccount();
            anon.getBalance();
            if (anon.processTopUp(100.39f, "")) { anon.updateBalance(100.39f); }

            //this will need to be called at the very end of program ALWAYS
            Serialization.saveAll();
        }
    }
}
