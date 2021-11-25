using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using BoomiKillerAPI.PC_DevInt;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    [DataContract]
    public class Coverable
    {


        [DataMember] 
        public string ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string SubType { get; set; }
        [DataMember]
        public string  BasisOfSettlement { get; set; }
        [DataMember]
        public string InsuredEvent { get; set; }
        [DataMember]
        public string PolicyWording { get; set; }
        [DataMember]
        public decimal SumInsured { get; set; }
        [DataMember]
        public decimal Excess { get; set; }

        public Coverable(PolicyCoverableSummary coverable)
        {
            ID = coverable.ID;
            Name = coverable.DisplayName;
            Type = coverable.CoverableType;
            SubType = coverable.CoverableSubType.DisplayName;
            BasisOfSettlement = coverable.BasisOfSettlement;
            InsuredEvent = coverable.InsuredEvent.DisplayName;
            PolicyWording = coverable.PolicyWording.DisplayName;
            SumInsured = Convert.ToDecimal(coverable.SumInsured);
            Excess = Convert.ToDecimal(coverable.Excess.Value);

        }

    }
}