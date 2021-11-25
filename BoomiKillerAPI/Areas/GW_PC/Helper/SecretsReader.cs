using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace BoomiKillerAPI.Areas.GW_PC.Helper
{
    public class SecretsReader
    {
        public void GetSecrets()
        {
            if (Constants.gwUsername == null || Constants.gwPassword == null || Constants.secretKeyValue == null)
            {
                var secretsPath = AppDomain.CurrentDomain.BaseDirectory + @"bin\Secrets.json";
                var jsonfile = File.ReadAllText(secretsPath);
                var secrets = JsonConvert.DeserializeObject<Secrets>(jsonfile);

                Constants.gwUsername = secrets.gw.username;
                Constants.gwPassword = secrets.gw.password;
                Constants.secretKeyValue = secrets.secretKeyValue.test;
            }

        }
    }
}