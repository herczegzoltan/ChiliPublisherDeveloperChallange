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

        public static Bitmap DrawRectangle(Bitmap bm, string x, string y, string width, string height, int resizer )
        {
            int ix = (int)(float.Parse(x));
            int iy = (int)(float.Parse(y));
            int iwidth = (int)(float.Parse(width));
            int iheight = (int)(float.Parse(height));

            using (Graphics gr = Graphics.FromImage(bm))
            {
                Rectangle rect = new Rectangle(ix / resizer,iy / resizer, iwidth / resizer, iheight/resizer);
                using (Pen thick_pen = new Pen(Color.Black, 1))
                {
                    gr.DrawRectangle(thick_pen, rect);
                }
            }
            return bm;
        }
    }
}
