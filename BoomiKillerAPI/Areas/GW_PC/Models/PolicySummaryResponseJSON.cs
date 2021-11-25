using BoomiKillerAPI.Areas.GW_PC.Helper;
using BoomiKillerAPI.PC_DevInt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class PolicySummaryResponseJSON
    {
        public string AccountNumber { get; set; }
        public List<Policy> Policies { get; set; }

        public PolicySummaryResponseJSON(AccountPolicySummary accountPolicySummary)
        {
            AccountNumber = accountPolicySummary.AccountNumber;
            MapPolicySummaries(accountPolicySummary.PolicySummaries);
        }

        private void MapPolicySummaries(PC_DevInt.PolicySummary[] policySummaries)
        {
            Policies = new List<Policy>();

            foreach(var policySummary in policySummaries)
            {
                var policy = new Policy();

                policy.AllCoverablesMapped = policySummary.AllCoverablesMapped;
                policy.AnnualPremium = new AnnualPremium().MapAnnualPremium(policySummary.PolicyPremiumProrated);
                //policy.Billing
                policy.CancellationDate = policySummary.CancellationDate;
                //policy.ClaimDraftsCount = policySummary.cl
                policy.CoverableSummary = MapCoverableSummary(policySummary.CoverableSummary);
                policy.ID = policySummary.ID;
                policy.Invoicing = Constants.fmgapi_undefined;
                policy.IsCancelled = policySummary.IsCancelled;
                //policy.Locations = MapLocations(policySummary.Locations);
                //policy.PaymentInstrument = MapPaymentInstrument(policySummary.PaymentInstrument);
                //policy.OfflineOpenWorkorderExists = CheckForOfflineOpenWorkorders(policySummary.PolicyNumber);
                policy.PaymentMade = Constants.fmgapi_undefined;
                policy.PeriodEnd = policySummary.PeriodEnd;
                policy.PeriodStart = policySummary.PeriodStart;
                policy.PolicyNumber = policySummary.PolicyNumber;
                policy.PolicyType = new TypeCodeSummary(policySummary.PolicyType);
                policy.ProducerCode = Constants.fmgapi_undefined;
                //policy.Renewal
                policy.SliceDate = policySummary.SliceDate;

                Policies.Add(policy);
            }
        }

        private bool? CheckForOfflineOpenWorkorders(string policyNumber)
        {
            throw new NotImplementedException();
        }

        private PaymentInstrument MapPaymentInstrument(PaymentUpdate paymentInstrument)
        {
            throw new NotImplementedException();
        }

        private List<PolicyLocationSummary> MapLocations(PC_DevInt.PolicyLocationSummary[] locations)
        {
            throw new NotImplementedException();
        }

        private List<PolicyCoverableSummary> MapCoverableSummary(PC_DevInt.PolicyCoverableSummary[] coverableSummary)
        {
            var policyCoverableItems = new List<PolicyCoverableSummary>();

            foreach(var coverable in coverableSummary)
            {
                var item = new PolicyCoverableSummary(coverable);

                policyCoverableItems.Add(item);
            }

            return policyCoverableItems;
        }

    }
}