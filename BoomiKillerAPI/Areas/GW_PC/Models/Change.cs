using System.Collections.Generic;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class Change
    {
        public string CoverEnd { get; set; }
        public string CoverStart { get; set; }
        public Coverable Coverable { get; set; }
        public AnnualPremium CoverablePremiumAnnualised { get; set; }
        public AnnualPremium CoverablePremiumProrated { get; set; }
        public string CoverableType { get; set; }
        public string DisplayName { get; set; }
        public string Line { get; set; }
        public List<PolicyLocationSummary> Locations { get; set; }
        public string PeriodEnd { get; set; }
        public string PeriodStart { get; set; }
        public string PolicyPeriodID { get; set; }
        public AnnualPremium PolicyPremiumProrated { get; set; }
        public string PolicyWordingCode { get; set; }
        public string PolicyWordingURL { get; set; }
        public int Term { get; set; }

    }
}