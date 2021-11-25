using System.Xml.Serialization;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class Vehicle
    {
        [XmlElement(ElementName = "VehicleSystemId", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string VehicleSystemId { get; set; }
        [XmlElement(ElementName = "YearOfManufacture", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public int YearOfManufacture { get; set; }
        [XmlElement(ElementName = "Make", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string Make { get; set; }
        [XmlElement(ElementName = "Model", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string Model { get; set; }
        [XmlElement(ElementName = "SubModel", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string SubModel { get; set; }
        [XmlElement(ElementName = "BodyStyle", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public DescriptionCode BodyStyle { get; set; }
        [XmlElement(ElementName = "VehicleType", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public DescriptionCode VehicleType { get; set; }
        [XmlElement(ElementName = "VIN", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string VIN { get; set; }
        [XmlElement(ElementName = "ChassisNumber", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string ChassisNumber { get; set; }
        [XmlElement(ElementName = "BasicColour", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string BasicColour { get; set; }
        [XmlElement(ElementName = "ReportedStolen", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public bool ReportedStolen { get; set; }
        [XmlElement(ElementName = "EngineNumber", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string EngineNumber { get; set; }
        [XmlElement(ElementName = "CCRating", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public int CCRating { get; set; }
        [XmlElement(ElementName = "Power", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public int Power { get; set; }
        [XmlElement(ElementName = "CountryOfOrigin", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public DescriptionCode CountryOfOrigin { get; set; }
        [XmlElement(ElementName = "PreviousCountryOfRegistration", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public DescriptionCode PreviousCountryOfRegistration { get; set; }
        [XmlElement(ElementName = "AssemblyType", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public DescriptionCode AssemblyType { get; set; }
        [XmlElement(ElementName = "GrossVehicleMass", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public int GrossVehicleMass { get; set; }
        [XmlElement(ElementName = "NumberOfSeats", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public int NumberOfSeats { get; set; }
        [XmlElement(ElementName = "FuelType", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public DescriptionCode FuelType { get; set; }
        [XmlElement(ElementName = "ReliableOdometer", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public bool ReliableOdometer { get; set; }
        [XmlElement(ElementName = "MaximumRatedTowedMassForUnbrakedTrailer", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string MaximumRatedTowedMassForUnbrakedTrailer { get; set; }
        [XmlElement(ElementName = "MaximumRatedTowedMassForBrakedTrailer", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string MaximumRatedTowedMassForBrakedTrailer { get; set; }
        [XmlElement(ElementName = "NumberOfAxles", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string NumberOfAxles { get; set; }
        [XmlElement(ElementName = "AxleType", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public DescriptionCode AxleType { get; set; }
        [XmlElement(ElementName = "WheelBase", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string WheelBase { get; set; }
        [XmlElement(ElementName = "DateOfFirstNZRegistration", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string DateOfFirstNZRegistration { get; set; }
        [XmlElement(ElementName = "CauseOfLatestRegistration", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public DescriptionCode CauseOfLatestRegistration { get; set; }
        [XmlElement(ElementName = "SubjectToWOF", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public bool SubjectToWOF { get; set; }
        [XmlElement(ElementName = "SubjectToCOF", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public bool SubjectToCOF { get; set; }
        [XmlElement(ElementName = "SubjectToRUC", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public bool SubjectToRUC { get; set; }
        [XmlElement(ElementName = "DateOfLastRegistration", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string DateOfLastRegistration { get; set; }
        [XmlElement(ElementName = "CurrentVehicleOdometerUnit", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public string CurrentVehicleOdometerUnit { get; set; }
        [XmlElement(ElementName = "ImportedDamaged", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public bool ImportedDamaged { get; set; }
        [XmlElement(ElementName = "RegisteredOverseas", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public bool RegisteredOverseas { get; set; }
        [XmlElement(ElementName = "DateOfFirstRegistrationOverseas", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public DateOfFirstRegistrationOverseas DateOfFirstRegistrationOverseas { get; set; }
        [XmlArray(ElementName = "VehicleUsages", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public VehicleUsage[] VehicleUsages { get; set; }
        [XmlElement(ElementName = "VehicleRegistrationStatus", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public DescriptionCode VehicleRegistrationStatus { get; set; }
        [XmlArray(ElementName = "Plates", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public Plate[] Plates { get; set; }
        [XmlArray(ElementName = "Inspections", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public Inspection[] Inspections { get; set; }
        [XmlArray(ElementName = "MvrLicences", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public MvrLicence[] MvrLicences { get; set; }
        [XmlArray(ElementName = "OdometerReadings", Namespace = "http://localhost/Schema/CdiCommonTypes")]
        public OdometerReading[] OdometerReadings { get; set; }
    }

    public class DateOfFirstRegistrationOverseas
    {
        public int Year { get; set; }
        public int Month { get; set; }
        [XmlElement(ElementName = "Day", IsNullable = true)]
        public int? Day { get; set; }


    }
    public class Inspection
    {
        [XmlAttribute(AttributeName = "Latest")]
        public bool Latest { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public DescriptionCode Result { get; set; }
        public string ExpiryDate { get; set; }
        public string BTN { get; set; }
    }
    public class MvrLicence
    {
        public string Number { get; set; }
        [XmlElement(ElementName = "LicenceType")]
        public DescriptionCode LicenceType { get; set; }
        public bool ContinuousLicence { get; set; }
        public string ExpiryDate { get; set; }
        public string IssueDateTime { get; set; }
    }
    public class OdometerReading
    {
        public int Reading { get; set; }
        public string ReadingDate { get; set; }
        public DescriptionCode Unit { get; set; }
        public DescriptionCode Source { get; set; }
    }
    public class Plate
    {
        [XmlAttribute]
        public string PlateStatus { get; set; }
        public string PlateNumber { get; set; }
        [XmlElement(ElementName = "PlateType")]
        public DescriptionCode PlateType { get; set; }
        public string EffectiveDate { get; set; }

    }
    public class VehicleUsage
    {
        public DescriptionCode VehicleUsageCode { get; set; }
    }
}