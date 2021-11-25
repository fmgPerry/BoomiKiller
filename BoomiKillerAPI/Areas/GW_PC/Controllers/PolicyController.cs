using BoomiKillerAPI.Areas.GW_PC.Helper;
using BoomiKillerAPI.PC_DevInt;
using System.Web.Http;
using System.Web.Http.Results;
using BoomiKillerAPI.Areas.GW_PC.Models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace BoomiKillerAPI.Areas.GW_PC.Controllers
{
    [RoutePrefix("ws/rest/Policy")]
    public class PolicyController : ApiController
    {
        private static FMGConnectServicePortTypeClient pcWebservice = new FMGConnectServicePortTypeClient("FMGConnectServiceSoap12Port");
        
        /// <summary>
        /// Only use this method to point to a particular GW env
        /// </summary>
        private static void SetWebserviceEndpointAddress()
        {
            var devintTinyUrl = "dev0164";
            var gwEnvTinyUrl = "eph0001:8180"; // set gw env you want to use
            
            var newEndPointAddress = pcWebservice.Endpoint.Address.ToString().Replace(devintTinyUrl, gwEnvTinyUrl);
            pcWebservice.Endpoint.Address = new System.ServiceModel.EndpointAddress(newEndPointAddress);            
        }

        [Route("Summary")]
        [HttpGet]
        public JsonResult<PolicySummaryResponseJSON> GetPolicySummary([FromUri(Name = "aid")] string accountNumber, [FromUri] string cid)
        {
            // Uncomment function below if not connecting to devint
            //SetWebserviceEndpointAddress();

            new SecretsReader().GetSecrets();

            var contactId = Obfuscation.ReverseObfuscate(cid);

            var policySummary = pcWebservice.getPolicySummary(
                authentication: new authentication { username = Constants.gwUsername, password = Constants.gwPassword },
                gw_language: null,
                gw_locale: null,
                accountNumber: accountNumber
                );

            var obfuscatedPolicySummary = Obfuscation.Obfuscate(policySummary);
            var result = new PolicySummaryResponseJSON(obfuscatedPolicySummary as AccountPolicySummary);

            return Json(result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

    }
}