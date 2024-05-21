using System.Xml.Serialization;

namespace TwitchDownloaderMauiApp.Models;

public class BooleanModel
{
    [XmlRoot(ElementName = "Boolean")]
    public class BooleanModel
    {
        [XmlAttribute(AttributeName = "Key")]
        public string Key { get; set; }

        [XmlText(Type = typeof(bool))]
        public bool Value { get; set; }
    }
}