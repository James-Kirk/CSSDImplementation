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

using CSSD_Transport.Util;
using CSSD_Transport.Journeys;
using CSSD_Transport.Tokens;

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

            //// USE TO CREATE A STAFF ACCOUNT
            //StaffAccount staffAccount = new StaffAccount("EllieFuller", "password");

            //SetOfAccounts.Instance.addAccount(new NormalAccount("James", "Bob", DateTime.Now));
            //SetOfAccounts.Instance.addAccount(new NormalAccount("Doom", "Guy", DateTime.Now));
            //SetOfAccounts.Instance.addAccount(new NormalAccount("Leroy", "Jenkins", DateTime.Now));
            //// USE TO CREATE A NORMAL ACCOUNT
            //SetOfAccounts.Instance.addAccount(new NormalAccount("ASDFGH", "1234", DateTime.Now));
            //SetOfJourneys.Instance.addJourney(new Journey(SetOfTokens.Instance.findToken(0), "Victoria", "Kings Cross", DateTime.Now, DateTime.Now.AddMinutes(15) , 9.50f));
            //SetOfJourneys.Instance.addJourney(new Journey(SetOfTokens.Instance.findToken(0), "Victoria", "Westminster", DateTime.Now, DateTime.Now.AddMinutes(12), 0.75f));
            //SetOfJourneys.Instance.addJourney(new Journey(SetOfTokens.Instance.findToken(0), "Victoria", "Baker Street", DateTime.Now, DateTime.Now.AddMinutes(37), 8.75f));

            //// USE FOR STAFF LOGIN FUNCTIONALITY
            //StaffAccount x = SetOfStaffAccounts.Instance.FindStaffAccount("EllieFuller", "password");

            //// USE FOR NORMAL PERSON LOGIN FUNCTIONALITY
            //Account y = SetOfAccounts.Instance.findAccount("ASDFGH", "1234");

            //this will need to be called at the very end of program ALWAYS
            //Serialization.saveAll();
            this.Close();
        }
    }
}
