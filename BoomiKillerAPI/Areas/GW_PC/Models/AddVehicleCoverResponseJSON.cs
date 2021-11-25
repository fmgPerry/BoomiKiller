using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class AddVehicleCoverResponseJSON
    {
        public AddVehicleCoverResponseJSON(PC_DevInt.AddVehicleDraftResponse addedVehicle, RedbookBand redbookBand)
        {
            JobID = addedVehicle.JobID;
            JobNumber = addedVehicle.JobNumber;
            JobStatus = addedVehicle.JobStatus;
            Coverable = new AddVehicleCoverResponse(addedVehicle.Vehicle, redbookBand);

        }

        public string JobID { get; set; }
        public string JobNumber { get; set; }
        public string JobStatus { get; set; }
        public AddVehicleCoverResponse Coverable { get; set; }
    }
}