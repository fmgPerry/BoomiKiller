namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class Invoice
    {
        public string AmountDue { get; set; }
        public string Overdue { get; set; }
        public string PaymentDueDate { get; set; }
        public string Status { get; set; }
    }
}