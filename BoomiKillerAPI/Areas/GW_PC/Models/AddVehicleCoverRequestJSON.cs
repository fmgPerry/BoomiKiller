using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class AddVehicleCoverRequestJSON
    {
        public string AsOfDate { get; set; }
        public string PolicyNumber { get; set; }
        public VehicleCriteria VehicleCriteria { get; set; }
    }

    public class VehicleCriteria
    {
        public string CCRating { get; set; }
        public Driver Driver { get; set; }
        public string EngineType { get; set; }
        public string GrossLadenWeight { get; set; }
        public Models.TypeCodeSummary InsuredEvent { get; set; }
        public LocationJSON Location { get; set; }
        public int LocationID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string NZTAUsage { get; set; }
        public string Registration { get; set; }
        public string SerialNumber { get; set; }
        public string VIN { get; set; }
        public string Variant { get; set; }
        public int MyProperty { get; set; }
        public Models.TypeCodeSummary CoverableSubType { get; set; }
        public string Year { get; set; }
        public string SumInsured { get; set; }
        public string Classification { get; set; }

    }
    public class Driver
    {
        public string ID { get; set; }
        public string DriverLicenceNumber { get; set; }
        public string DriverLicenceType { get; set; }
        public string DateOfBirth { get; set; }
    }
    public class LocationJSON
    {

    }
}