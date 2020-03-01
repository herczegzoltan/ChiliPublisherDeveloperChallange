using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
	[XmlRoot(ElementName = "item")]
	public class Itemold
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
		[XmlAttribute(AttributeName = "transparency")]


		public string Transparency { get; set; }
		[XmlAttribute(AttributeName = "materialType")]
		public string MaterialType { get; set; }
		[XmlAttribute(AttributeName = "resourceMap")]
		public string ResourceMap { get; set; }
		[XmlAttribute(AttributeName = "ambientColor")]
		public string AmbientColor { get; set; }
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
		[XmlElement(ElementName = "attachedPanels")]
		public AttachedPanels AttachedPanels { get; set; }
		[XmlAttribute(AttributeName = "panelId")]
		public string PanelId { get; set; }
		[XmlAttribute(AttributeName = "panelName")]
		public string PanelName { get; set; }
		[XmlAttribute(AttributeName = "minRot")]
		public string MinRot { get; set; }
		[XmlAttribute(AttributeName = "maxRot")]
		public string MaxRot { get; set; }
		[XmlAttribute(AttributeName = "initialRot")]
		public string InitialRot { get; set; }
		[XmlAttribute(AttributeName = "startRot")]
		public string StartRot { get; set; }
		[XmlAttribute(AttributeName = "endRot")]
		public string EndRot { get; set; }
		[XmlAttribute(AttributeName = "hingeOffset")]
		public string HingeOffset { get; set; }
		[XmlAttribute(AttributeName = "panelWidth")]
		public string PanelWidth { get; set; }
		[XmlAttribute(AttributeName = "panelHeight")]
		public string PanelHeight { get; set; }
		[XmlAttribute(AttributeName = "attachedToSide")]
		public string AttachedToSide { get; set; }
		[XmlAttribute(AttributeName = "creaseBottom")]
		public string CreaseBottom { get; set; }
		[XmlAttribute(AttributeName = "creaseTop")]
		public string CreaseTop { get; set; }
		[XmlAttribute(AttributeName = "creaseLeft")]
		public string CreaseLeft { get; set; }
		[XmlAttribute(AttributeName = "creaseRight")]
		public string CreaseRight { get; set; }
		[XmlAttribute(AttributeName = "ignoreCollisions")]
		public string IgnoreCollisions { get; set; }
		[XmlAttribute(AttributeName = "mouseEnabled")]
		public string MouseEnabled { get; set; }
		//[XmlAttribute(AttributeName = "targetType")]
		//public string TargetType { get; set; }
		//[XmlAttribute(AttributeName = "delay")]
		//public string Delay { get; set; }
		//[XmlAttribute(AttributeName = "time")]
		//public string Time { get; set; }
		//[XmlAttribute(AttributeName = "easing")]
		//public string Easing { get; set; }
		//[XmlAttribute(AttributeName = "fromXRad")]
		//public string FromXRad { get; set; }
		//[XmlAttribute(AttributeName = "toXRad")]
		//public string ToXRad { get; set; }
		//[XmlAttribute(AttributeName = "fromYRad")]
		//public string FromYRad { get; set; }
		//[XmlAttribute(AttributeName = "toYRad")]
		//public string ToYRad { get; set; }
		//[XmlAttribute(AttributeName = "fromRadius")]
		//public string FromRadius { get; set; }
		//[XmlAttribute(AttributeName = "toRadius")]
		//public string ToRadius { get; set; }
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
