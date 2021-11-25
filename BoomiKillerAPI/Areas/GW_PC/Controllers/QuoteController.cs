using BoomiKillerAPI.Areas.GW_PC.Helper;
using BoomiKillerAPI.Areas.GW_PC.Models;
using BoomiKillerAPI.PC_DevInt;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace BoomiKillerAPI.Areas.GW_PC.Controllers
{
    [RoutePrefix("ws/rest")]
    public class QuoteController : ApiController
    {
        private static FMGConnectServicePortTypeClient pcWebservice = new FMGConnectServicePortTypeClient("FMGConnectServiceSoap12Port");

        /// <summary>
        /// Only use this method to point to a particular GW env
        /// </summary>
        private static void SetWebserviceEndpointAddress()
        {
            var devintTinyUrl = "dev0164";
            var gwEnvTinyUrl = "eph0001:8180"; // set gw env

            var newEndPointAddress = pcWebservice.Endpoint.Address.ToString().Replace(devintTinyUrl, gwEnvTinyUrl);
            pcWebservice.Endpoint.Address = new System.ServiceModel.EndpointAddress(newEndPointAddress);
        }


        [Route("Quotes")]
        [HttpPost]
        public JsonResult<PolicyChangeResponseJSON> Quote([FromUri] string aid, [FromUri] string cid, [FromUri(Name = "pid")] string policyNumber, [FromBody] PolicyChangeRequestJSON policyChangeRequestJSON)
        {
            var contactId = Obfuscation.ReverseObfuscate(cid);

            policyChangeRequestJSON = Obfuscation.ReverseObfuscate(policyChangeRequestJSON) as PolicyChangeRequestJSON;
            var jobId = policyChangeRequestJSON.PolicyChange.JobID;

            var quote = QuotePolicyChange(contactId, policyNumber, jobId, policyChangeRequestJSON);
            var obfuscatedObject = Obfuscation.Obfuscate(quote);
            var obfuscatedQuote = obfuscatedObject as PolicyChangeResponse;
            var result = new PolicyChangeResponseJSON(obfuscatedQuote);

            return Json(result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        private PolicyChangeResponse QuotePolicyChange(string contactId, string policyNumber, string jobId, PolicyChangeRequestJSON policyChangeRequestJSON)
        {
            // Uncomment function below if not connecting to devint
            //SetWebserviceEndpointAddress();

            new SecretsReader().GetSecrets();

            var policyChange = GetPolicyChange(policyChangeRequestJSON);

            return pcWebservice.requestPolicyChange(
                            authentication: new authentication { username = Constants.gwUsername, password = Constants.gwPassword },
                                        gw_language: null,
                                        gw_locale: null,
                                        contactID: contactId,
                                        policyNumber: policyNumber,
                                        jobID: jobId,
                                        policyChange: policyChange,
                                        asAtDate: null
                                        );
        }

        private FMGConnectPolicyChange GetPolicyChange(PolicyChangeRequestJSON policyChangeRequestJSON)
        {
            var changeVehicles = policyChangeRequestJSON.PolicyChange.Vehicles;


            var policyChange = new FMGConnectPolicyChange();
            policyChange.Vehicles = new VehicleUpdate[changeVehicles.Count()];
            for (int i = 0; i < changeVehicles.Count(); i++)
            {
                var vehicle = MapVehicleChanges(changeVehicles[i]);
                policyChange.Vehicles[i] = (VehicleUpdate)vehicle;
            }

            return policyChange;
        }

        private PC_DevInt.PolicyCoverableItem MapVehicleChanges(PrivateVehicle privateVehicle)
        {
            var vehicle = new PC_DevInt.PolicyCoverableItem();
            vehicle.AccessoriesAndModifications = MapAccessoriesAndModifications(privateVehicle?.AccessoriesAndModifications);
            vehicle.BaseCover = MapBaseCover(privateVehicle?.BaseCover);
            vehicle.CoverableSubType = MapTypeCodeSummary(privateVehicle?.CoverableSubType);
            vehicle.EffectiveDate = privateVehicle.EffectiveDate;
            vehicle.FixedID = privateVehicle.FixedId;
            vehicle.ID = privateVehicle.ID;
            vehicle.ImposedTerms = MapImposedTerms(privateVehicle?.ImposedTerms);
            vehicle.LocationID = privateVehicle?.LocationID;
            vehicle.MainDriver = privateVehicle.MainDriver;
            vehicle.Make = privateVehicle?.Make;
            vehicle.Model = privateVehicle?.Model;
            //vehicle.NamedDrivers = 
            vehicle.OptionalCovers = MapOptionalCovers(privateVehicle?.OptionalCovers);
            vehicle.Plate = privateVehicle?.Plate;
            vehicle.PolicyWording = MapTypeCodeSummary(privateVehicle?.PolicyWording);
            vehicle.Year = privateVehicle?.Year;

            return vehicle;
        }

        private PC_DevInt.OptionalCover[] MapOptionalCovers(Models.OptionalCover[] optionalCovers)
        {
            var count = optionalCovers?.Count() ?? 0;
            var updatedOptionalCovers = new PC_DevInt.OptionalCover[count];
            for (int i = 0; i < count; i++)
            {
                var optionalCover = new PC_DevInt.OptionalCover();
                optionalCover.Code = optionalCovers[i].Code;
                optionalCover.CoverTaken = optionalCovers[i].CoverTaken;
                optionalCover.DisplayName = optionalCovers[i].DisplayName;
                optionalCover.ID = optionalCovers[i].ID;
                updatedOptionalCovers[i] = optionalCover;
            }
            return updatedOptionalCovers;
        }

        private PolicyCoverableCondExcl[] MapImposedTerms(ImposedTerm[] imposedTerms)
        {
            var count = imposedTerms?.Count() ?? 0;
            var policyCoverableCondExcls = new PolicyCoverableCondExcl[count];
            for (int i = 0; i < count; i++)
            {
                var imposedTerm = new PolicyCoverableCondExcl();
                imposedTerm.Code = imposedTerms[i]?.Code;
                imposedTerm.DisplayName = imposedTerms[i]?.DisplayName;
                imposedTerm.ID = imposedTerms[i]?.ID;
                imposedTerm.Text = imposedTerms[i]?.Text;
                policyCoverableCondExcls[i] = imposedTerm;
            }
            return policyCoverableCondExcls;
        }

        private PC_DevInt.TypeCodeSummary MapTypeCodeSummary(Models.TypeCodeSummary typeCodeSummary)
        {
            var tcs = new PC_DevInt.TypeCodeSummary();
            tcs.Code = typeCodeSummary?.Code;
            tcs.DisplayName = typeCodeSummary?.DisplayName;
            return tcs;
        }

        private PC_DevInt.BaseCover MapBaseCover(BaseCoverJSON baseCoverJSON)
        {
            var baseCover = new PC_DevInt.BaseCover();
            baseCover.BasisOfSettlement = baseCoverJSON.BasisOfSettlement;
            baseCover.Excess = MapExcess(baseCoverJSON.Excess);
            //baseCover.ExcessTypes
            baseCover.InsuredEvent = MapTypeCodeSummary(baseCoverJSON.InsuredEvent);
            baseCover.NaturalDisasterIncluded = baseCoverJSON.NaturalDisasterIncluded == "true";
            //baseCover.NaturalDisasterIncludedSpecified
            baseCover.SumInsured = baseCoverJSON.SumInsured;

            return baseCover;

        }

        private PC_DevInt.TermValue MapExcess(Excess excess)
        {
            var termValue = new PC_DevInt.TermValue();
            termValue.Format = excess.Format;
            termValue.Value = excess.Value;
            return termValue;

        }

        private AccessoryModification[] MapAccessoriesAndModifications(AccessoryAndModification[] accessoriesAndModifications)
        {
            var count = accessoriesAndModifications?.Count() ?? 0;
            var ams = new AccessoryModification[count];
            for (int i = 0; i < count; i++)
            {
                var am = new AccessoryModification();
                am.Details = accessoriesAndModifications[i].Details;
                am.ID = accessoriesAndModifications[i].ID;
                am.Type.Code = accessoriesAndModifications[i].Type.Code;
                am.Type.DisplayName = accessoriesAndModifications[i].Type.DisplayName;
                am.Value = accessoriesAndModifications[i].Value;
                ams[i] = am;
            }
            return ams;
        }



    }
}