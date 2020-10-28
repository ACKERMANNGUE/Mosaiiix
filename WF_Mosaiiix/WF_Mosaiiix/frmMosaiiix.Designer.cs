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
            this.pcbMosaic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInitialImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMosaic)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbInitialImage
            // 
            this.pcbInitialImage.Location = new System.Drawing.Point(12, 22);
            this.pcbInitialImage.Name = "pcbInitialImage";
            this.pcbInitialImage.Size = new System.Drawing.Size(300, 300);
            this.pcbInitialImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbInitialImage.TabIndex = 1;
            this.pcbInitialImage.TabStop = false;
            // 
            // btnLoadInitialImage
            // 
            this.btnLoadInitialImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadInitialImage.Location = new System.Drawing.Point(12, 328);
            this.btnLoadInitialImage.Name = "btnLoadInitialImage";
            this.btnLoadInitialImage.Size = new System.Drawing.Size(300, 67);
            this.btnLoadInitialImage.TabIndex = 2;
            this.btnLoadInitialImage.Text = "Charger Image de base";
            this.btnLoadInitialImage.UseVisualStyleBackColor = true;
            this.btnLoadInitialImage.Click += new System.EventHandler(this.btnLoadInitialImage_Click);
            // 
            // btnLoadSetOfImages
            // 
            this.btnLoadSetOfImages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadSetOfImages.Location = new System.Drawing.Point(318, 328);
            this.btnLoadSetOfImages.Name = "btnLoadSetOfImages";
            this.btnLoadSetOfImages.Size = new System.Drawing.Size(300, 67);
            this.btnLoadSetOfImages.TabIndex = 3;
            this.btnLoadSetOfImages.Text = "Charger dossiers d\'images";
            this.btnLoadSetOfImages.UseVisualStyleBackColor = true;
            // 
            // btnLaunchProcess
            // 
            this.btnLaunchProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLaunchProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchProcess.Location = new System.Drawing.Point(624, 328);
            this.btnLaunchProcess.Name = "btnLaunchProcess";
            this.btnLaunchProcess.Size = new System.Drawing.Size(300, 67);
            this.btnLaunchProcess.TabIndex = 4;
            this.btnLaunchProcess.Text = "Et c\'est partit, let\'s go";
            this.btnLaunchProcess.UseVisualStyleBackColor = true;
            this.btnLaunchProcess.Click += new System.EventHandler(this.btnLaunchProcess_Click);
            // 
            // pcbDrew
            // 
            this.pcbDrew.Location = new System.Drawing.Point(318, 22);
            this.pcbDrew.Name = "pcbDrew";
            this.pcbDrew.Size = new System.Drawing.Size(300, 300);
            this.pcbDrew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDrew.TabIndex = 5;
            this.pcbDrew.TabStop = false;
            // 
            // pcbMosaic
            // 
            this.pcbMosaic.Location = new System.Drawing.Point(624, 22);
            this.pcbMosaic.Name = "pcbMosaic";
            this.pcbMosaic.Size = new System.Drawing.Size(300, 300);
            this.pcbMosaic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMosaic.TabIndex = 6;
            this.pcbMosaic.TabStop = false;
            // 
            // frmMosaiiix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 400);
            this.Controls.Add(this.pcbMosaic);
            this.Controls.Add(this.pcbDrew);
            this.Controls.Add(this.btnLaunchProcess);
            this.Controls.Add(this.btnLoadSetOfImages);
            this.Controls.Add(this.btnLoadInitialImage);
            this.Controls.Add(this.pcbInitialImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMosaiiix";
            this.Text = "Mosaiiix";
            this.Load += new System.EventHandler(this.frmMosaiiix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbInitialImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMosaic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbInitialImage;
        private System.Windows.Forms.Button btnLoadInitialImage;
        private System.Windows.Forms.Button btnLoadSetOfImages;
        private System.Windows.Forms.Button btnLaunchProcess;
        private System.Windows.Forms.PictureBox pcbDrew;
        private System.Windows.Forms.PictureBox pcbMosaic;
    }
}

