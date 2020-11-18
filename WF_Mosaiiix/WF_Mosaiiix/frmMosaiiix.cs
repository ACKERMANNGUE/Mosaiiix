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
                pgbProgress.Maximum = image.Picture.Height;
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
            List<ImgInfo> newImgInfos = new List<ImgInfo>();
            foreach (ImgInfo img in image.ImgInfos)
            {
                newImgInfos.Add(new ImgInfo(img.Filename, new Size((int)(image.Picture.Width / nudWidth.Value), (int)(image.Picture.Height / nudHeight.Value))));
            }
            image.ImgInfos = newImgInfos;
            image.PixelizePicture((int)nudWidth.Value, (int)nudHeight.Value, pgbProgress, trbThreshold.Value);
            
            pcbDrew.Image = image.ImgModified;
            btnSaveMosaic.Enabled = true;
            spProcessDone.Play();
        }

        private void btnLoadSetOfImages_Click(object sender, EventArgs e)
        {
            if (image.UploadPictures((double)nudWidth.Value, (double)nudHeight.Value, image.Picture.Width, image.Picture.Height))
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
        }

        private void ComputeVideo()
        {
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
                image.UploadPictures((double)nudWidth.Value, (double)nudHeight.Value, video.Width, video.Height);

                int totalFrames = (int)video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                int actualFrame = 0;
                using (VideoWriter vw = new VideoWriter(filename + "_converted.mp4", (int)video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FourCC),
                    (int)video.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps), new Size(video.Width, video.Height), true))
                {

                    Mat m = new Mat();
                    while (actualFrame <= totalFrames)
                    {
                        video.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, actualFrame);
                        video.Read(m);

                        Img i = new Img(m.ToImage<Bgr, Byte>(), image.ImgInfos);
                        if (i.PixelizePicture((int)nudWidth.Value, (int)nudHeight.Value, pgbProgress, trbThreshold.Value) && i.ImgModified != null)
                        {
                            m = i.ImgModified.ToImage<Bgr, byte>().Mat;
                            vw.Write(m);
                        }
                        actualFrame += 1;
                    }
                }
            }
        }
    }
}
