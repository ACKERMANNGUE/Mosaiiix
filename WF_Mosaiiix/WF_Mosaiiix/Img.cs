using System;
using System.Collections.Generic;
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
        Image<Bgr, byte> _img;
        Image _mask;
        Bitmap _imgModified;
        string _imgName;
        public Image<Bgr, byte> Picture { get => _img; set => _img = value; }
        public string ImgName { get => _imgName; set => _imgName = value; }
        public Bitmap ImgModified { get => _imgModified; set => _imgModified = value; }
        public Image Mask { get => _mask; set => _mask = value; }


        public Img()
        {
            balanceLock = new object();
            Picture = null;
        }
        /// <summary>
        /// Importation d'une image provenement du PC
        /// </summary>
        public void UploadPicture()
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp; *.webp;)|*.png; *.jpg; *.jpeg; *.gif; *.bmp; *.webp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Picture = new Image<Bgr, byte>(open.FileName);
                ImgName = open.FileName;
            }
        }
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


        public unsafe void GetNeighborsColors(int sizeX, int sizeY)
        {
            ImgModified = Picture.ToBitmap();
            int widthCell = (int)Math.Round((double)ImgModified.Width / sizeX);
            int heightCell = (int)Math.Round((double)ImgModified.Height / sizeY);

            BitmapData xData = ImgModified.LockBits(
        new Rectangle(0, 0, ImgModified.Width, ImgModified.Height),
        ImageLockMode.ReadWrite,
        PixelFormat.Format24bppRgb);

            lock (balanceLock)
            {
                byte* startPixel = (byte*)xData.Scan0.ToPointer();
                int bitsPerPixel = Image.GetPixelFormatSize(xData.PixelFormat);

                for (int y = 0; y < sizeY; y++)
                {
                    for (int x = 0; x < sizeX; x++)
                    {

                        List<int> lstBlueCells = new List<int>();
                        List<int> lstGreenCells = new List<int>();
                        List<int> lstRedCells = new List<int>();
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

            ImgModified.UnlockBits(xData);
        }
        private unsafe Color GetPixelColor(int x, int y, BitmapData xData, byte* pixel)
        {
            int sizeRow = y * xData.Stride;
            int step = x * Image.GetPixelFormatSize(xData.PixelFormat) / 8;
            int b = pixel[step + sizeRow];
            int g = pixel[step + sizeRow + 1];
            int r = pixel[step + sizeRow + 2];
            return Color.FromArgb(r, g, b);

        }

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
