using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
    [XmlRoot(ElementName = "sequences")]
	public class Sequences
	{
		[XmlElement(ElementName = "sequence")]
		public Sequence Sequence { get; set; }
	}

}
