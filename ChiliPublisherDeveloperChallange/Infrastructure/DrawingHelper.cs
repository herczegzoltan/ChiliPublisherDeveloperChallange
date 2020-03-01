using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ChiliPublisherDeveloperChallange.Infrastructure
{
    public  class DrawingHelper
    {
        public static BitmapImage ConvertBitmapImageToBitmap(Bitmap src)
        {
            MemoryStream ms = new MemoryStream();
            ((Bitmap)src).Save(ms, ImageFormat.Bmp);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }

        public static Bitmap DrawRectangle(Bitmap bm,int x, int y, int width, int height)
        {
            using (Graphics gr = Graphics.FromImage(bm))
            {
                Rectangle rect = new Rectangle(x, y, width, height);
                using (Pen thick_pen = new Pen(Color.Black, 1))
                {
                    gr.DrawRectangle(thick_pen, rect);
                }
            }

            return bm;
        }

        public static void SaveFile()
        {

        }
    }
}
