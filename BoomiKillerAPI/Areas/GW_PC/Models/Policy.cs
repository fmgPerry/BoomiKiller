using System.Collections.Generic;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class Policy
    {
        public bool? AllCoverablesMapped { get; set; }
        public AnnualPremium AnnualPremium{ get; set; }
        public Billing Billing { get; set; }
        public string CancellationDate { get; set; }
        public int? ClaimDraftsCount { get; set; }
        public List<PolicyCoverableSummary> CoverableSummary { get; set; } //
        public string ID { get; set; }
        public string Invoicing { get; set; }
        public bool? IsCancelled { get; set; }
        public List<PolicyLocationSummary> Locations { get; set; }
        public PaymentInstrument PaymentInstrument { get; set; }
        public bool? OfflineOpenWorkorderExists { get; set; }
        public string PaymentMade { get; set; }
        public string PeriodEnd { get; set; }
        public string PeriodStart { get; set; }
        public string PolicyNumber { get; set; }
        public TypeCodeSummary PolicyType { get; set; }
        public string ProducerCode { get; set; }
        public string Renewal { get; set; } //
        public string SliceDate { get; set; }

    }
}