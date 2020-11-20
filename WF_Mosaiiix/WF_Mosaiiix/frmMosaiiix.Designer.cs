namespace WF_Mosaiiix
{
    partial class frmMosaiiix
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMosaiiix));
            this.pcbInitialImage = new System.Windows.Forms.PictureBox();
            this.btnLoadInitialImage = new System.Windows.Forms.Button();
            this.btnLoadSetOfImages = new System.Windows.Forms.Button();
            this.btnLaunchProcess = new System.Windows.Forms.Button();
            this.pcbDrew = new System.Windows.Forms.PictureBox();
            this.btnSaveMosaic = new System.Windows.Forms.Button();
            this.pgbProgress = new System.Windows.Forms.ProgressBar();
            this.nudScaleHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudScaleWidth = new System.Windows.Forms.NumericUpDown();
            this.trbThresholdRed = new System.Windows.Forms.TrackBar();
            this.btnLoadVideo = new System.Windows.Forms.Button();
            this.lblNbFrames = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trbThresholdGreen = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trbThersholdBlue = new System.Windows.Forms.TrackBar();
            this.nudImgWidth = new System.Windows.Forms.NumericUpDown();
            this.NudImgHeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudGridWidth = new System.Windows.Forms.NumericUpDown();
            this.nudGridHeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInitialImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThresholdRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThresholdGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThersholdBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudImgHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbInitialImage
            // 
            this.pcbInitialImage.Location = new System.Drawing.Point(14, 63);
            this.pcbInitialImage.Name = "pcbInitialImage";
            this.pcbInitialImage.Size = new System.Drawing.Size(500, 500);
            this.pcbInitialImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbInitialImage.TabIndex = 1;
            this.pcbInitialImage.TabStop = false;
            // 
            // btnLoadInitialImage
            // 
            this.btnLoadInitialImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadInitialImage.Location = new System.Drawing.Point(14, 569);
            this.btnLoadInitialImage.Name = "btnLoadInitialImage";
            this.btnLoadInitialImage.Size = new System.Drawing.Size(250, 67);
            this.btnLoadInitialImage.TabIndex = 3;
            this.btnLoadInitialImage.Text = "Load initial picture";
            this.btnLoadInitialImage.UseVisualStyleBackColor = true;
            this.btnLoadInitialImage.Click += new System.EventHandler(this.btnLoadInitialImage_Click);
            // 
            // btnLoadSetOfImages
            // 
            this.btnLoadSetOfImages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadSetOfImages.Location = new System.Drawing.Point(270, 568);
            this.btnLoadSetOfImages.Name = "btnLoadSetOfImages";
            this.btnLoadSetOfImages.Size = new System.Drawing.Size(244, 67);
            this.btnLoadSetOfImages.TabIndex = 4;
            this.btnLoadSetOfImages.Text = "Load set of pictures";
            this.btnLoadSetOfImages.UseVisualStyleBackColor = true;
            this.btnLoadSetOfImages.Click += new System.EventHandler(this.btnLoadSetOfImages_Click);
            // 
            // btnLaunchProcess
            // 
            this.btnLaunchProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLaunchProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchProcess.Location = new System.Drawing.Point(749, 568);
            this.btnLaunchProcess.Name = "btnLaunchProcess";
            this.btnLaunchProcess.Size = new System.Drawing.Size(126, 67);
            this.btnLaunchProcess.TabIndex = 5;
            this.btnLaunchProcess.Text = "Let\'s convert !";
            this.btnLaunchProcess.UseVisualStyleBackColor = true;
            this.btnLaunchProcess.Click += new System.EventHandler(this.btnLaunchProcess_Click);
            // 
            // pcbDrew
            // 
            this.pcbDrew.Location = new System.Drawing.Point(520, 63);
            this.pcbDrew.Name = "pcbDrew";
            this.pcbDrew.Size = new System.Drawing.Size(500, 500);
            this.pcbDrew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDrew.TabIndex = 5;
            this.pcbDrew.TabStop = false;
            // 
            // btnSaveMosaic
            // 
            this.btnSaveMosaic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveMosaic.Location = new System.Drawing.Point(881, 568);
            this.btnSaveMosaic.Name = "btnSaveMosaic";
            this.btnSaveMosaic.Size = new System.Drawing.Size(139, 67);
            this.btnSaveMosaic.TabIndex = 6;
            this.btnSaveMosaic.Text = "Save the modified picture";
            this.btnSaveMosaic.UseVisualStyleBackColor = true;
            this.btnSaveMosaic.Click += new System.EventHandler(this.btnSaveMosaic_Click);
            // 
            // pgbProgress
            // 
            this.pgbProgress.Location = new System.Drawing.Point(395, 7);
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(625, 47);
            this.pgbProgress.TabIndex = 7;
            // 
            // nudScaleHeight
            // 
            this.nudScaleHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudScaleHeight.Location = new System.Drawing.Point(190, 33);
            this.nudScaleHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudScaleHeight.Name = "nudScaleHeight";
            this.nudScaleHeight.Size = new System.Drawing.Size(68, 20);
            this.nudScaleHeight.TabIndex = 1;
            this.nudScaleHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudScaleHeight.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudScaleHeight.ValueChanged += new System.EventHandler(this.nudScaleHeight_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Height";
            // 
            // nudScaleWidth
            // 
            this.nudScaleWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudScaleWidth.Location = new System.Drawing.Point(190, 7);
            this.nudScaleWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudScaleWidth.Name = "nudScaleWidth";
            this.nudScaleWidth.Size = new System.Drawing.Size(68, 20);
            this.nudScaleWidth.TabIndex = 0;
            this.nudScaleWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudScaleWidth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudScaleWidth.ValueChanged += new System.EventHandler(this.nudScaleWidth_ValueChanged);
            // 
            // trbThresholdRed
            // 
            this.trbThresholdRed.Location = new System.Drawing.Point(1026, 80);
            this.trbThresholdRed.Maximum = 128;
            this.trbThresholdRed.Name = "trbThresholdRed";
            this.trbThresholdRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbThresholdRed.Size = new System.Drawing.Size(45, 556);
            this.trbThresholdRed.TabIndex = 2;
            this.trbThresholdRed.Value = 64;
            // 
            // btnLoadVideo
            // 
            this.btnLoadVideo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadVideo.Location = new System.Drawing.Point(520, 568);
            this.btnLoadVideo.Name = "btnLoadVideo";
            this.btnLoadVideo.Size = new System.Drawing.Size(223, 67);
            this.btnLoadVideo.TabIndex = 12;
            this.btnLoadVideo.Text = "Load a video and a set of images";
            this.btnLoadVideo.UseVisualStyleBackColor = true;
            this.btnLoadVideo.Click += new System.EventHandler(this.btnLoadVideo_Click);
            // 
            // lblNbFrames
            // 
            this.lblNbFrames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbFrames.Location = new System.Drawing.Point(1026, 14);
            this.lblNbFrames.Name = "lblNbFrames";
            this.lblNbFrames.Size = new System.Drawing.Size(143, 40);
            this.lblNbFrames.TabIndex = 13;
            this.lblNbFrames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1037, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1088, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "G";
            // 
            // trbThresholdGreen
            // 
            this.trbThresholdGreen.Location = new System.Drawing.Point(1077, 80);
            this.trbThresholdGreen.Maximum = 128;
            this.trbThresholdGreen.Name = "trbThresholdGreen";
            this.trbThresholdGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbThresholdGreen.Size = new System.Drawing.Size(45, 556);
            this.trbThresholdGreen.TabIndex = 15;
            this.trbThresholdGreen.Value = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1135, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "B";
            // 
            // trbThersholdBlue
            // 
            this.trbThersholdBlue.Location = new System.Drawing.Point(1124, 80);
            this.trbThersholdBlue.Maximum = 128;
            this.trbThersholdBlue.Name = "trbThersholdBlue";
            this.trbThersholdBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbThersholdBlue.Size = new System.Drawing.Size(45, 556);
            this.trbThersholdBlue.TabIndex = 17;
            this.trbThersholdBlue.Value = 64;
            // 
            // nudImgWidth
            // 
            this.nudImgWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudImgWidth.Location = new System.Drawing.Point(14, 7);
            this.nudImgWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudImgWidth.Name = "nudImgWidth";
            this.nudImgWidth.ReadOnly = true;
            this.nudImgWidth.Size = new System.Drawing.Size(68, 20);
            this.nudImgWidth.TabIndex = 19;
            this.nudImgWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudImgWidth.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // NudImgHeight
            // 
            this.NudImgHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NudImgHeight.Location = new System.Drawing.Point(14, 33);
            this.NudImgHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NudImgHeight.Name = "NudImgHeight";
            this.NudImgHeight.ReadOnly = true;
            this.NudImgHeight.Size = new System.Drawing.Size(68, 20);
            this.NudImgHeight.TabIndex = 20;
            this.NudImgHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudImgHeight.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "divide by";
            // 
            // nudGridWidth
            // 
            this.nudGridWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudGridWidth.Location = new System.Drawing.Point(321, 7);
            this.nudGridWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudGridWidth.Name = "nudGridWidth";
            this.nudGridWidth.ReadOnly = true;
            this.nudGridWidth.Size = new System.Drawing.Size(71, 20);
            this.nudGridWidth.TabIndex = 22;
            this.nudGridWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudGridHeight
            // 
            this.nudGridHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudGridHeight.Location = new System.Drawing.Point(321, 33);
            this.nudGridHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudGridHeight.Name = "nudGridHeight";
            this.nudGridHeight.ReadOnly = true;
            this.nudGridHeight.Size = new System.Drawing.Size(71, 20);
            this.nudGridHeight.TabIndex = 23;
            this.nudGridHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Grid size";
            // 
            // frmMosaiiix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 648);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudGridWidth);
            this.Controls.Add(this.nudGridHeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudImgWidth);
            this.Controls.Add(this.NudImgHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trbThersholdBlue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trbThresholdGreen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNbFrames);
            this.Controls.Add(this.btnLoadVideo);
            this.Controls.Add(this.trbThresholdRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudScaleWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudScaleHeight);
            this.Controls.Add(this.pgbProgress);
            this.Controls.Add(this.btnSaveMosaic);
            this.Controls.Add(this.pcbDrew);
            this.Controls.Add(this.btnLaunchProcess);
            this.Controls.Add(this.btnLoadSetOfImages);
            this.Controls.Add(this.btnLoadInitialImage);
            this.Controls.Add(this.pcbInitialImage);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMosaiiix";
            this.Text = "Mosaiiix";
            this.Load += new System.EventHandler(this.frmMosaiiix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbInitialImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThresholdRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThresholdGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThersholdBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImgWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudImgHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbInitialImage;
        private System.Windows.Forms.Button btnLoadInitialImage;
        private System.Windows.Forms.Button btnLoadSetOfImages;
        private System.Windows.Forms.Button btnLaunchProcess;
        private System.Windows.Forms.PictureBox pcbDrew;
        private System.Windows.Forms.Button btnSaveMosaic;
        private System.Windows.Forms.ProgressBar pgbProgress;
        private System.Windows.Forms.NumericUpDown nudScaleHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudScaleWidth;
        private System.Windows.Forms.TrackBar trbThresholdRed;
        private System.Windows.Forms.Button btnLoadVideo;
        private System.Windows.Forms.Label lblNbFrames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trbThresholdGreen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trbThersholdBlue;
        private System.Windows.Forms.NumericUpDown nudImgWidth;
        private System.Windows.Forms.NumericUpDown NudImgHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudGridWidth;
        private System.Windows.Forms.NumericUpDown nudGridHeight;
        private System.Windows.Forms.Label label7;
    }
}

