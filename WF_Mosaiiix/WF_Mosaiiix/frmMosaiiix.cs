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

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WF_Mosaiiix
{
    public partial class frmMosaiiix : Form
    {
        Img image;

        public frmMosaiiix()
        {
            InitializeComponent();
        }

        private void btnLoadInitialImage_Click(object sender, EventArgs e)
        {
            if (image.UploadPicture())
            {
                btnLoadSetOfImages.Enabled = true;
            }
            pcbInitialImage.Image = image.Picture.ToBitmap();
            pgbProgress.Maximum = image.Picture.Width * image.Picture.Height;
        }

        private void frmMosaiiix_Load(object sender, EventArgs e)
        {
            image = new Img();
            btnLoadSetOfImages.Enabled = false;
            btnSaveMosaic.Enabled = false;
            btnLaunchProcess.Enabled = false;
        }

        private void btnLaunchProcess_Click(object sender, EventArgs e)
        {
            pcbDrew.Image = null;
            image.PixelizePicture((int)nudWidth.Value, (int)nudHeight.Value, pgbProgress, trbThreshold.Value);
            pcbDrew.Image = image.ImgModified;
            btnSaveMosaic.Enabled = true;
        }

        private void btnLoadSetOfImages_Click(object sender, EventArgs e)
        {
            if (image.UploadPictures((double)nudWidth.Value, (double)nudHeight.Value))
            {
                btnLaunchProcess.Enabled = true;
            }
        }

        private void btnSaveMosaic_Click(object sender, EventArgs e)
        {
            image.SavePicture();
        }
    }
}
