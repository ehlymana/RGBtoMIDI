using MIDI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //imageToSound("");

        }

        //helper function to turn image to normalized hue
        static int[,] toNormalizedHue(string path) //path to image
        {
            Bitmap bitmap = new Bitmap(path); //load image

            int width = bitmap.Width;
            int height = bitmap.Height;

            int[,] note = new int[height, width]; //all of the values [0,128) will  be stored here

            for (int i=0; i<height; i++)
            {
                for (int j=0; j<width; j++)
                {

                    Color pixel = bitmap.GetPixel(j, i);

                    float hue = pixel.GetHue(); //get Hue of pixel
                    hue = hue * 127F / 360F; //normalise to [0,128)
                    note[i,j] = (int)(Math.Floor(hue)); //round to int

                }
            }

            return note;

        }

        //turn hue to sound
        static void imageToSound(string path) //path to image
        {
            MIDIFile m = new MIDIFile();


            int[,] note = toNormalizedHue(path); 

            m.setVolume(127);
            for(int i=0; i<note.GetLength(0); i++)
            {
                for (int j=0; j< note.GetLength(1); j++)
                {
                    m.addNote(note[i, j]); //create MIDI file of notes acquired from the hue channel of the image
                }
            }
            m.createMIDIFile("test"); //create MIDI file

        }


    }


}
