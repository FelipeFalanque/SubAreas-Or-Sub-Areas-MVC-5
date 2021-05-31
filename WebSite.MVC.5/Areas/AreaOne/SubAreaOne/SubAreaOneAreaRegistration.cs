using System.Web.Mvc;

namespace WebSite.MVC._5.Areas.SubAreaOne
{
    public class SubAreaOneAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SubAreaOne";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SubAreaOne_default",
                "SubAreaOne/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}