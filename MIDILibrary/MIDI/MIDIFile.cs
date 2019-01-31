using System;
using System.IO;
using System.Text;

namespace MIDI
{
    public class MIDIFile
    {
        #region MIDIHeader
        string format = "4D546864"; // specifies that the file format is MIDI (MThd)
        string headerSize = "00000006"; // specifies the number of bytes of the
                                        // following three parts of the MIDI header (SMF)
        string type = "0001"; // specifies the type of MIDI (0, 1 or 2)
        string tracks = "0001"; // specifies the number of tracks (0 - 65.536)
        string speed = "0080"; // specifies the speed of music
        #endregion
        #region TrackHeader
        string start = "4D54726B"; // specifies the track start (MTrk)
        string noOfBytes = ""; // specifies the number of bytes in the track
        #endregion
        #region Track
        string data = ""; // specifies the musical notes in the track
        string rhythm = "8100"; // specifies the speed of each note
        string volume = "60"; // specifies the volume of each note
        string end = "00FF2F00"; // specifies the track end
        #endregion
        // adds a new note (range from 0 to 127) to the track
        public void addNote(int note)
        {
            if (data.Length == 0) data += "800090"; // the first note needs to send the
                                                    // signal to turn the notes on
            else data += rhythm;
            if (note < 16) data += "0";
            data += note.ToString("X") + volume;
        }
        // sets the volume (range from 0 to 127) of the track
        public void setVolume(int v)
        {
            volume = v.ToString("X");
        }
        // puts all file parts together and writes to .mid file
        public void createMIDIFile(string path)
        {
            data += rhythm + "B07B00"; // the final note just turns off the music
            noOfBytes = ((data.Length + end.Length) / 2).ToString("X"); // previously skipped part of TrackHeader
            while (noOfBytes.Length < 8) noOfBytes = "0" + noOfBytes; // the noOfBytes part needs to have 8 bytes
            string file = format + headerSize + type + tracks + speed +
                          start + noOfBytes + data + end; // putting all parts together
            // writing to .mid file - hexadecimal code is converted to binary and then written to file
            var stream = new FileStream(path + ".mid", FileMode.Create, FileAccess.ReadWrite);
            var twoCharacters = new StringBuilder(); // two bytes are used for every conversion (16 bits - two hex numbers)
            var singleByte = new byte[1]; // two binary bytes to which the hex numbers will be converted
            foreach (var character in file)
            {
                twoCharacters.Append(character); // adding one hex character to the 16-bit variable
                if (twoCharacters.Length == 2) // added two characters - reached 16 bits
                {
                    singleByte[0] = (byte)Convert.ToByte(twoCharacters.ToString(), 16); // conversion from hex to bin
                    stream.Write(singleByte, 0, 1); // writing bin to file
                    twoCharacters.Clear(); // starting over again with new characters
                }
            }
            stream.Close();
        }
    }
}
