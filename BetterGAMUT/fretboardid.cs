using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Midi;

namespace BetterGAMUT
{
    public partial class fretboardid : Form
    {
        private Form myParent;

        // COPY THE WHOLE BLOCK OF CODE BELOW

        static Dictionary<string, int> noteOffsets =
           new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase) {
            { "C", 0 },   { "C#", 1 }, { "Db", 1 },
            { "D", 2 },   { "D#", 3 }, { "Eb", 3 },
            { "E", 4 },   { "F",  5 }, { "F#", 6 },
            { "Gb", 6 },  { "G",  7 }, { "G#", 8 },
            { "Ab", 8 },  { "A",  9 }, { "A#", 10 },
            { "Bb", 10 }, { "B", 11 },
        };
        public static void PlayNoteName(string noteName = "C#")
        {
            int baseOctave = 4;  // Middle C = C4 = MIDI 60
            int baseNote = 12 * (baseOctave + 1);  // C4 = MIDI 60

            if (!noteOffsets.TryGetValue(noteName, out int offset))
            {
                Console.WriteLine($"Invalid note name: {noteName}");
                return;
            }

            int midiNote = baseNote + offset;  // E.g., Ab4 = 68
            int velocity = 127;
            int durationMs = 1000;

            using (var midiOut = new MidiOut(0))
            {  // 0 = first MIDI device
                midiOut.Send(MidiMessage.StartNote(midiNote, velocity, 1).RawData);
                Thread.Sleep(durationMs);
                midiOut.Send(MidiMessage.StopNote(midiNote, 0, 1).RawData);
            }
        }

        // COPY THE WHOLE BLOCK OF CODE ABOVE

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
            if (String == 1) { Thingy = 7; }
            ;
            if (String == 2) { Thingy = 2; }
            ;
            if (String == 3) { Thingy = 10; }
            ;
            if (String == 4) { Thingy = 5; }
            ;
            if (String == 5) { Thingy = 0; }
            ;
            if (String == 6) { Thingy = 7; }
            ;
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

            if (Total > 0)
            {
                double percentage = (double)Correct / Total * 100;
                label6.Text = $"{percentage:F1}% correct";
            }
            else
            {
                label6.Text = "0.0%";
            }
        }



        public void Abutton_Click(object sender, EventArgs e)
        {
            if (Abutton.Text == label3.Text)
            {
                Abutton.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("A");
            }
            else { Abutton.BackColor = Color.Red; Total += 1; }
        }

        private void ASharp_Click(object sender, EventArgs e)
        {
            if (ASharp.Text == label3.Text)
            {
                ASharp.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("A#");
            }
            else { ASharp.BackColor = Color.Red; Total += 1; }
        }

        private void Bbutton_Click(object sender, EventArgs e)
        {
            if (Bbutton.Text == label3.Text)
            {
                Bbutton.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("B");
            }
            else { Bbutton.BackColor = Color.Red; Total += 1; }
        }

        private void Cbutton_Click(object sender, EventArgs e)
        {
            if (Cbutton.Text == label3.Text)
            {
                Cbutton.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("C");
            }
            else { Cbutton.BackColor = Color.Red; Total += 1; }
        }

        private void CSharp_Click(object sender, EventArgs e)
        {
            if (CSharp.Text == label3.Text)
            {
                CSharp.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("C#");
            }
            else { CSharp.BackColor = Color.Red; Total += 1; }
        }

        private void Dbutton_Click(object sender, EventArgs e)
        {
            if (Dbutton.Text == label3.Text)
            {
                Dbutton.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("D");
            }
            else { Dbutton.BackColor = Color.Red; Total += 1; }
        }

        private void DSharp_Click(object sender, EventArgs e)
        {
            if (DSharp.Text == label3.Text)
            {
                DSharp.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("D#");
            }
            else { DSharp.BackColor = Color.Red; Total += 1; }
        }

        private void Ebutton_Click(object sender, EventArgs e)
        {
            if (Ebutton.Text == label3.Text)
            {
                Ebutton.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("E");
            }
            else { Ebutton.BackColor = Color.Red; Total += 1; }
        }

        private void Gbutton_Click(object sender, EventArgs e)
        {
            if (Gbutton.Text == label3.Text)
            {
                Gbutton.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("G");
            }
            else { Gbutton.BackColor = Color.Red; Total += 1; }
        }

        private void GSharp_Click(object sender, EventArgs e)
        {
            if (GSharp.Text == label3.Text)
            {
                GSharp.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("G#");
            }
            else { GSharp.BackColor = Color.Red; Total += 1; }
        }

        private void Fbutton_Click(object sender, EventArgs e)
        {
            if (Fbutton.Text == label3.Text)
            {
                Fbutton.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("F");
            }
            else { Fbutton.BackColor = Color.Red; Total += 1; }
        }

        private void FSharp_Click(object sender, EventArgs e)
        {
            if (FSharp.Text == label3.Text)
            {
                FSharp.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("F#");
            }
            else { FSharp.BackColor = Color.Red; Total += 1; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayNoteName(label3.Text);
        }
    }
}
