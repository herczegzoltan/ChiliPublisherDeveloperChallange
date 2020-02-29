using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
    [XmlRoot(ElementName = "panels")]
	public class Panels
	{
		[XmlElement(ElementName = "item")]
		public Item Item { get; set; }
	}

}
