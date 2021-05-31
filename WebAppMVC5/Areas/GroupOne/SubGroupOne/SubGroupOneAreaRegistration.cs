using System.Web.Mvc;

namespace WebAppMVC5.Areas.GroupOne.SubGroupOne
{
    public class SubGroupOneAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SubGroupOne";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            ViewEngines.Engines.Add(SubGroupOneRazorViewEngine.RazorViewEngine);

            context.MapRoute(
                "SubGroupOne_default",
                "SubGroupOne/{controller}/{action}/{id}",
                new { Area = "SubGroupOne", controller = "Index", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebAppMVC5.Areas.GroupOne.SubGroupOne.Controllers" }
            );
        }
    }
}