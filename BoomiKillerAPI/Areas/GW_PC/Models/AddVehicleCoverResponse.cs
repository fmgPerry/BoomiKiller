namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class AddVehicleCoverResponse : PolicyCoverableItem
    {
        public AddVehicleCoverResponse(PC_DevInt.PolicyCoverableItem vehicle, RedbookBand redbookBand) : base(vehicle)
        {
            //Band = redbookBand.Band;
            ////Min = redbookBand.Min;
            ////Max = redbookBand.Max;
            //Median = redbookBand.Median;

        }

        //public string Band { get; set; }
        ////public string Min { get; set; }
        ////public string Max { get; set; }
        //public string Median { get; set; }
    }
}