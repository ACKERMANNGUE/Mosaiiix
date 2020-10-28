using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            image.UploadPicture();
            pcbInitialImage.Image = image.Picture.ToBitmap();
        }

        private void frmMosaiiix_Load(object sender, EventArgs e)
        {
            image = new Img();
        }

        private void btnLaunchProcess_Click(object sender, EventArgs e)
        {
            image.GetColors(10);
            pcbDrew.Image = image.ImgModified;
        }
    }
}
