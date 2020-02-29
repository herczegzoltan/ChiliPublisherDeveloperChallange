using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
    [XmlRoot(ElementName = "sequence")]
	public class Sequence
	{
		[XmlElement(ElementName = "item")]
		public List<Item> Item { get; set; }
	}

}
