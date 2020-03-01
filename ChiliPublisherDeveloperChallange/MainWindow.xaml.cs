using ChiliPublisherDeveloperChallange.Infrastructure;
using ChiliPublisherDeveloperChallange.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace ChiliPublisherDeveloperChallange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Bitmap bm = null;

        public MainWindow()
        {
            InitializeComponent();
            bm = new Bitmap(500, 500);
            using (Graphics graph = Graphics.FromImage(bm))
            {
                System.Drawing.Rectangle ImageSize = new System.Drawing.Rectangle(0, 0, 500, 500);
                graph.FillRectangle(System.Drawing.Brushes.White, ImageSize);
            }
        }

        private void ReadXMLFile_Click(object sender, RoutedEventArgs e)
        {
            RootObject item = new RootObject(); 
            item = XmlProcessor.GetXmlRootObjectCommands(@"C:\Projects\BeerPack.xml");

            foreach (var c in item.Panels.PanelsItem.AttachedPanelsItems.AttachedPanelsItem)
            {
                foreach (var d in c.AttachedPanelsItems.AttachedPanelsItem)
                {
                    foreach (var k in d.AttachedPanelsItems.AttachedPanelsItem)
                    {
                        foreach (var ein in k.AttachedPanelsItems.AttachedPanelsItem)
                        {
                            MessageBox.Show(ein.PanelId);
                        }

                    }
                }
            }
        }
     
        private void CreatePreview_Click(object sender, RoutedEventArgs e)
        {
            //Bitmap bm = new Bitmap(500, 500);
            bm = DrawingHelper.DrawRectangle(bm,10, 10,200,200);

            RenderedPreview.Source = DrawingHelper.ConvertBitmapImageToBitmap(bm);

        }

        private void SavePreview_Click(object sender, RoutedEventArgs e)
        {
            bm = DrawingHelper.DrawRectangle(bm, 10, 10, 200, 200);

            Graphics g = Graphics.FromImage(bm);
            g.Flush();
            bm.Save("file.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            g.Dispose();

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "JPeg Image|*.jpg";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();

                bm.Save(fs,ImageFormat.Jpeg);
                fs.Close();

            }
        }
    }
}
