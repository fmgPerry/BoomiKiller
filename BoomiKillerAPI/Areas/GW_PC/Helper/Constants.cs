using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC.Helper
{
    public class Constants
    {
        public static string fmgapi_undefined = "fmgapi_undefined";
        
        public static string gwUsername { get; set; }
        public static string gwPassword { get; set; }
        public static string secretKeyValue { get; set; }

    }
}