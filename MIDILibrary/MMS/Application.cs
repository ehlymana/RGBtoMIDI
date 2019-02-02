using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIDI;
using WMPLib;

namespace MMS
{
    public partial class Application : Form
    {
        Image imageToConvert;
        String imagePath = "";
        String musicFilePath = "";
        public Application()
        {
            InitializeComponent();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Choose image";
            
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                imageToConvert = Image.FromFile(fileDialog.FileName);
                imagePath = fileDialog.FileName;
                pictureBoxLoadImage.Image = imageToConvert;            
                pictureBoxLoadImage.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        //helper function to turn image to normalized hue
        static int[,] toNormalizedHue(string path) //path to image
        {
            Bitmap bitmap = new Bitmap(path); //load image

            int width = bitmap.Width;
            int height = bitmap.Height;

            int[,] note = new int[height, width]; //all of the values [0,128) will  be stored here

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    Color pixel = bitmap.GetPixel(j, i);

                    float hue = pixel.GetHue(); //get Hue of pixel
                    hue = hue * 127F / 360F; //normalise to [0,128)
                    note[i, j] = (int)(Math.Floor(hue)); //round to int

                }
            }

            //since large images will produce longer audio files, the factor variable is introduced
            //similar to DCT, we will use blocks of the image to shorten the audio file
            //bigger images will have a bigger factor

            List<List<int>> notes = new List<List<int>>();
            int factor = 8;

            if (width > 2500 || height > 2500)
            {
                factor = 64;
            }
            else if (width > 1500 || height > 1500)
            {
                factor = 32;
            }
            else if (width > 1000 || height > 1000)
            {
                factor = 16;
            }

            //calculating average normalized hue value for blocks size (factor x factor)
            for (int i = 0; i < height; i += factor)
            {
                List<int> temp = new List<int>();
                for (int j = 0; j < width; j += factor)
                {
                    double sum = 0;
                    //total is kept track of since it is possible that a whole block would not fit in (instead of padding the image)
                    int total = 0;

                    for (int k = i; k < i + factor && k < height; k++)
                    {
                        for (int l = j; l < j + factor && l < width; l++)
                        {
                            sum += note[k, l];
                            total++;
                        }
                    }
                    temp.Add((int)(Math.Floor(sum / total)) + 1);
                    sum = 0;
                    total = 0;

                }
                notes.Add(temp);
            }

            //copying to the needed return type
            int[,] returnNote = new int[notes.Count, notes[0].Count];

            for (int i = 0; i < returnNote.GetLength(0); i++)
            {
                for (int j = 0; j < returnNote.GetLength(1); j++)
                {
                    returnNote[i, j] = notes[i][j];
                }
            }

            return returnNote;

        }

        //turn hue to sound
        static void imageToSound(string path) //path to image
        {
            MIDIFile m = new MIDIFile();


            int[,] note = toNormalizedHue(path);

            m.setVolume(127);
            for (int i = 0; i < note.GetLength(0); i++)
            {
                for (int j = 0; j < note.GetLength(1); j++)
                {
                    m.addNote(note[i, j]); //create MIDI file of notes acquired from the hue channel of the image
                }
            }
            m.createMIDIFile("test"); //create MIDI file
            //MessageBox.Show("Notification", "Success", MessageBoxButtons.OK);

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            imageToSound(imagePath);
        }

        private void axWindowsMediaPlayerPlay_Enter(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = musicFilePath;
            wplayer.controls.play();
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Choose File";

            if(fileDialog.ShowDialog() == DialogResult.OK)            {
                musicFilePath = fileDialog.FileName;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxLoadImage.Image = null;
        }
    }
}
