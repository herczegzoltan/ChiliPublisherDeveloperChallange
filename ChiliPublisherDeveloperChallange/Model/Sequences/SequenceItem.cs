using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{

	public class SequenceItem
	{
		[XmlAttribute(AttributeName = "targetType")]
		public string TargetType { get; set; }
		[XmlAttribute(AttributeName = "delay")]
		public string Delay { get; set; }
		[XmlAttribute(AttributeName = "time")]
		public string Time { get; set; }
		[XmlAttribute(AttributeName = "easing")]
		public string Easing { get; set; }
		[XmlAttribute(AttributeName = "fromXRad")]
		public string FromXRad { get; set; }
		[XmlAttribute(AttributeName = "toXRad")]
		public string ToXRad { get; set; }
		[XmlAttribute(AttributeName = "fromYRad")]
		public string FromYRad { get; set; }
		[XmlAttribute(AttributeName = "toYRad")]
		public string ToYRad { get; set; }
		[XmlAttribute(AttributeName = "fromRadius")]
		public string FromRadius { get; set; }
		[XmlAttribute(AttributeName = "toRadius")]
		public string ToRadius { get; set; }
		[XmlAttribute(AttributeName = "fromX")]
		public string FromX { get; set; }
		[XmlAttribute(AttributeName = "toX")]
		public string ToX { get; set; }
		[XmlAttribute(AttributeName = "fromY")]
		public string FromY { get; set; }
		[XmlAttribute(AttributeName = "toY")]
		public string ToY { get; set; }
		[XmlAttribute(AttributeName = "fromZ")]
		public string FromZ { get; set; }
		[XmlAttribute(AttributeName = "toZ")]

		public string ToZ { get; set; }
		[XmlAttribute(AttributeName = "panel")]
		public string Panel { get; set; }
		[XmlAttribute(AttributeName = "from")]
		public string From { get; set; }
		[XmlAttribute(AttributeName = "to")]
		public string To { get; set; }

	}

}
