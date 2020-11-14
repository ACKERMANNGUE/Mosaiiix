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
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.trbThreshold = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInitialImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThreshold)).BeginInit();
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
            this.btnLoadInitialImage.Size = new System.Drawing.Size(500, 67);
            this.btnLoadInitialImage.TabIndex = 3;
            this.btnLoadInitialImage.Text = "Charger Image de base";
            this.btnLoadInitialImage.UseVisualStyleBackColor = true;
            this.btnLoadInitialImage.Click += new System.EventHandler(this.btnLoadInitialImage_Click);
            // 
            // btnLoadSetOfImages
            // 
            this.btnLoadSetOfImages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadSetOfImages.Location = new System.Drawing.Point(520, 569);
            this.btnLoadSetOfImages.Name = "btnLoadSetOfImages";
            this.btnLoadSetOfImages.Size = new System.Drawing.Size(500, 67);
            this.btnLoadSetOfImages.TabIndex = 4;
            this.btnLoadSetOfImages.Text = "Charger dossiers d\'images";
            this.btnLoadSetOfImages.UseVisualStyleBackColor = true;
            this.btnLoadSetOfImages.Click += new System.EventHandler(this.btnLoadSetOfImages_Click);
            // 
            // btnLaunchProcess
            // 
            this.btnLaunchProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLaunchProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchProcess.Location = new System.Drawing.Point(14, 642);
            this.btnLaunchProcess.Name = "btnLaunchProcess";
            this.btnLaunchProcess.Size = new System.Drawing.Size(500, 67);
            this.btnLaunchProcess.TabIndex = 5;
            this.btnLaunchProcess.Text = "Et c\'est partit, let\'s go";
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
            this.btnSaveMosaic.Location = new System.Drawing.Point(520, 641);
            this.btnSaveMosaic.Name = "btnSaveMosaic";
            this.btnSaveMosaic.Size = new System.Drawing.Size(500, 67);
            this.btnSaveMosaic.TabIndex = 6;
            this.btnSaveMosaic.Text = "Sauvegarder la nouvelle image";
            this.btnSaveMosaic.UseVisualStyleBackColor = true;
            this.btnSaveMosaic.Click += new System.EventHandler(this.btnSaveMosaic_Click);
            // 
            // pgbProgress
            // 
            this.pgbProgress.Location = new System.Drawing.Point(138, 12);
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(882, 46);
            this.pgbProgress.TabIndex = 7;
            // 
            // nudWidth
            // 
            this.nudWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudWidth.Location = new System.Drawing.Point(64, 38);
            this.nudWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(68, 20);
            this.nudWidth.TabIndex = 1;
            this.nudWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWidth.Value = new decimal(new int[] {
            102,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Largeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hauteur";
            // 
            // nudHeight
            // 
            this.nudHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudHeight.Location = new System.Drawing.Point(64, 12);
            this.nudHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(68, 20);
            this.nudHeight.TabIndex = 0;
            this.nudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHeight.Value = new decimal(new int[] {
            102,
            0,
            0,
            0});
            // 
            // trbThreshold
            // 
            this.trbThreshold.Location = new System.Drawing.Point(1026, 15);
            this.trbThreshold.Maximum = 128;
            this.trbThreshold.Name = "trbThreshold";
            this.trbThreshold.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbThreshold.Size = new System.Drawing.Size(45, 693);
            this.trbThreshold.TabIndex = 2;
            this.trbThreshold.Value = 64;
            // 
            // frmMosaiiix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1066, 721);
            this.Controls.Add(this.trbThreshold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudWidth);
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
            this.MaximumSize = new System.Drawing.Size(1082, 760);
            this.MinimumSize = new System.Drawing.Size(1082, 760);
            this.Name = "frmMosaiiix";
            this.Text = "Mosaiiix";
            this.Load += new System.EventHandler(this.frmMosaiiix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbInitialImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThreshold)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.TrackBar trbThreshold;
    }
}

