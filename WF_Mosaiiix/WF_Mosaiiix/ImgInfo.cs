using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Mosaiiix
{
    class ImgInfo
    {
        private object balanceLock;
        private Bitmap pic;
        private string filename;
        private int r;
        private int g;
        private int b;
        private BitmapData xData;
        private Size size;

        public int R { get => r; }
        public int G { get => g; }
        public int B { get => b; }
        public BitmapData XData { get => xData; set => xData = value; }
        public string Filename { get => filename; }
        public Bitmap Pic { get => pic; set => pic = value; }
        public Size Size { get => size;}

        public ImgInfo(string pPath, Size pSize)
        {
            filename = pPath;
            balanceLock = new object();
            size = pSize;
            Pic = new Bitmap(Image.FromFile(pPath), pSize);
            SetAverageOfColors();
        }
        /// <summary>
        /// Set the average of colors for a picture
        /// </summary>
        public unsafe void SetAverageOfColors()
        {
            xData = Pic.LockBits(
        new Rectangle(0, 0, Pic.Width, Pic.Height),
        ImageLockMode.ReadWrite,
        PixelFormat.Format24bppRgb);

            lock (balanceLock)
            {
                byte* startPixel = (byte*)xData.Scan0.ToPointer();
                int bitsPerPixel = Image.GetPixelFormatSize(xData.PixelFormat);

                List<int> lstBlueCells = new List<int>();
                List<int> lstGreenCells = new List<int>();
                List<int> lstRedCells = new List<int>();

                for (int y = 0; y < Pic.Height; y++)
                {
                    for (int x = 0; x < Pic.Width; x++)
                    {
                        lstBlueCells.Add(GetPixelColor(x, y, startPixel).B);
                        lstGreenCells.Add(GetPixelColor(x, y, startPixel).G);
                        lstRedCells.Add(GetPixelColor(x, y, startPixel).R);
                    }
                }
                b = lstBlueCells.Count > 0 ? (int)lstBlueCells.Average() : 0;
                g = lstGreenCells.Count > 0 ? (int)lstGreenCells.Average() : 0;
                r = lstRedCells.Count > 0 ? (int)lstRedCells.Average() : 0;
            }
            Pic.UnlockBits(xData);
        }

        /// <summary>
        /// Get the color of the pixel
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        /// <param name="pixel">The pointer on the pixel</param>
        /// <returns></returns>
        public unsafe Color GetPixelColor(int x, int y, byte* pixel)
        {
            int sizeRow = y * XData.Stride;
            int step = x * Image.GetPixelFormatSize(XData.PixelFormat) / 8;
            int b = pixel[step + sizeRow];
            int g = pixel[step + sizeRow + 1];
            int r = pixel[step + sizeRow + 2];
            return Color.FromArgb(r, g, b);
        }
    }
}
