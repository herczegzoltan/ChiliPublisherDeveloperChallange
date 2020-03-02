using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiliPublisherDeveloperChallange.Model
{
    public class CustomPanel
    {
        public string Name { get; set; }
        public string Hight { get; set; }
        public string Width { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string AT { get; set; }

        public CustomPanel Parent{ get; set; }
        //public string Top { get; set; } 
        //public string Bottom { get; set; }
        //public string Left { get; set; }
        //public string Right { get; set; }
        public enum IsRotated 
        {
            once = 1, twice = 2, thrice = 3, none = 0
        }
        public List<CustomPanel> ChildPanels { get; set; }

        public CustomPanel()
        {
            ChildPanels = new List<CustomPanel>();
        }
    }
}
