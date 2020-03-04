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
using Rectangle = System.Drawing.Rectangle;

namespace ChiliPublisherDeveloperChallange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Bitmap bm = null;
        List<CustomPanel> customPanels = null;
        List<CustomPanel> customPanelsAfterTransformation = null;
        List<CustomPanel> customPanelsAfterXYCoordinates = null;
        List<Rectangle> rectanglesToDraw = null;
        public MainWindow()
        {
            //Application.Current.MainWindow.WindowState = WindowState.Maximized;
            InitializeComponent();
            bm = new Bitmap(1200, 1200);
            customPanels = new List<CustomPanel>();
            customPanelsAfterTransformation = new List<CustomPanel>();
            customPanelsAfterXYCoordinates = new List<CustomPanel>();
            rectanglesToDraw = new List<Rectangle>();

            using (Graphics graph = Graphics.FromImage(bm))
            {
                System.Drawing.Rectangle ImageSize = new System.Drawing.Rectangle(0, 0, 1200, 1200);
                graph.FillRectangle(System.Drawing.Brushes.White, ImageSize);
            }
        }

        private void ReadXMLFile_Click(object sender, RoutedEventArgs e)
        {
            RootObject rootObject = new RootObject();
            rootObject = XmlProcessor.GetXmlRootObject(@"C:\Projects\BeerPack.xml");

            AttachedPanelsItem rootAttached = new AttachedPanelsItem()
            {
                PanelName = rootObject.Panels.PanelsItem.PanelName,
                PanelWidth = rootObject.Panels.PanelsItem.PanelWidth,
                PanelHeight = rootObject.Panels.PanelsItem.PanelHeight,
                AttachedPanelsItems = rootObject.Panels.PanelsItem.AttachedPanelsItems
            };

            CreateCustomPanelList(rootAttached, null);

            customPanelsAfterTransformation = PanelTransformation.RotatePanels(customPanels);
            customPanelsAfterXYCoordinates = PanelCoordinateCalculation.ChangeReferencePointOfRoot(customPanels,rootObject);

        }

        private void CreateCustomPanelList(AttachedPanelsItem currentRootObject, CustomPanel parentCustomPanel)
        {
            if (parentCustomPanel == null)
            {
                parentCustomPanel = new CustomPanel()
                {
                    Hight = currentRootObject.PanelHeight,
                    Width = currentRootObject.PanelWidth,
                    Name = currentRootObject.PanelName,
                    AT = currentRootObject.AttachedToSide,
                    IsRotatedFlag = true,
                    RotationState = RotationState.none
                };
                customPanels.Add(parentCustomPanel);
                
            }
            foreach (var n in currentRootObject.AttachedPanelsItems.AttachedPanelsItem)
            {
                var nPanel = new CustomPanel()
                {
                    Name = n.PanelName,
                    Width = n.PanelWidth,
                    Hight = n.PanelHeight,
                    AT = n.AttachedToSide,
                    Parent = parentCustomPanel,
                    IsRotatedFlag = false,
                    RotationState = RotationState.none
                };

                parentCustomPanel.ChildPanels.Add(nPanel);
                customPanels.Add(nPanel);
                CreateCustomPanelList(n,nPanel);
            }
        }

        private void CustomPanelConvertToRectagle(CustomPanel node)
        {
            if (node.Parent == null) //than its the root
            {
                Rectangle rootRectangle = new Rectangle()
                {
                    X = customPanelsAfterXYCoordinates[0].X / 5,
                    Y = customPanelsAfterXYCoordinates[0].Y / 5,
                    Height = Converters.DoubleStringToIntWithRound(customPanelsAfterXYCoordinates[0].Hight) / 5,
                    Width = Converters.DoubleStringToIntWithRound(customPanelsAfterXYCoordinates[0].Width) / 5
                };
                node.IsDrew = true;
                rectanglesToDraw.Add(rootRectangle);

            }
            for (int i = 0; i < node.ChildPanels.Count; i++)
            {
                CustomPanel childPanel = node.ChildPanels[i];

                if (childPanel.IsDrew)
                {
                    continue;
                }

                //childPanel = PanelRotate(childPanel, node);

                Rectangle currentRectangles = new Rectangle()
                {
                    X = childPanel.X / 5,
                    Y = childPanel.Y / 5,
                    Height = Converters.DoubleStringToIntWithRound(childPanel.Hight) / 5,
                    Width = Converters.DoubleStringToIntWithRound(childPanel.Width) / 5
                };
                childPanel.IsDrew = true;

                rectanglesToDraw.Add(currentRectangles);
                CustomPanelConvertToRectagle(childPanel);
            }

            //return new List<Rectangle>();
        }

        private void CreatePreview_Click(object sender, RoutedEventArgs e)
        {
            //    Rectangle rootRectangle = new Rectangle()
            //    {
            //        X = customPanelsAfterXYCoordinates[0].X / 5,
            //        Y = customPanelsAfterXYCoordinates[0].Y / 5,
            //        Height = Converters.DoubleStringToIntWithRound(customPanelsAfterXYCoordinates[0].Hight) / 5,
            //        Width = Converters.DoubleStringToIntWithRound(customPanelsAfterXYCoordinates[0].Width) / 5
            //    };

            //    Rectangle panel2Rectangle = new Rectangle()
            //    {
            //        X = customPanelsAfterXYCoordinates[0].ChildPanels[0].X / 5,
            //        Y = customPanelsAfterXYCoordinates[0].ChildPanels[0].Y / 5,
            //        Height = Converters.DoubleStringToIntWithRound(customPanelsAfterXYCoordinates[0].ChildPanels[0].Hight) / 5,
            //        Width = Converters.DoubleStringToIntWithRound(customPanelsAfterXYCoordinates[0].ChildPanels[0].Width) / 5
            //    };

            //    Rectangle panel3Rectangle = new Rectangle()
            //    {
            //        X = customPanelsAfterXYCoordinates[0].ChildPanels[1].X / 5,
            //        Y = customPanelsAfterXYCoordinates[0].ChildPanels[1].Y / 5,
            //        Height = Converters.DoubleStringToIntWithRound(customPanelsAfterXYCoordinates[0].ChildPanels[1].Hight) / 5,
            //        Width = Converters.DoubleStringToIntWithRound(customPanelsAfterXYCoordinates[0].ChildPanels[1].Width) / 5
            //    };

            //List<Rectangle> rectangles = new List<Rectangle>()
            //{
            //    rootRectangle,
            //    panel2Rectangle,
            //    panel3Rectangle
            //};
            CustomPanelConvertToRectagle(customPanelsAfterXYCoordinates[0]);

            bm = PanelsInserter.DrawingRectangles(bm, rectanglesToDraw);
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