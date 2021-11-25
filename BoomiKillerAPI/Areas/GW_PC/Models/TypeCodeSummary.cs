using BoomiKillerAPI.Areas.GW_PC.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC.Models
{
    public class TypeCodeSummary
    {
        
        public TypeCodeSummary()
        {
        }

        public TypeCodeSummary(PC_DevInt.TypeCodeSummary typeCodeSummary)
        {
            if (typeCodeSummary == null)
            {
                Code = Constants.fmgapi_undefined;
            }
            else
            {
                Code = typeCodeSummary.Code;
                DisplayName = typeCodeSummary.DisplayName;
            }
        }

        public string Code { get; set; }
        public string DisplayName { get; set; }
    }
}