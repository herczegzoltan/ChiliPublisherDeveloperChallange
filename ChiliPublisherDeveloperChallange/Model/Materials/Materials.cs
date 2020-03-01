using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
	public class Materials
	{
		[XmlElement(ElementName = "item")]
		public List<MaterialsItem> MaterialsItem { get; set; }

	}

}
