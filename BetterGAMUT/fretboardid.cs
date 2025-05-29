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

        public string Note { get; private set; }

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
            var lst = new List<string> {
                "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#",
                "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#",
                "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"
            };
            int Thingy = 0;
            if (String == 1) {Thingy = 7;};
            if (String == 2) {Thingy = 0;};
            if (String == 3) {Thingy = 5;};
            if (String == 4) {Thingy = 10;};
            if (String == 5) {Thingy = 2;};
            if (String == 6) {Thingy = 7;};
            string Note = lst[Fret - 1 + Thingy];
            label3.Text = Note;
        }

        private void Abutton_Click(object sender, EventArgs e)
        {
            if (Note = Abutton.Text) { Thingy = 7; };
        }

        private void ASharp_Click(object sender, EventArgs e)
        {

        }

        private void Bbutton_Click(object sender, EventArgs e)
        {

        }

        private void Cbutton_Click(object sender, EventArgs e)
        {

        }

        private void CSharp_Click(object sender, EventArgs e)
        {

        }

        private void Dbutton_Click(object sender, EventArgs e)
        {

        }

        private void DSharp_Click(object sender, EventArgs e)
        {

        }

        private void Ebutton_Click(object sender, EventArgs e)
        {

        }

        private void Gbutton_Click(object sender, EventArgs e)
        {

        }

        private void GSharp_Click(object sender, EventArgs e)
        {

        }

    }
}
