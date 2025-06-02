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

        string Note = "";
        int Total = 0;
        int Correct = 0;

        public void button1_Click(object sender, EventArgs e)
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
            Note = lst[Fret - 1 + Thingy];
            label3.Text = Note;
            button1.Text = "NEXT";
            Abutton.BackColor = Color.Transparent;
            ASharp.BackColor = Color.Transparent;
            Bbutton.BackColor = Color.Transparent;
            Cbutton.BackColor = Color.Transparent;
            CSharp.BackColor = Color.Transparent;
            Dbutton.BackColor = Color.Transparent;
            DSharp.BackColor = Color.Transparent;
            Ebutton.BackColor = Color.Transparent;
            Gbutton.BackColor = Color.Transparent;
            GSharp.BackColor = Color.Transparent;
            Fbutton.BackColor = Color.Transparent;
            FSharp.BackColor = Color.Transparent;
            label4.Text = Correct.ToString() + "/" + Total.ToString();
        }

   

        public void Abutton_Click(object sender, EventArgs e)
        {
            if (Abutton.Text == label3.Text) { Abutton.BackColor = Color.Green; Correct += 1;  Total += 1; }
            else {Abutton.BackColor = Color.Red; Total += 1; }
        }

        private void ASharp_Click(object sender, EventArgs e)
        {
            if (ASharp.Text == label3.Text) { ASharp.BackColor = Color.Green; Correct += 1; Total += 1; }
            else { ASharp.BackColor = Color.Red; Total += 1; }
        }

        private void Bbutton_Click(object sender, EventArgs e)
        {
            if (Bbutton.Text == label3.Text) { Bbutton.BackColor = Color.Green; Correct += 1; Total += 1; }
            else { Bbutton.BackColor = Color.Red; Total += 1; }
        }

        private void Cbutton_Click(object sender, EventArgs e)
        {
            if (Cbutton.Text == label3.Text) { Cbutton.BackColor = Color.Green; Correct += 1; Total += 1; }
            else { Cbutton.BackColor = Color.Red; Total += 1; }
        }

        private void CSharp_Click(object sender, EventArgs e)
        {
            if (CSharp.Text == label3.Text) { CSharp.BackColor = Color.Green; Correct += 1; Total += 1; }
            else { CSharp.BackColor = Color.Red; Total += 1; }
        }

        private void Dbutton_Click(object sender, EventArgs e)
        {
            if (Dbutton.Text == label3.Text) { Dbutton.BackColor = Color.Green; Correct += 1; Total += 1; }
            else { Dbutton.BackColor = Color.Red; Total += 1; }
        }

        private void DSharp_Click(object sender, EventArgs e)
        {
            if (DSharp.Text == label3.Text) { DSharp.BackColor = Color.Green; Correct += 1; Total += 1; }
            else { DSharp.BackColor = Color.Red; Total += 1; }
        }

        private void Ebutton_Click(object sender, EventArgs e)
        {
            if (Ebutton.Text == label3.Text) { Ebutton.BackColor = Color.Green; Correct += 1; Total += 1; }
            else { Ebutton.BackColor = Color.Red; Total += 1; }
        }

        private void Gbutton_Click(object sender, EventArgs e)
        {
            if (Gbutton.Text == label3.Text) { Gbutton.BackColor = Color.Green; Correct += 1; Total += 1; }
            else { Gbutton.BackColor = Color.Red; Total += 1; }
        }

        private void GSharp_Click(object sender, EventArgs e)
        {
            if (GSharp.Text == label3.Text) { GSharp.BackColor = Color.Green; Correct += 1; Total += 1; }
            else { GSharp.BackColor = Color.Red; Total += 1; }
        }

        private void Fbutton_Click(object sender, EventArgs e)
        {
            if (Fbutton.Text == label3.Text) { Fbutton.BackColor = Color.Green; Correct += 1; Total += 1; }
            else { Fbutton.BackColor = Color.Red; Total += 1; }
        }

        private void FSharp_Click(object sender, EventArgs e)
        {
            if (FSharp.Text == label3.Text) { FSharp.BackColor = Color.Green; Correct += 1; Total += 1; }
            else { FSharp.BackColor = Color.Red; Total += 1; }
        }
    }
}
