using BoomiKillerAPI.Areas.GW_PC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC.Helper
{
    public class FVRC
    {
        public static RedbookBand GetRedbookband(string rego)
        {
            // todo: call to FVRC using rego

            var rb = new RedbookBand();
            rb.Band = "band3";
            rb.Max = "20000";
            rb.Median = "18000";
            rb.Min = "15000";
            return rb;
        }
    }
}