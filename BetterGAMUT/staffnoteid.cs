﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterGAMUT
{
    public partial class staffnoteid : Form
    {
        private Form myParent;
        public staffnoteid(Form myParent)
        {
            InitializeComponent();
            this.myParent = myParent; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.myParent.Show();
            this.Close();
        }
    }
}
