using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiliPublisherDeveloperChallange.Infrastructure
{
    public class BitmapSaveToJpg
    {
        public static string SavePreview(Bitmap bm)
        {
            Graphics g = Graphics.FromImage(bm);
            g.Flush();
            bm.Save("file.jpg", ImageFormat.Jpeg);
            g.Dispose();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "JPeg Image|*.jpg";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    FileStream fs = (FileStream)saveFileDialog1.OpenFile();

                    bm.Save(fs, ImageFormat.Jpeg);
                    fs.Close();
                    return "File saved successfully!";
                }
                catch (Exception ex)
                {
                    return $"Exception: {ex.Message}\n\n Details:\n\n{ex.StackTrace}";
                }

            }
            return "";
        }
    }
}
