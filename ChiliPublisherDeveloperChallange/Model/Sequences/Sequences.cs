using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
	public class Sequences
	{
		[XmlElement(ElementName = "sequence")]
		public SequenceItems SequenceItems { get; set; }
	}

}
