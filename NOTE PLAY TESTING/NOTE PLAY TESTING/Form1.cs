using NAudio.Midi;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            PlayNoteName("Ab");
            PlayNoteName("C#");
        }
    }
}

