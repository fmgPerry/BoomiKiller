using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class PolicyCoverableSummary : PolicyCoverableItem
    {
        public PolicyCoverableSummary(PC_DevInt.PolicyCoverableSummary item) : base(item)
        {
            AnnualPremium = item.CoverablePremiumProrated;
            BasisOfSettlement = item.BasisOfSettlement;
            CoverableType = item.CoverableType;
            CoverClaimableFrom = item.CoverClaimableFrom;
            CoverEnd = item.CoverEnd;
            CoverStart = item.CoverStart;
            DisplayName = item.DisplayName;
            InsuredEvent = new TypeCodeSummary(item.InsuredEvent);
            PolicyWordingUrl = GetPolicyWordingUrl(item.PolicyWording);
            SumInsured = item.SumInsured;
            SumInsuredGSTIncl = AddGST(item.SumInsured);
            Term = item.Term;
            
        }

        private string AddGST(string sumInsured)
        {
            decimal.TryParse(sumInsured, out decimal si);
            decimal siGst = decimal.Round(si * 1.15M, 2);

            return siGst.ToString();
        }

        private string GetPolicyWordingUrl(PC_DevInt.TypeCodeSummary policyWording)
        {
            // write code to make the call to Redis to get the url
            return $@"PolicyWordingUrl for {policyWording.DisplayName}";
        }

        public string AnnualPremium { get; set; }
        public string BasisOfSettlement { get; set; }
        public string CoverableType { get; set; }
        public string CoverClaimableFrom { get; set; }
        public string CoverEnd { get; set; }
        public string CoverStart { get; set; }
        public string DisplayName { get; set; }
        public TermValue Excess { get; set; }
        public TypeCodeSummary InsuredEvent { get; set; }
        public string PolicyWordingUrl { get; set; }
        public string SumInsured { get; set; }
        public string SumInsuredGSTIncl { get; set; }
        public int Term { get; set; }
    }
}