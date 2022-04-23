using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC132_FinalProject
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }
        //public frmPhone()
        //{
        //InitializeComponent();
        //}

        //private Form1 mainForm = null;
        private HomePage firstForm = null;
        public Preferences(Form callingForm)
        {
        InitializeComponent();
        firstForm = callingForm as HomePage;
        }
       
        
        private void Preferences_Load(object sender, EventArgs e)
        {

        }

        private void btnPreferencesHelp_Click(object sender, EventArgs e)
        {
            Details info = new Details();
            info.Show();
        }

        private void btnPreferncesBack_Click(object sender, EventArgs e)
        {
            HomePage backtohomepage = new HomePage();
            backtohomepage.Show();
        }

        private void btnPreferencesNext_Click(object sender, EventArgs e)
        {
            Output gotoOutput = new Output();
            gotoOutput.Show();
        }

        private void btnAddCredits_Click(object sender, EventArgs e)
        {
            firstForm.Number_of_credits = 0;
            

        }

        private void btnAddJTerm_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnPreferencesExit_Click(object sender, EventArgs e)
        {

        }
    }
}
