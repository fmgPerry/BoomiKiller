using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class OptionalCover
    {
        public string ID { get; set; }
        public bool CoverTaken { get; set; }
        public string Code { get; set; }
        public string DisplayName { get; set; }
    }
}