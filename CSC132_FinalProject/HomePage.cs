﻿using System;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void cSCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences gottopreferences = new Preferences();
            gottopreferences.Show();
        }
    }
}
