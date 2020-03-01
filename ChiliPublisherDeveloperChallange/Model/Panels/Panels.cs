using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
    [XmlRoot(ElementName = "panels")]
	public class Panels
	{
		[XmlElement(ElementName = "item")]
		public PanelsItem PanelsItem { get; set; }
	}

}
