using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BoomiKillerAPI.Areas.GW_PC.Helper;
using BoomiKillerAPI.Areas.GW_PC.Models;

namespace BoomiKillerAPI.Areas.GW_PC.Controllers
{
    /// <summary>
    /// OnPrem Boomi (Obsolete)
    /// </summary>
    public class NZTA
    {
        private static string onPremBoomiNZTA = @"http://prd0065:9090/ws/rest/NZTA/";
        ///vehicleDetail?plate=P3RRY&minify=False
        internal async Task<NZTAResponse> LookupRego(string rego)
        {
            var vehicle = new NZTAResponse();
            var client = new HttpClient();
            client.BaseAddress = new Uri(onPremBoomiNZTA);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var formatters = new List<MediaTypeFormatter>()
            {
                new XmlMediaTypeFormatter(){UseXmlSerializer = true}
            };


            var response = await client.GetAsync($@"vehicleDetail?minify=False&plate={rego}");
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                vehicle = ParseHelpers.ParseXML<NZTAResponse>(responseString);
            }

            return vehicle;             
            
        }
    }
}