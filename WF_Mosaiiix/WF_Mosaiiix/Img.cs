using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WF_Mosaiiix
{
    class Img
    {
        object balanceLock;
        private const int NO_COLOR = -1;
        private const int SIZE_PIXEL = 3;
        private Image<Bgr, byte> _img;
        private Image _mask;
        private Bitmap _imgModified;
        private string _imgName;
        private List<ImgInfo> imgInfos;

        public Image<Bgr, byte> Picture { get => _img; set => _img = value; }
        public string ImgName { get => _imgName; set => _imgName = value; }
        public Bitmap ImgModified { get => _imgModified; set => _imgModified = value; }
        public Image Mask { get => _mask; set => _mask = value; }
        public List<ImgInfo> ImgInfos { get => imgInfos; set => imgInfos = value; }

        public Img()
        {
            balanceLock = new object();
            Picture = null;
            imgInfos = new List<ImgInfo>();
        }

        /// <summary>
        /// Import an image
        /// </summary>
        public bool UploadPicture()
        {
            bool res = false;
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp;)|*.png; *.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Picture = new Image<Bgr, byte>(open.FileName);
                ImgName = open.FileName;
                res = true;
            }
            return res;
        }

        /// <summary>
        /// Import a bunch of images
        /// </summary>
        /// <param name="widthGrid">The width of the grid</param>
        /// <param name="heightGrid">The height of the grid</param>
        /// <returns>True if upload went well, False if there was an error at import</returns>
        public bool UploadPictures(double widthGrid, double heightGrid)
        {
            bool res = false;
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp;)|*.png; *.jpg; *.jpeg; *.gif; *.bmp;";
            open.Multiselect = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                int width = (int)Math.Round(Picture.Width / widthGrid);
                int height = (int)Math.Round(Picture.Height / heightGrid);
                if (width > 0 && height > 0)
                {
                    imgInfos = new List<ImgInfo>();
                    foreach (string filename in open.FileNames)
                    {
                        imgInfos.Add(new ImgInfo(filename, new Size(width, height)));
                    }
                    res = true;
                }
            }
            return res;
        }

        /// <summary>
        /// Save the picture modified
        /// </summary>
        public void SavePicture()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp; *.webp;)|*.png; *.jpg; *.jpeg; *.gif; *.bmp; *.webp;";
            save.FilterIndex = 2;
            save.RestoreDirectory = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                // Code to write the stream goes here.
                string ext = System.IO.Path.GetExtension(save.FileName);
                ImageFormat imgformat = null;
                switch (ext)
                {
                    case ".png":
                        imgformat = ImageFormat.Png;
                        break;
                    case ".jpg":
                        imgformat = ImageFormat.Jpeg;
                        break;
                    default:
                        break;
                }
                ImgModified.Save(save.FileName, imgformat);
            }

        }

        /// <summary>
        /// Pixelize a picture and replaces the cells by a picture that match the average of colors
        /// </summary>
        /// <param name="sizeX">The number of cells to create at x axis</param>
        /// <param name="sizeY">The number of cells to create at y axis</param>
        /// <param name="progress">The progress bar displayed to the user</param>
        /// <param name="colorThreshold">The threshold of the padding matching color</param>
        public unsafe void PixelizePicture(int sizeX, int sizeY, ProgressBar progress, int colorThreshold)
        {
            ImgModified = Picture.ToBitmap();
            int widthCell = (int)Math.Round((double)ImgModified.Width / sizeX);
            int heightCell = (int)Math.Round((double)ImgModified.Height / sizeY);

            progress.Value = 0;

            BitmapData xData = ImgModified.LockBits(
        new Rectangle(0, 0, ImgModified.Width, ImgModified.Height),
        ImageLockMode.ReadWrite,
        PixelFormat.Format24bppRgb);

            lock (balanceLock)
            {
                byte* startPixel = (byte*)xData.Scan0.ToPointer();

                for (int y = 0; y < sizeY; y++)
                {
                    for (int x = 0; x < sizeX; x++)
                    {
                        List<int> lstBlueCells = new List<int>();
                        List<int> lstGreenCells = new List<int>();
                        List<int> lstRedCells = new List<int>();
                        Debug.WriteLine("Parcourons une cellule");

                        for (int j = 0; j < heightCell; j++)
                        {
                            for (int i = 0; i < widthCell; i++)
                            {
                                int xPos = i + (x * widthCell);
                                int yPos = j + (y * heightCell);

                                if (xPos < ImgModified.Width && yPos < ImgModified.Height)
                                {
                                    lstBlueCells.Add(GetPixelColor(xPos, yPos, xData, startPixel).B);
                                    lstGreenCells.Add(GetPixelColor(xPos, yPos, xData, startPixel).G);
                                    lstRedCells.Add(GetPixelColor(xPos, yPos, xData, startPixel).R);
                                }
                            }
                        }

                        int averageBlue = lstBlueCells.Count > 0 ? (int)lstBlueCells.Average() : 0;
                        int averageGreen = lstGreenCells.Count > 0 ? (int)lstGreenCells.Average() : 0;
                        int averageRed = lstRedCells.Count > 0 ? (int)lstRedCells.Average() : 0;

                        Debug.WriteLine("Modifions cette cellule");
                        foreach (ImgInfo img in imgInfos)
                        {
                            Debug.WriteLine("L'image : " + img.Filename + " est-elle bonne ?");
                            if ((averageBlue + colorThreshold > img.B && averageBlue - colorThreshold < img.B) &&
                                            (averageGreen + colorThreshold > img.G && averageGreen - colorThreshold < img.G) &&
                                            (averageRed + colorThreshold > img.R && averageRed - colorThreshold < img.R))
                            {
                                Debug.WriteLine("elle l'est");
                                for (int j = 0; j < heightCell; j++)
                                {
                                    for (int i = 0; i < widthCell; i++)
                                    {
                                        if (progress.Value < progress.Maximum)
                                        {

                                            progress.Value++;
                                        }
                                        else
                                        {
                                            progress.Value = progress.Maximum;
                                        }

                                        int xPos = i + (x * widthCell);
                                        int yPos = j + (y * heightCell);

                                        if (xPos < ImgModified.Width && yPos < ImgModified.Height)
                                        {
                                            Color c = img.Pic.GetPixel(i, j);
                                            int b = c.B;
                                            int g = c.G;
                                            int r = c.R;
                                            SetPixelColor(xPos, yPos, xData, startPixel, b, g, r);
                                        }
                                    }
                                }
                                break;
                            }
                            else {
                                for (int j = 0; j < heightCell; j++)
                                {
                                    for (int i = 0; i < widthCell; i++)
                                    {
                                        int xPos = i + (x * widthCell);
                                        int yPos = j + (y * heightCell);

                                        if (xPos < ImgModified.Width && yPos < ImgModified.Height)
                                        {
                                            SetPixelColor(xPos, yPos, xData, startPixel, averageBlue, averageGreen, averageRed);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            progress.Value = progress.Maximum;
            ImgModified.UnlockBits(xData);
        }

        /// <summary>
        /// Get the color of the pixel
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        /// <param name="xData">Data of the picture</param>
        /// <param name="pixel">The pointer on the pixel</param>
        /// <returns></returns>
        private unsafe Color GetPixelColor(int x, int y, BitmapData xData, byte* pixel)
        {
            int sizeRow = y * xData.Stride;
            int step = x * Image.GetPixelFormatSize(xData.PixelFormat) / 8;
            int b = pixel[step + sizeRow];
            int g = pixel[step + sizeRow + 1];
            int r = pixel[step + sizeRow + 2];
            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// Set the pixel color
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        /// <param name="xData">Data of the picture</param>
        /// <param name="pixel">The pointer on the pixel</param>
        /// <param name="b">The blue color</param>
        /// <param name="g">The green color</param>
        /// <param name="r">The red color</param>
        private unsafe void SetPixelColor(int x, int y, BitmapData xData, byte* pixel, int b, int g, int r)
        {
            int sizeRow = y * xData.Stride;
            int step = x * Image.GetPixelFormatSize(xData.PixelFormat) / 8;
            pixel[step + sizeRow] = (byte)b;
            pixel[step + sizeRow + 1] = (byte)g;
            pixel[step + sizeRow + 2] = (byte)r;
        }
    }
}
