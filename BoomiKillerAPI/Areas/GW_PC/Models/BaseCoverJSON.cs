namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class BaseCoverJSON
    {
        public string BasisOfSettlement { get; set; }
        public Excess Excess { get; set; }
        public ExcessType[] ExcessTypes { get; set; }
        public Models.TypeCodeSummary InsuredEvent { get; set; }
        public string NaturalDisasterIncluded { get; set; }
        public string SumInsured { get; set; }
        public string SumInsuredGSTIncl { get; set; }
    }
}