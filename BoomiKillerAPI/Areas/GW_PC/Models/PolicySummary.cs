using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using BoomiKillerAPI.PC_DevInt;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    [DataContract]
    public class PolicySummary
    {
        [DataMember]
        public int PolicyNumber { get; set; }
        [DataMember]
        public string PolicyType { get; set; }
        [DataMember]
        public DateTime PeriodStart { get; set; }
        [DataMember]
        public DateTime PeriodEnd { get; set; }
        [DataMember]
        public List<Coverable> Coverables { get; set; }


        public PolicySummary(AccountPolicySummary ss)
        {
            var policySummary = ss.PolicySummaries.FirstOrDefault();
            PolicyNumber = Convert.ToInt32(policySummary.PolicyNumber);
            PolicyType = policySummary.PolicyType.DisplayName;
            PeriodStart = Convert.ToDateTime(policySummary.PeriodStart);
            PeriodEnd = Convert.ToDateTime(policySummary.PeriodEnd);
            //Coverables = GetCoverables(policySummary.CoverableSummary);
        }

        private List<Coverable> GetCoverables(PolicyCoverableSummary[] coverableSummary)
        {
            var coverables = new List<Coverable>();
            foreach (var coverable in coverableSummary)
            {
                coverables.Add(new Coverable(coverable));
            }
            return coverables;
        }

        

    }
}