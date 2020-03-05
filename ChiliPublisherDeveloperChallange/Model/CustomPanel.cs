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
        public int X { get; set; }
        public int Y { get; set; }
        public int Offset { get; set; }
        public string AT { get; set; }
        public bool IsRotatedFlag { get; set; }
        public bool IsDrew { get; set; }

        public CustomPanel Parent{ get; set; }
        public RotationState RotationState { get; set; }
        public List<CustomPanel> ChildPanels { get; set; }
        public CustomPanel()
        {
            IsDrew = false;
            ChildPanels = new List<CustomPanel>();
        }
    }
}
