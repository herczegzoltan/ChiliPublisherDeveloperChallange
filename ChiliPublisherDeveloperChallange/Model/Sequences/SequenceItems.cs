using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
    //[XmlElement(ElementName = "sequence")]
	public class SequenceItems
	{
		[XmlElement(ElementName = "item")]
		public List<SequenceItem> SequenceItem { get; set; }
	}

}
