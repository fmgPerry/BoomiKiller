using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class PolicyChangeRequestJSON
    {
        public PolicyChange PolicyChange { get; set; }
    }
    public class PolicyChange
    {
        //public DomesticBuildings DomesticBuildings { get; set; }
        //public HouseholdContents HouseholdContents { get; set; }
        public PrivateVehicle[] Vehicles { get; set; }
        public string JobID { get; set; }
    }
    public class PrivateVehicle
    {
        public AccessoryAndModification[] AccessoriesAndModifications { get; set; }
        public BaseCoverJSON BaseCover { get; set; }
        public TypeCodeSummary CoverableSubType { get; set; }
        public string EffectiveDate { get; set; }
        public string ID { get; set; }
        public string FixedId { get; set; }
        public ImposedTerm[] ImposedTerms { get; set; }
        public LocationJSON Location { get; set; }
        public string LocationID { get; set; }
        public string MainDriver { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string[] NamedDrivers{ get; set; }
        public OptionalCover[] OptionalCovers { get; set; }
        public string Plate { get; set; }
        public Models.TypeCodeSummary PolicyWording { get; set; }
        public string Year { get; set; }

    }
    //public class AccessoriesAndModification
    //{
    //    public string ID { get; set; }
    //    public string Details { get; set; }
    //    public string Value { get; set; }
    //    public Models.TypeCodeSummary Type{ get; set; }
    //}
}