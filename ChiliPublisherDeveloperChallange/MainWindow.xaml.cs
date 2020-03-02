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
        List<CustomPanel> CustomPanels = null;

        public MainWindow()
        {
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
            InitializeComponent();
            bm = new Bitmap(1000, 1000);
            CustomPanels = new List<CustomPanel>(); 

            using (Graphics graph = Graphics.FromImage(bm))
            {
                System.Drawing.Rectangle ImageSize = new System.Drawing.Rectangle(0, 0, 1000, 1000);
                graph.FillRectangle(System.Drawing.Brushes.White, ImageSize);
            }
        }

        private void ReadXMLFile_Click(object sender, RoutedEventArgs e)
        {
            RootObject item = new RootObject(); 
            item = XmlProcessor.GetXmlRootObject(@"C:\Projects\BeerPack.xml");
            string temp = "";
            temp = item.Panels.PanelsItem.PanelName + " " + item.Panels.PanelsItem.PanelWidth + " " + item.Panels.PanelsItem.PanelHeight;
            ListOfPanels.Content = temp+ "\n" + ListOfPanels.Content + "\n";


            AttachedPanelsItem rootAttached = new AttachedPanelsItem()
            {
                PanelName = item.Panels.PanelsItem.PanelName,
                PanelWidth = item.Panels.PanelsItem.PanelWidth,
                PanelHeight = item.Panels.PanelsItem.PanelHeight,
                AttachedPanelsItems = item.Panels.PanelsItem.AttachedPanelsItems
            };


            //var rPanel = new CustomPanel()
            //{
            //    Name = item.Panels.PanelsItem.PanelName,
            //    Width = item.Panels.PanelsItem.PanelWidth,
            //    Hight = item.Panels.PanelsItem.PanelHeight,
            //    AT = item.Panels.PanelsItem.AttachedToSide
            //};
            //CustomPanels.Add(rPanel);



            //foreach (var c in item.Panels.PanelsItem.AttachedPanelsItems.AttachedPanelsItem)
            //{
            //    temp = c.PanelName + " " + c.PanelWidth + " " + c.PanelHeight + " " + "level1";

            //    ListOfPanels.Content = temp + "\n" + ListOfPanels.Content +"\n";

            //    var cPanel = new CustomPanel()
            //    {
            //        Name = c.PanelName,
            //        Width = c.PanelWidth,
            //        Hight = c.PanelHeight,
            //        AT = c.AttachedToSide
            //    };

            //    CustomPanels.Add(cPanel);

            //    foreach (var d in c.AttachedPanelsItems.AttachedPanelsItem)
            //    {
            //        temp = d.PanelName + " " + d.PanelWidth + " " + d.PanelHeight + " " + "level2";

            //        ListOfPanels.Content = temp + "\n" + ListOfPanels.Content + "\n";

            //        var dPanel = new CustomPanel()
            //        {
            //            Name = d.PanelName,
            //            Width = d.PanelWidth,
            //            Hight = d.PanelHeight,
            //            AT = d.AttachedToSide,
            //            Parent = cPanel
            //        };

            //        cPanel.ChildPanels.Add(dPanel);

            //        foreach (var k in d.AttachedPanelsItems.AttachedPanelsItem)
            //        {
            //            temp = k.PanelName + " " + k.PanelWidth + " " + k.PanelHeight + " " + "level3";

            //            ListOfPanels.Content = temp + "\n" + ListOfPanels.Content + "\n";

            //            var kPanel = new CustomPanel()
            //            {
            //                Name = k.PanelName,
            //                Width = k.PanelWidth,
            //                Hight = k.PanelHeight,
            //                AT = k.AttachedToSide,
            //                Parent = dPanel
            //            };

            //            dPanel.ChildPanels.Add(kPanel);

            //            foreach (var n in k.AttachedPanelsItems.AttachedPanelsItem)
            //            {
            //                temp = n.PanelName + " " + n.PanelWidth + " " + n.PanelHeight + " " + "level4";

            //                ListOfPanels.Content = temp + "\n" + ListOfPanels.Content + "\n";

            //                var nPanel = new CustomPanel()
            //                {
            //                    Name = n.PanelName,
            //                    Width = n.PanelWidth,
            //                    Hight = n.PanelHeight,
            //                    AT = n.AttachedToSide,
            //                    Parent = kPanel
            //                };

            //                kPanel.ChildPanels.Add(nPanel);
            //            }
            //        }
            //    }
            //}
        }



        private void LoopRootObject(AttachedPanelsItem currentRootObject, CustomPanel parentCustomPanel)
        {
            if (parentCustomPanel == null)
            {
                parentCustomPanel = new CustomPanel()
                {
                    Hight = currentRootObject.PanelHeight,
                    Width = currentRootObject.PanelWidth,
                    Name = currentRootObject.PanelName,
                    AT = currentRootObject.AttachedToSide
                };
                CustomPanels.Add(parentCustomPanel);
                
            }
            foreach (var n in currentRootObject.AttachedPanelsItems.AttachedPanelsItem)
            {
                var nPanel = new CustomPanel()
                {
                    Name = n.PanelName,
                    Width = n.PanelWidth,
                    Hight = n.PanelHeight,
                    AT = n.AttachedToSide,
                    Parent = parentCustomPanel
                };

                parentCustomPanel.ChildPanels.Add(nPanel);
                CustomPanels.Add(nPanel);
                LoopRootObject(n,nPanel);
            }
        }


        private void X(CustomPanel currentCustomPanel)
        {
            foreach (var n in currentCustomPanel.ChildPanels)
            {
                //TODO 
                X(n);
            }
        }


        private void CreatePreview_Click(object sender, RoutedEventArgs e)
        {

            //bm = DrawingHelper.DrawRectangle(bm,"1000", "1000","700","300",5);
            //bm = DrawingHelper.DrawRectangle(bm, "700", "1000", "300", "300",5);

            //bm = PanelsInserter.InsertRoot(bm);
            List<System.Drawing.Rectangle> rectangles = new List<System.Drawing.Rectangle>()
            {
                new System.Drawing.Rectangle(){X=0,Y=0, Height=100,Width=333},

                new System.Drawing.Rectangle(){X=530,Y=130,Height=444,Width=123}
            };
            bm = PanelsInserter.DrawingRectangles(bm, rectangles);
            RenderedPreview.Source = DrawingHelper.ConvertBitmapImageToBitmap(bm);
        }

        private void SavePreview_Click(object sender, RoutedEventArgs e)
        {
            Graphics g = Graphics.FromImage(bm);
            g.Flush();
            bm.Save("file.jpg",ImageFormat.Jpeg);
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
                UserMessage.Content = "File saved successfully!";
            }
        }
    }
}
