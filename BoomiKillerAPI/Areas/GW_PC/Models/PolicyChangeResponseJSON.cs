using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BoomiKillerAPI.PC_DevInt;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class PolicyChangeResponseJSON
    {
        public string ChangeInCost { get; set; }
        public List<Change> Changes{ get; set; }
        public List<Installment> InstallmentPreviews { get; set; }
        public string JobID { get; set; }
        public string JobNumber { get; set; }
        public string JobStatus { get; set; }
        public Installment NextInstallment { get; set; }
        public PaymentEstimate PaymentEstimate { get; set; }
        public AnnualPremium PolicyPremiumProrated { get; set; }


        public PolicyChangeResponseJSON(PolicyChangeResponse policyChangeResponse)
        {
            ChangeInCost = policyChangeResponse.ChangeInCost;
            Changes = MapChanges(policyChangeResponse.CoverablesChanged);
            InstallmentPreviews = MapInstallmentPreviews(policyChangeResponse.InstallmentPreview);
            JobID = policyChangeResponse.JobID;
            JobNumber = policyChangeResponse.JobNumber;
            JobStatus = policyChangeResponse.JobStatus;
            NextInstallment = MapInstallment(policyChangeResponse.NextInstallment);
            PaymentEstimate = MapPaymentEstimate(policyChangeResponse.PaymentEstimate);
            PolicyPremiumProrated = MapPolicyPremiumProrated(policyChangeResponse.PolicyPremiumProrated);


        }

        private AnnualPremium MapPolicyPremiumProrated(PremiumSummary premiumSummary)
        {
            return new AnnualPremium().MapAnnualPremium(premiumSummary);
        }

        private PaymentEstimate MapPaymentEstimate(PaymentPlanSummary paymentPlanSummary)
        {
            var paymentEstimate = new PaymentEstimate();

            paymentEstimate.PaymentFrequency = paymentPlanSummary.PaymentFrequency;
            paymentEstimate.PaymentPerFrequency = paymentPlanSummary.PaymentPerFrequency;

            return paymentEstimate;
        }

        private List<Installment> MapInstallmentPreviews(BillingInvoiceSummary[] installmentPreviews)
        {
            var installments = new List<Installment>();

            foreach(var installmentPreview in installmentPreviews)
            {
                var installment = new Installment();
                
                installment.AmountDue = installmentPreview.AmountDue;
                installment.ID = installmentPreview.ID;
                installment.OverDue = installmentPreview.OverDue;
                installment.PaymentDueDate = installmentPreview.PaymentDueDate;
                installment.PaymentPlan = installmentPreview.PaymentPlan;

                installments.Add(installment);
            }

            return installments;
        }

        private Installment MapInstallment(BillingInvoiceSummary billingInvoiceSummary)
        {
            var installment = new Installment();
            
            installment.AmountDue = billingInvoiceSummary.AmountDue;
            installment.ID = billingInvoiceSummary.ID;
            installment.OverDue = billingInvoiceSummary.OverDue;
            installment.PaymentDueDate = billingInvoiceSummary.PaymentDueDate;
            installment.PaymentPlan = billingInvoiceSummary.PaymentPlan;
            
            return installment;
        }

        private List<Change> MapChanges(PolicyCoverable[] coverablesChanged)
        {
            var changes = new List<Change>();

            foreach(var coverableChanged in coverablesChanged)
            {
                var change = new Change();
                //change.Coverable = coverableChanged.Coverable;
                change.CoverablePremiumAnnualised = new AnnualPremium().MapAnnualPremium(coverableChanged.CoverablePremiumAnnualised);
                change.CoverablePremiumProrated = new AnnualPremium().MapAnnualPremium(coverableChanged.CoverablePremiumProrated);
                change.CoverableType = coverableChanged.CoverableType;
                change.CoverEnd = coverableChanged.CoverEnd;
                change.CoverStart = coverableChanged.CoverStart;
                change.DisplayName = coverableChanged.DisplayName;
                change.Line = coverableChanged.Line;
                //change.Locations
                change.PeriodEnd = coverableChanged.PeriodEnd;
                change.PeriodStart = coverableChanged.PeriodStart;
                change.PolicyPeriodID = coverableChanged.PolicyPeriodID;
                change.PolicyPremiumProrated = new AnnualPremium().MapAnnualPremium(coverableChanged.PolicyPremiumProrated);
                change.PolicyWordingCode = coverableChanged.PolicyWordingCode;
                //change.PolicyWordingURL = 
                change.Term = coverableChanged.Term;

                changes.Add(change);
            }

            return changes;
        }

    }
}