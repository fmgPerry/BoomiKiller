namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class PaymentInstrument
    {
        public string BankAccountName { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public string DayOfMonth { get; set; }
        public string PaymentPlan { get; set; }
        public string PaymentType { get; set; }
    }
}