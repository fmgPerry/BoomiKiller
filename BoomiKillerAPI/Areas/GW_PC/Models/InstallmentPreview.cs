namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class Installment
    {
        public string AmountDue { get; set; }
        public string ID { get; set; }
        public bool? OverDue  { get; set; }
        public string PaymentDueDate { get; set; }
        public string PaymentPlan { get; set; }
    }
}