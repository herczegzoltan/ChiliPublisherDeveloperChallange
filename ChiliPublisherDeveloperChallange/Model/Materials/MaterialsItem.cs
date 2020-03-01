using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
	public class MaterialsItem
    {
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlAttribute(AttributeName = "transparency")]
		public string Transparency { get; set; }

		[XmlAttribute(AttributeName = "materialType")]
		public string MaterialType { get; set; }

		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "color")]
		public string Color { get; set; }
		[XmlAttribute(AttributeName = "resourceMap")]
		public string ResourceMap { get; set; }

		[XmlAttribute(AttributeName = "ambient")]
		public string Ambient { get; set; }

		[XmlAttribute(AttributeName = "ambientColor")]
		public string AmbientColor { get; set; }

		[XmlAttribute(AttributeName = "specular")]
		public string Specular { get; set; }

		[XmlAttribute(AttributeName = "gloss")]
		public string Gloss { get; set; }
		[XmlAttribute(AttributeName = "pageNumber")]
		public string PageNumber { get; set; }
		[XmlAttribute(AttributeName = "documentIdentifier")]
		public string DocumentIdentifier { get; set; }
		[XmlAttribute(AttributeName = "embossMapType")]
		public string EmbossMapType { get; set; }
		[XmlAttribute(AttributeName = "embossMap")]
		public string EmbossMap { get; set; }
		[XmlAttribute(AttributeName = "specularMap")]
		public string SpecularMap { get; set; }
		[XmlAttribute(AttributeName = "reflectionIntensity")]
		public string ReflectionIntensity { get; set; }
		[XmlAttribute(AttributeName = "reflectionMask")]
		public string ReflectionMask { get; set; }
		[XmlAttribute(AttributeName = "reflectionMapName")]
		public string ReflectionMapName { get; set; }
		[XmlAttribute(AttributeName = "mask")]
		public string Mask { get; set; }
		[XmlAttribute(AttributeName = "mirrorMaskOverYAxis")]
		public string MirrorMaskOverYAxis { get; set; }
		[XmlAttribute(AttributeName = "renderPanelOutLines")]
		public string RenderPanelOutLines { get; set; }
		[XmlAttribute(AttributeName = "invertMask")]
		public string InvertMask { get; set; }
		[XmlAttribute(AttributeName = "mirrorMask")]
		public string MirrorMask { get; set; }
	}
}