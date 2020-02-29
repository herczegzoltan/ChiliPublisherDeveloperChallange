using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
    [XmlRoot(ElementName = "materials")]
	public class Materials
	{
		[XmlElement(ElementName = "item")]
		public List<Item> Item { get; set; }
	}

}
