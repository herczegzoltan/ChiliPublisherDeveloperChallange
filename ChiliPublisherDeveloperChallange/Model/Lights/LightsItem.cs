using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{

	[XmlRoot(ElementName = "item")]
	public class LightsItem
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "x")]
		public string X { get; set; }
		[XmlAttribute(AttributeName = "y")]
		public string Y { get; set; }
		[XmlAttribute(AttributeName = "z")]
		public string Z { get; set; }
		[XmlAttribute(AttributeName = "color")]
		public string Color { get; set; }
		[XmlAttribute(AttributeName = "ambient")]
		public string Ambient { get; set; }
		[XmlAttribute(AttributeName = "diffuse")]
		public string Diffuse { get; set; }
		[XmlAttribute(AttributeName = "specular")]
		public string Specular { get; set; }
		[XmlAttribute(AttributeName = "attachToCamera")]
		public string AttachToCamera { get; set; }
		[XmlAttribute(AttributeName = "fallOff")]
		public string FallOff { get; set; }
	}

}