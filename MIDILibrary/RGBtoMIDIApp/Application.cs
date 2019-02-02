using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            textBox2.Text = imagePath;
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
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            backgroundWorker1.RunWorkerAsync();
        }
        private void axWindowsMediaPlayerPlay_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayerPlay.URL = musicFilePath;
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Choose File";

            if(fileDialog.ShowDialog() == DialogResult.OK) {
                musicFilePath = fileDialog.FileName;
                textBox1.Text = musicFilePath;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxLoadImage.Image = null;
            textBox1.Text = "";
            textBox2.Text = "";
            imagePath = "";
            musicFilePath = "";
            progressBar1.Value = 0;
            axWindowsMediaPlayerPlay.URL = "";
        }
        //turn hue to sound
        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            MIDIFile m = new MIDIFile();
            int[,] note = toNormalizedHue(imagePath);
            m.setVolume(127);
            int noOfSteps = note.GetLength(0) * note.GetLength(1);
            int reportProgressStep = noOfSteps / 100 + 1;
            int step = 0;
            for (int i = 0; i < note.GetLength(0); i++)
            {
                for (int j = 0; j < note.GetLength(1); j++)
                {
                    m.addNote(note[i, j]); //create MIDI file of notes acquired from the hue channel of the image
                    step++;
                    if (step % reportProgressStep == 0) backgroundWorker.ReportProgress(step / reportProgressStep);
                }
            }
            m.createMIDIFile("test"); //create MIDI file
            backgroundWorker.ReportProgress(100);
            musicFilePath = Directory.GetCurrentDirectory() + "\\test.mid";
        }

        private void backgroundWorker1_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBox1.Text = musicFilePath;
            string x = textBox1.Text;
        }
    }
}
