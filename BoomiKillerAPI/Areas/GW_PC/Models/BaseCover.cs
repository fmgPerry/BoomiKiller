using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class BaseCover
    {
        public TypeCodeSummary InsuredEvent { get; set; }
        public string BasisOfSettlement { get; set; }
        public string SumInsured { get; set; }
        public TermValue Excess { get; set; }
        public bool NaturalDisasterIncluded { get; set; }
        public List<CoverExcess> ExcessTypes { get; set; }
    }
}