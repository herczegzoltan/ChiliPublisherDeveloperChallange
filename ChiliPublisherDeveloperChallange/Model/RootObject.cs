using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChiliPublisherDeveloperChallange.Model
{
    [XmlRoot(ElementName = "folding")]
	public class RootObject
	{
		[XmlAttribute(AttributeName = "enableEffects")]
		public string EnableEffects { get; set; }

		[XmlAttribute(AttributeName = "debugMode")]
		public string DebugMode { get; set; }

		[XmlAttribute(AttributeName = "showStats")]
		public string ShowStats { get; set; }

		[XmlAttribute(AttributeName = "calculatePanelCollisions")]
		public string CalculatePanelCollisions { get; set; }

		[XmlAttribute(AttributeName = "allowMouseInteraction")]
		public string AllowMouseInteraction { get; set; }

		[XmlAttribute(AttributeName = "adjustCameraTargetPosition")]
		public string AdjustCameraTargetPosition { get; set; }

		[XmlAttribute(AttributeName = "freeCamera")]
		public string FreeCamera { get; set; }

		[XmlAttribute(AttributeName = "startPosition")]
		public string StartPosition { get; set; }

		[XmlAttribute(AttributeName = "initialCameraX")]
		public string InitialCameraX { get; set; }

		[XmlAttribute(AttributeName = "initialCameraY")]
		public string InitialCameraY { get; set; }

		[XmlAttribute(AttributeName = "show3DStats")]
		public string Show3DStats { get; set; }

		[XmlAttribute(AttributeName = "backgroundColor")]
		public string BackgroundColor { get; set; }

		[XmlAttribute(AttributeName = "rootX")]
		public string RootX { get; set; }

		[XmlAttribute(AttributeName = "rootY")]
		public string RootY { get; set; }

		[XmlAttribute(AttributeName = "originalDocumentHeight")]
		public string OriginalDocumentHeight { get; set; }

		[XmlAttribute(AttributeName = "originalDocumentWidth")]
		public string OriginalDocumentWidth { get; set; }

		[XmlAttribute(AttributeName = "initialCameraRadius")]
		public string InitialCameraRadius { get; set; }

		[XmlAttribute(AttributeName = "iconSetID")]
		public string IconSetID { get; set; }

		[XmlAttribute(AttributeName = "autoPlaySequence")]
		public string AutoPlaySequence { get; set; }

		[XmlAttribute(AttributeName = "loopSequence")]
		public string LoopSequence { get; set; }

		[XmlAttribute(AttributeName = "initialCameraTargetX")]
		public string InitialCameraTargetX { get; set; }

		[XmlAttribute(AttributeName = "initialCameraTargetY")]
		public string InitialCameraTargetY { get; set; }

		[XmlAttribute(AttributeName = "initialCameraTargetZ")]
		public string InitialCameraTargetZ { get; set; }


		[XmlElement(ElementName = "lights")]
		public Lights Lights { get; set; }

		[XmlElement(ElementName = "materials")]
		public Materials Materials { get; set; }

		//[XmlElement(ElementName = "panels")]
		//public Panels Panels { get; set; }

		[XmlElement(ElementName = "sequences")]
		public Sequences Sequences { get; set; }
	}
}
