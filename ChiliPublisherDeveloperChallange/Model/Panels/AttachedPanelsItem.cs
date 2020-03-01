using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
    public class AttachedPanelsItem
    {
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
		[XmlAttribute(AttributeName = "targetType")]
		public string TargetType { get; set; }

		[XmlElement(ElementName = "attachedPanels")]
		public AttachedPanelsItems AttachedPanelsItems { get; set; }

	}
}