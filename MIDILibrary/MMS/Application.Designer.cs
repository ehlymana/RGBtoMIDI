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
            this.groupBoxConversion = new System.Windows.Forms.GroupBox();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayerPlay = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadImage)).BeginInit();
            this.groupBoxLoadImage.SuspendLayout();
            this.groupBoxConversion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLoadImage
            // 
            this.pictureBoxLoadImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxLoadImage.Location = new System.Drawing.Point(42, 45);
            this.pictureBoxLoadImage.Name = "pictureBoxLoadImage";
            this.pictureBoxLoadImage.Size = new System.Drawing.Size(332, 331);
            this.pictureBoxLoadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoadImage.TabIndex = 0;
            this.pictureBoxLoadImage.TabStop = false;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(116, 395);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(187, 29);
            this.buttonLoadImage.TabIndex = 1;
            this.buttonLoadImage.Text = "Load Image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // groupBoxLoadImage
            // 
            this.groupBoxLoadImage.Controls.Add(this.pictureBoxLoadImage);
            this.groupBoxLoadImage.Controls.Add(this.buttonLoadImage);
            this.groupBoxLoadImage.Location = new System.Drawing.Point(33, 28);
            this.groupBoxLoadImage.Name = "groupBoxLoadImage";
            this.groupBoxLoadImage.Size = new System.Drawing.Size(426, 459);
            this.groupBoxLoadImage.TabIndex = 3;
            this.groupBoxLoadImage.TabStop = false;
            this.groupBoxLoadImage.Text = "Load Image";
            // 
            // groupBoxConversion
            // 
            this.groupBoxConversion.Controls.Add(this.buttonLoadFile);
            this.groupBoxConversion.Controls.Add(this.axWindowsMediaPlayerPlay);
            this.groupBoxConversion.Controls.Add(this.buttonConvert);
            this.groupBoxConversion.Location = new System.Drawing.Point(477, 28);
            this.groupBoxConversion.Name = "groupBoxConversion";
            this.groupBoxConversion.Size = new System.Drawing.Size(426, 459);
            this.groupBoxConversion.TabIndex = 4;
            this.groupBoxConversion.TabStop = false;
            this.groupBoxConversion.Text = "Conversion";
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(114, 90);
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
            this.axWindowsMediaPlayerPlay.Location = new System.Drawing.Point(56, 135);
            this.axWindowsMediaPlayerPlay.Name = "axWindowsMediaPlayerPlay";
            this.axWindowsMediaPlayerPlay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerPlay.OcxState")));
            this.axWindowsMediaPlayerPlay.Size = new System.Drawing.Size(317, 241);
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
            this.buttonClose.Location = new System.Drawing.Point(779, 503);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(124, 29);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(634, 503);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(124, 29);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 544);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxConversion);
            this.Controls.Add(this.groupBoxLoadImage);
            this.Name = "Application";
            this.Text = "Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadImage)).EndInit();
            this.groupBoxLoadImage.ResumeLayout(false);
            this.groupBoxConversion.ResumeLayout(false);
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
    }
}

