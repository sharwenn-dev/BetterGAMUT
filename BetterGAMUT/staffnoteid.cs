using NAudio.Midi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterGAMUT
{
    public partial class staffnoteid : Form
    {

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

        string Note = "";
        int Total = 0;
        int Correct = 0;

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

            // clear ledger lines
            foreach (Control ctrl in this.Controls.OfType<Panel>().Where(p => (string)p.Tag == "Ledger").ToList())
            {
                this.Controls.Remove(ctrl);
                ctrl.Dispose();
            }

            Random rnd = new Random();
            var naturalNotes = new List<string>
            {
                "A3", "B3",
                "C4", "D4", "E4", "F4", "G4",
                "A4", "B4",
                "C5", "D5", "E5", "F5", "G5",
                "A5", "B5",
                "C6"
            };
            Note = naturalNotes[rnd.Next(naturalNotes.Count)];

            Dictionary<string, int> noteY = new Dictionary<string, int>
            {
                { "C6", 77 },
                { "B5", 87 },
                { "A5", 95 },
                { "G5", 104 },
                { "F5", 113 },
                { "E5", 121 },
                { "D5", 130 },
                { "C5", 139 },
                { "B4", 148 },
                { "A4", 156 },
                { "G4", 164 },
                { "F4", 173 },
                { "E4", 181 },
                { "D4", 191 },
                { "C4", 200 },
                { "B3", 209 },
                { "A3", 218 }
            };

            int x = 250;
            int y = noteY[Note];
            pictureBox1.Location = new Point(x, y);

            int lineLength = 30;
            void AddLedgerLineAt(int ledgerY)
            {
                Panel ledger = new Panel();
                ledger.BackColor = Color.Black;
                ledger.Size = new Size(lineLength, 2);
                ledger.Location = new Point(x - 8, ledgerY);
                ledger.Tag = "Ledger";
                this.Controls.Add(ledger);
                ledger.BringToFront();
            }

            // adds needed ledger lines (could be done better)
            switch (Note)
            {
                case "C6": 
                    AddLedgerLineAt(noteY["A5"] + 7); 
                    AddLedgerLineAt(noteY["C6"] + 7); 
                    break;
                case "B5":
                    AddLedgerLineAt(noteY["A5"] + 7);
                    break;
                case "A5":
                    AddLedgerLineAt(noteY["A5"] + 7);
                    break;
                case "C4": 
                    AddLedgerLineAt(noteY["C4"] + 8);
                    break;
                case "B3": 
                    AddLedgerLineAt(noteY["C4"] + 8);
                    break;
                case "A3": 
                    AddLedgerLineAt(noteY["C4"] + 8);
                    AddLedgerLineAt(noteY["A3"] + 8);
                    break;
            }

            label3.Text = Note.Substring(0, Note.Length - 1);
            button1.Text = "NEXT";

            Abutton.BackColor = Color.Transparent;
            Bbutton.BackColor = Color.Transparent;
            Cbutton.BackColor = Color.Transparent;
            Dbutton.BackColor = Color.Transparent;
            Ebutton.BackColor = Color.Transparent;
            Fbutton.BackColor = Color.Transparent;
            Gbutton.BackColor = Color.Transparent;
            label4.Text = Correct.ToString() + "/" + Total.ToString();

            if (Total > 0)
            {
                double percentage = (double)Correct / Total * 100;
                label1.Text = $"{percentage:F1}% correct";
            }
            else
            {
                label1.Text = "0.0%";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayNoteName(label3.Text);
        }

        private void Abutton_Click(object sender, EventArgs e)
        {
            if (Abutton.Text == label3.Text)
            {
                Abutton.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("A");
            }
            else { Abutton.BackColor = Color.Red; Total += 1; }
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

        private void Dbutton_Click(object sender, EventArgs e)
        {
            if (Dbutton.Text == label3.Text)
            {
                Dbutton.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("D");
            }
            else { Dbutton.BackColor = Color.Red; Total += 1; }
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

        private void Fbutton_Click(object sender, EventArgs e)
        {
            if (Fbutton.Text == label3.Text)
            {
                Fbutton.BackColor = Color.Green; Correct += 1; Total += 1;
                PlayNoteName("F");
            }
            else { Fbutton.BackColor = Color.Red; Total += 1; }
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
    }
}
