using System.Xml.Serialization;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class DescriptionCode
    {
        [XmlAttribute]
        public string Description { get; set; }
        [XmlText]
        public string Code { get; set; }
    }

}