using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC
{
    [DataContract]
    public partial class RegistrationLookupResponse
    {

        
        [DataMember]
        public bool ResultFound { get; set; }
        [DataMember] 
        public Result Result { get; set; }
    }
    [DataContract]
    public class RecommendedSumInsured
    {
        [DataMember]
        public decimal RecommendedMin { get; set; }
        [DataMember] 
        public decimal RecommendedMax { get; set; }
    }
    [DataContract]
    public class Result
    {
        [DataMember]
        public string Make { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public int? Year { get; set; }
        [DataMember]
        public string Variant { get; set; }
        [DataMember]
        public int? CCRating { get; set; }
        [DataMember]
        public string InductionType { get; set; }
        [DataMember]
        public string FuelType { get; set; }
        [DataMember]
        public int? Power { get; set; }
        [DataMember]
        public string EngineType { get; set; }
        [DataMember]
        public decimal PerformanceFactor { get; set; }
        [DataMember]
        public decimal MaintenanceFactor { get; set; }
        [DataMember]
        public decimal TheftFactor { get; set; }
        [DataMember]
        public string Classification { get; set; }
        [DataMember]
        public string DateCreated { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string FullDesc { get; set; }
        [DataMember]
        public int? GrossLadenWeight { get; set; }
        [DataMember]
        public string UsageBodyStyleDesc { get; set; }
        [DataMember]
        public decimal? RecommendedMin { get; set; }
        [DataMember]
        public decimal? RecommendedMax { get; set; }
        [DataMember]
        public bool VehicleUWRequired { get; set; }
        [DataMember]
        public string UsageType { get; set; }
        [DataMember]
        public string VIN { get; set; }

        [DataMember]
        public string Registration { get; set; }
    }
}