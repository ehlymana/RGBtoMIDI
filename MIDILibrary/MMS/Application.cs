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

            return note;

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
