using ChiliPublisherDeveloperChallange.Infrastructure;
using ChiliPublisherDeveloperChallange.Model;
using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
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

                //foreach (var a in c.PanelsItem.AttachedPanels)
                //{
                //    MessageBox.Show(a.PanelsItem.PanelId);

                //}
                //foreach (var v in c.AttachedPanels)
                //{
                //    MessageBox.Show(v.PanelsItem);

                //}
            }
        }
    }
}
