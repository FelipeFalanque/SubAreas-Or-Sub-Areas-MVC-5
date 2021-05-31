using System.Web.Mvc;

namespace WebAppMVC5.Areas.AreaOne
{
    public class TestAreaRegistration : AreaRegistration 
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
                new { Area = "Test", controller = "Index", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebAppMVC5.Areas.Test.Controllers" }
            );
        }
    }
}