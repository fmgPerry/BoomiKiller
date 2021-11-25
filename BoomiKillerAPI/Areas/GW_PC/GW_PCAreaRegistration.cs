using System.Web.Mvc;

namespace BoomiKillerAPI.Areas.GW_PC
{
    public class GW_PCAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "GW_PC";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "GW_PC_default",
                "GW_PC/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}