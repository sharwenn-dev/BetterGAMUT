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
    public partial class fretboardid : Form
    {
        private Form myParent;
        public fretboardid(Form myParent)
        {
            InitializeComponent();
            this.myParent = myParent;
        }

        private void home_3_Click(object sender, EventArgs e)
        {
            this.myParent.Show();
            this.Close();
        }

        private void button97_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            int x = 4; int y = 48;
            Random rnd = new Random();
            int String = rnd.Next(1, 7);
            int Fret = rnd.Next(1, 17);
            y += String * 22;
            x += (Fret - 1) * 27;
            pictureBox1.Location = new Point(x, y);
            label1.Text = String.ToString();
            label2.Text = Fret.ToString();
            var lst = new List<string> {"A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
            for (int i = 0; i < Fret; i++) ;



        }
}
}
