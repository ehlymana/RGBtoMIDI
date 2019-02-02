namespace MMS
{
    partial class Application
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.pictureBoxLoadImage = new System.Windows.Forms.PictureBox();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.groupBoxLoadImage = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxConversion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayerPlay = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadImage)).BeginInit();
            this.groupBoxLoadImage.SuspendLayout();
            this.groupBoxConversion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLoadImage
            // 
            this.pictureBoxLoadImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxLoadImage.Location = new System.Drawing.Point(53, 34);
            this.pictureBoxLoadImage.Name = "pictureBoxLoadImage";
            this.pictureBoxLoadImage.Size = new System.Drawing.Size(261, 191);
            this.pictureBoxLoadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoadImage.TabIndex = 0;
            this.pictureBoxLoadImage.TabStop = false;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(91, 294);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(187, 29);
            this.buttonLoadImage.TabIndex = 1;
            this.buttonLoadImage.Text = "Load Image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // groupBoxLoadImage
            // 
            this.groupBoxLoadImage.Controls.Add(this.textBox2);
            this.groupBoxLoadImage.Controls.Add(this.label4);
            this.groupBoxLoadImage.Controls.Add(this.pictureBoxLoadImage);
            this.groupBoxLoadImage.Controls.Add(this.buttonLoadImage);
            this.groupBoxLoadImage.Location = new System.Drawing.Point(33, 28);
            this.groupBoxLoadImage.Name = "groupBoxLoadImage";
            this.groupBoxLoadImage.Size = new System.Drawing.Size(374, 351);
            this.groupBoxLoadImage.TabIndex = 3;
            this.groupBoxLoadImage.TabStop = false;
            this.groupBoxLoadImage.Text = "Load Image";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current path:";
            // 
            // groupBoxConversion
            // 
            this.groupBoxConversion.Controls.Add(this.label3);
            this.groupBoxConversion.Controls.Add(this.textBox1);
            this.groupBoxConversion.Controls.Add(this.label2);
            this.groupBoxConversion.Controls.Add(this.label1);
            this.groupBoxConversion.Controls.Add(this.progressBar1);
            this.groupBoxConversion.Controls.Add(this.buttonLoadFile);
            this.groupBoxConversion.Controls.Add(this.axWindowsMediaPlayerPlay);
            this.groupBoxConversion.Controls.Add(this.buttonConvert);
            this.groupBoxConversion.Location = new System.Drawing.Point(434, 28);
            this.groupBoxConversion.Name = "groupBoxConversion";
            this.groupBoxConversion.Size = new System.Drawing.Size(426, 351);
            this.groupBoxConversion.TabIndex = 4;
            this.groupBoxConversion.TabStop = false;
            this.groupBoxConversion.Text = "Conversion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Play the converted sound:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Conversion progress:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(169, 104);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(214, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(114, 196);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(187, 29);
            this.buttonLoadFile.TabIndex = 4;
            this.buttonLoadFile.Text = "Load File";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // axWindowsMediaPlayerPlay
            // 
            this.axWindowsMediaPlayerPlay.Enabled = true;
            this.axWindowsMediaPlayerPlay.Location = new System.Drawing.Point(36, 279);
            this.axWindowsMediaPlayerPlay.Name = "axWindowsMediaPlayerPlay";
            this.axWindowsMediaPlayerPlay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerPlay.OcxState")));
            this.axWindowsMediaPlayerPlay.Size = new System.Drawing.Size(347, 44);
            this.axWindowsMediaPlayerPlay.TabIndex = 3;
            this.axWindowsMediaPlayerPlay.Enter += new System.EventHandler(this.axWindowsMediaPlayerPlay_Enter);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(114, 45);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(187, 29);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(736, 397);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(124, 29);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(587, 397);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(124, 29);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged_1);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 442);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxConversion);
            this.Controls.Add(this.groupBoxLoadImage);
            this.Name = "Application";
            this.Text = "RGBtoMIDI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadImage)).EndInit();
            this.groupBoxLoadImage.ResumeLayout(false);
            this.groupBoxLoadImage.PerformLayout();
            this.groupBoxConversion.ResumeLayout(false);
            this.groupBoxConversion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLoadImage;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.GroupBox groupBoxLoadImage;
        private System.Windows.Forms.GroupBox groupBoxConversion;
        private System.Windows.Forms.Button buttonLoadFile;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerPlay;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

