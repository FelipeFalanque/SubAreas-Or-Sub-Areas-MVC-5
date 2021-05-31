using System.Web.Mvc;

namespace WebAppMVC5.Areas.GroupOne.SubGroupTwo
{
    public class SubGroupTwoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SubGroupTwo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            ViewEngines.Engines.Add(SubGroupTwoRazorViewEngine.RazorViewEngine);

            context.MapRoute(
                "SubGroupTwo_default",
                "SubGroupTwo/{controller}/{action}/{id}",
                new { Area = "SubGroupTwo", controller = "Index", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebAppMVC5.Areas.GroupOne.SubGroupTwo.Controllers" }
            );
        }
    }
}