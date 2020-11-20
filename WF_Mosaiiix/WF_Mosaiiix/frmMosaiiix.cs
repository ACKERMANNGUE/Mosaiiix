///file frmMosaiiix.cs
///brief Class that represent that link the view with the model
///version 1.0
///author Ackermann Gawen
///date 18.11.2020

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

using Xabe.FFmpeg;
using System.Drawing.Imaging;

namespace WF_Mosaiiix
{
    public partial class frmMosaiiix : Form
    {
        private const int SCALE_VIDEO_SIZE = 4;
        private const int SCALE_PICTURE_SIZE = 2;
        Img image;
        SoundPlayer spStartProcess;
        SoundPlayer spProcessDone;


        public frmMosaiiix()
        {
            InitializeComponent();
        }
        private void frmMosaiiix_Load(object sender, EventArgs e)
        {
            spStartProcess = new SoundPlayer(Properties.Resources.start_process);
            spProcessDone = new SoundPlayer(Properties.Resources.process_done);
            image = new Img();
            btnLoadSetOfImages.Enabled = false;
            btnSaveMosaic.Enabled = false;
            btnLaunchProcess.Enabled = false;
            lblNbFrames.Enabled = false;
        }

        private void btnLoadInitialImage_Click(object sender, EventArgs e)
        {
            if (image.UploadPicture())
            {
                btnLoadSetOfImages.Enabled = true;
                pcbInitialImage.Image = image.Picture.ToBitmap();

                pgbProgress.Maximum = image.Picture.Height;

                nudImgWidth.Value = image.Picture.Width;
                NudImgHeight.Value = image.Picture.Height;

                nudGridWidth.Value = image.Picture.Width / nudScaleWidth.Value;
                nudGridHeight.Value = image.Picture.Height / nudScaleHeight.Value;
            }


        }

        private void btnLaunchProcess_Click(object sender, EventArgs e)
        {
            spStartProcess.Play();
            List<ImgInfo> newImgInfos = new List<ImgInfo>();

            //resize the pictures to fit the cells
            foreach (ImgInfo img in image.ImgInfos)
            {
                int width = (int)(image.Picture.Width / nudGridWidth.Value);
                int height = (int)(image.Picture.Height / nudGridHeight.Value);
                newImgInfos.Add(new ImgInfo(img.Filename, new Size(width, height)));
            }

            image.ImgInfos = newImgInfos;
            image.PixelizePicture((int)nudGridWidth.Value, (int)nudGridHeight.Value, pgbProgress, trbThresholdRed.Value, trbThresholdGreen.Value, trbThersholdBlue.Value);

            pcbDrew.Image = image.ImgModified;
            btnSaveMosaic.Enabled = true;
            spProcessDone.Play();

            lblNbFrames.Enabled = true;
            lblNbFrames.Text = "Frame 1 on 1";
        }

        private void btnLoadSetOfImages_Click(object sender, EventArgs e)
        {
            if (image.UploadPictures((double)nudGridWidth.Value, (double)nudGridHeight.Value, image.Picture.Width, image.Picture.Height))
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

        private void btnLoadVideo_Click(object sender, EventArgs e)
        {
            ComputeVideo();
            lblNbFrames.Enabled = true;
        }

        private void ComputeVideo()
        {
            spStartProcess.Play();
            OpenFileDialog videoFile = new OpenFileDialog();
            // image filters  
            videoFile.Filter = "Video Files(*.mp4; *.avi; *.wmv; *.webm; *.gif;)|*.mp4; *.avi; *.wmv; *.webm; *.gif;";

            string filename = "";
            if (videoFile.ShowDialog() == DialogResult.OK)
            {
                filename = videoFile.FileName;
            }

            using (VideoCapture video = new VideoCapture(filename))
            {
                nudGridWidth.Value = video.Width / nudScaleWidth.Value;
                nudGridHeight.Value = video.Height / nudScaleHeight.Value;
                //to avoid exception of unexisting size for the picture
                image.Picture = new Image<Bgr, byte>(new Size(video.Width, video.Height));
                image.UploadPictures((double)nudScaleHeight.Value, (double)nudScaleWidth.Value, video.Width, video.Height);

                int totalFrames = (int)video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                int actualFrame = 0;
                lblNbFrames.Text = $"Frame 1 on {totalFrames}";

                using (VideoWriter vw = new VideoWriter(filename + "_converted.mp4", (int)video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FourCC),
                    (int)video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps), new Size(video.Width, video.Height), true))
                {

                    Mat m = new Mat();
                    while (actualFrame <= totalFrames)
                    {
                        lblNbFrames.Text = $"Frame {actualFrame} on {totalFrames}";
                        lblNbFrames.Refresh();

                        video.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, actualFrame);
                        video.Read(m);

                        pcbInitialImage.Image = m.ToBitmap();
                        pcbInitialImage.Refresh();

                        Img i = new Img(m.ToImage<Bgr, Byte>(), image.ImgInfos);
                        if (i.PixelizePicture((int)nudGridWidth.Value, (int)nudGridHeight.Value, pgbProgress, trbThresholdRed.Value, trbThresholdGreen.Value, trbThersholdBlue.Value) && i.ImgModified != null)
                        {
                            m = i.ImgModified.ToImage<Bgr, byte>().Mat;
                            vw.Write(m);
                            pcbDrew.Image = m.ToBitmap();
                            pcbDrew.Refresh();
                        }
                        actualFrame += 1;
                    }
                }
            }
            spProcessDone.Play();
        }

        private void nudScaleWidth_ValueChanged(object sender, EventArgs e)
        {
            nudGridWidth.Value = image.Picture.Width / nudScaleWidth.Value;
        }

        private void nudScaleHeight_ValueChanged(object sender, EventArgs e)
        {
            nudGridHeight.Value = image.Picture.Height / nudScaleHeight.Value;
        }
    }
}
