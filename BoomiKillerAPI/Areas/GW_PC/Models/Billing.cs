namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class Billing
    {
        public string ID { get; set; }
        public Invoice Invoice { get; set; }
        public string PaymentAccount { get; set; }
        public string PaymentPlan { get; set; }
        public string PaymentType { get; set; }
        public bool? PaymentsOutStanding { get; set; }
        public string ShareholderNo { get; set; }
        public bool? CanEditPayment { get; set; }
    }
}