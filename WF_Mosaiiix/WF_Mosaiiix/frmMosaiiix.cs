using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WF_Mosaiiix
{
    public partial class frmMosaiiix : Form
    {
        Img image;
        SoundPlayer spStartProcess;
        SoundPlayer spProcessDone;

        public frmMosaiiix()
        {
            InitializeComponent();
        }

        private void btnLoadInitialImage_Click(object sender, EventArgs e)
        {
            if (image.UploadPicture())
            {
                btnLoadSetOfImages.Enabled = true;
                pcbInitialImage.Image = image.Picture.ToBitmap();
                pgbProgress.Maximum =  image.Picture.Height;
                nudWidth.Value = image.Picture.Width / 2;
                nudHeight.Value = image.Picture.Height / 2;
            }
           
        }

        private void frmMosaiiix_Load(object sender, EventArgs e)
        {
            spStartProcess = new SoundPlayer(Properties.Resources.start_process);
            spProcessDone = new SoundPlayer(Properties.Resources.process_done);
            image = new Img();
            btnLoadSetOfImages.Enabled = false;
            btnSaveMosaic.Enabled = false;
            btnLaunchProcess.Enabled = false;
        }

        private void btnLaunchProcess_Click(object sender, EventArgs e)
        {
            spStartProcess.Play();
            image.PixelizePicture((int)nudWidth.Value, (int)nudHeight.Value, pgbProgress, trbThreshold.Value);
            pcbDrew.Image = image.ImgModified;
            btnSaveMosaic.Enabled = true;
            spProcessDone.Play();
        }

        private void btnLoadSetOfImages_Click(object sender, EventArgs e)
        {
            if (image.UploadPictures((double)nudWidth.Value, (double)nudHeight.Value))
            {
                btnLaunchProcess.Enabled = true;
            }
            else
            {
                MessageBox.Show("Il ne peut y avoir plus de cellules que de pixels dans l'image... Veuillez revérifier les valeurs de Hauteurs et Largeurs");
            }
        }

        private void btnSaveMosaic_Click(object sender, EventArgs e)
        {
            image.SavePicture();
        }
    }
}
