using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
    public class AttachedPanelsItems
    {
        [XmlElement(ElementName = "item")]
        public List<AttachedPanelsItem> AttachedPanelsItem { get; set; }
    }
}