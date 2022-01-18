using System.Web.Mvc;

namespace WebApplication2.Areas.Test
{
    public class AreasTestRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Test";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Test_default",
                "Test/{controller}/{action}/{id}",
                new { controller="Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}