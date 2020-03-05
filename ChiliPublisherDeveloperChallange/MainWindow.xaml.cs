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
            try
            {
                RootObject rootObject = new RootObject();
                rootObject = XmlProcessor.GetXmlRootObject(@"" + XmlSelector.GetSelectedXmlPath());

                AttachedPanelsItem rootAttached = new AttachedPanelsItem()
                {
                    PanelName = rootObject.Panels.PanelsItem.PanelName,
                    PanelWidth = rootObject.Panels.PanelsItem.PanelWidth,
                    PanelHeight = rootObject.Panels.PanelsItem.PanelHeight,
                    AttachedPanelsItems = rootObject.Panels.PanelsItem.AttachedPanelsItems
                };

                CreateCustomPanelList(rootAttached, null);

                customPanelsAfterTransformation = PanelTransformation.RotatePanels(customPanels);
                customPanelsAfterXYCoordinates = PanelCoordinateCalculation.ChangeReferencePointOfRoot(customPanels, rootObject);

                UserMessage.Content = "File info: Xml file was successfully read!";
                CreatePreview.IsEnabled = true;
                SavePreview.IsEnabled = true;
            }
            catch (Exception ex)
            {
                UserMessage.Content = "File error: " + ex.Message + "!";
            }
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
            if (node.Parent == null)
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
        }

        private void CreatePreview_Click(object sender, RoutedEventArgs e)
        {
            CustomPanelConvertToRectagle(customPanelsAfterXYCoordinates[0]);

            bm = PanelsInserter.DrawingRectangles(bm, rectanglesToDraw);
            RenderedPreview.Source = DrawingHelper.ConvertBitmapImageToBitmap(bm);
        }

        private void SavePreview_Click(object sender, RoutedEventArgs e)
        {
            UserMessage.Content = BitmapSaveToJpg.SavePreview(bm);
        }
    }
}