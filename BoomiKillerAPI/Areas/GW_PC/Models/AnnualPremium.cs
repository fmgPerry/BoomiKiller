using BoomiKillerAPI.PC_DevInt;
using System.Collections.Generic;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class AnnualPremium
    {
        public List<TypeCodeSummary> GSTandGovtLevies { get; set; }
        public string TotalAmount { get; set; }

        public AnnualPremium MapAnnualPremium(PremiumSummary policyPremiumProrated)
        {
            var ap = new AnnualPremium();
            ap.TotalAmount = policyPremiumProrated.TotalAmount;
            ap.GSTandGovtLevies = new List<TypeCodeSummary>();

            foreach (var ggl in policyPremiumProrated.GSTandGovtLevies)
            {
                ap.GSTandGovtLevies.Add(new TypeCodeSummary(ggl));
            }

            return ap;
        }
    }
}