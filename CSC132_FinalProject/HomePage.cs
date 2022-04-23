using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSC132_FinalProject;
namespace CSC132_FinalProject
{
    public partial class HomePage : Form
    {
        public static HomePage This;
        public HomePage()
        {
            InitializeComponent();
            This = this;
        }

        public void cSCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Computer_science ob = new Computer_science("Description", 120, 0);
            Preferences gottopreferences = new Preferences(this);
            gottopreferences.Show();
            
            Preferences newForm = new Preferences(this);
        }

        private void bUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accounting obj = new Accounting("Description", 130, 0);
            Preferences gottopreferences = new Preferences();
            gottopreferences.Show();
        }

        private void cISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercise_Science obje = new Exercise_Science("Description", 120, 0);
            Preferences gottopreferences = new Preferences();
            gottopreferences.Show();
        }

        private void fINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finance objec = new Finance("Description", 120, 0);
            Preferences gottopreferences = new Preferences();
            gottopreferences.Show();
        }

        private void eCOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Engineering objet = new Engineering("Description", 150, 0);
            Preferences gottopreferences = new Preferences();
            gottopreferences.Show();
        }
    }
}
