using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
    [XmlRoot(ElementName = "attachedPanels")]
	public class AttachedPanels
	{
		[XmlElement(ElementName = "item")]
		public List<Item> Item { get; set; }
	}

}
