using System.Xml.Serialization;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class NZTAResponse
    {
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body Body { get; set; }
    }
    public class Body
    {
        [XmlElement(ElementName = "InquireVehicleDetailsResponse", Namespace = "http://schemas.cdi.ltsa.govt.nz/Vehicle/Vehicle/")]
        public InquireVehicleDetailsResponse InquireVehicleDetailsResponse { get; set; }
    }
    public class InquireVehicleDetailsResponse
    {
        [XmlElement(ElementName = "InquireVehicleDetailsResult", Namespace = "http://localhost/Schema/VehicleTypes")]
        public InquireVehicleDetailsResult InquireVehicleDetailsResult { get; set; }
    }
    public class InquireVehicleDetailsResult
    {
        [XmlElement(ElementName = "ServiceHeader", Namespace = "http://localhost/Schema/CdiServiceTypes")]
        public ServiceHeader ServiceHeader { get; set; }
        [XmlElement(ElementName = "ResponseBody")]
        public ResponseBody ResponseBody { get; set; }
    }
    public class ServiceHeader
    {
        [XmlElement(ElementName = "Identification")]
        public Identification Identification { get; set; }
    }
    public class Identification
    {
        [XmlElement(ElementName = "CdiReference")]
        public CdiReference CdiReference { get; set; }
    }
    public class CdiReference
    {
        [XmlElement(ElementName = "MessageId")]
        public string MessageId { get; set; }
        //public int MyProperty { get; set; }
    }
    public class ResponseBody
    {
        [XmlElement(ElementName = "ResponseDetail")]
        public ResponseDetail ResponseDetail { get; set; }
    }
    public class ResponseDetail
    {
        [XmlAttribute(AttributeName = "ResponseType")]
        public string ResponseType { get; set; }
        [XmlElement(ElementName = "RequestDetail")]
        public RequestDetail RequestDetail { get; set; }
        [XmlElement(ElementName = "Vehicle")]
        public Vehicle Vehicle { get; set; }
    }
    public class RequestDetail
    {
        [XmlElement(ElementName = "Plate", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public Plate Plate { get; set; }
    }
}