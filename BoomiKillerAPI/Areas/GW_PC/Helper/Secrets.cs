using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace BoomiKillerAPI.Areas.GW_PC.Helper
{
    public class Secrets
    {
        public GW gw { get; set; }
        public SecretKeyValue secretKeyValue { get; set; }

    }

    public class SecretKeyValue
    {
        public string test { get; set; }
        public string preProd { get; set; }
        public string prod { get; set; }
    }

    public class GW
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
