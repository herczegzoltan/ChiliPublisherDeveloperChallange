using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
	public class PanelsItems
	{
		[XmlElement(ElementName = "attachedPanels")]
		public PanelsItem PanelsItem { get; set; }
	}
}