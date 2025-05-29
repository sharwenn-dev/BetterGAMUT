using System;
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
    public partial class Exercises : Form
    {
        private Form myParent;
        public Exercises(Form myParent)
        {
            InitializeComponent();
            this.myParent = myParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.myParent.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            staffnoteid frm = new staffnoteid(this);
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fretboardid frm = new fretboardid(this);
            frm.Show();
            this.Hide();
        }
    }
}
