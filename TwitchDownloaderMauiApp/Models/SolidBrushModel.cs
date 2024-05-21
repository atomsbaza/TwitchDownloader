using System.Xml.Serialization;

namespace TwitchDownloaderMauiApp.Models;

public class SolidBrushModel
{
    [XmlRoot(ElementName = "SolidColorBrush")]
    public class SolidColorBrushModel
    {
        [XmlAttribute(AttributeName = "Key")]
        public string Key { get; set; }

        [XmlAttribute(AttributeName = "Color")]
        public string Color { get; set; }
    }
}