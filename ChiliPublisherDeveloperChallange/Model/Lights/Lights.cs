using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
    //[XmlRoot(ElementName = "lights")]
	public class Lights
	{
		[XmlElement(ElementName = "item")]
		public LightsItem LightsItem { get; set; }
	}

}
