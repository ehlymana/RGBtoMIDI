using MIDI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDITest
{
    class Program
    {
        static void Main(string[] args)
        {
            MIDIFile m = new MIDIFile();
            m.setVolume(127);
            for (int i = 0; i < 128; i++) m.addNote(i);
            m.createMIDIFile("test");
        }
    }
}
