using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiliPublisherDeveloperChallange.Model
{
    public partial class CustomPanel
    {
        public string Name { get; set; }
        public string Hight { get; set; }
        public string Width { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string AT { get; set; }

        public bool IsRotatedFlag { get; set; }
        public CustomPanel Parent{ get; set; }
        public RotationState RotationState { get; set; }

        public List<CustomPanel> ChildPanels { get; set; }
        public CustomPanel()
        {
            ChildPanels = new List<CustomPanel>();
        }
    }
}
