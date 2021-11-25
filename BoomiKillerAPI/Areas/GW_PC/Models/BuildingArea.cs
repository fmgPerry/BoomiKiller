namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class BuildingArea
    {
        public string Area { get; set; }
        public string BelongsToID { get; set; }
        public string ID { get; set; }
        public bool? IsDomesticUnit { get; set; }
        public TypeCodeSummary Type { get; set; }
        public string Year { get; set; }


    }
}