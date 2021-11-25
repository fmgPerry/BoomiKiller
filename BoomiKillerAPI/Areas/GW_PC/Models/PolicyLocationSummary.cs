using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class PolicyLocationSummary
    {
        public string ID { get; set; }
        public bool? IsPrimary { get; set; }
        public string CareOfName { get; set; }
        public string PropertyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }  // esam city also same(this is Accountlocation city)
        public string PostCode { get; set; }
        public string Country { get; set; }
        //esam fields  
        public int? UniqueID { get; set; }
        public int? SourceID { get; set; }
        public string SourceDesc { get; set; }
        public int? DPID { get; set; }
        public string AddressType_fmg { get; set; }
        public decimal? NztmXcoord { get; set; }
        public decimal? NztmYcoord { get; set; }
        public decimal? Gd2kXcoord { get; set; }
        public decimal? Gd2kYcoord { get; set; }
        public decimal? NzmgXcoord { get; set; }
        public decimal? NzmgYcoord { get; set; }
        public int? Meshblock { get; set; }
        public decimal? ParcelId { get; set; }
    }
}