using System.Web.Mvc;

namespace WebAppMVC5.Areas.Test.SubTest
{
    public class SubTestAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "SubTest";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            ViewEngines.Engines.Add(SubTestRazorViewEngine.RazorViewEngine);

            context.MapRoute(
                "SubTest_default",
                "SubTest/{controller}/{action}/{id}",
                new { Area = "SubTest", controller = "Index", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebAppMVC5.Areas.Test.SubTest.Controllers" }
            );
        }
    }
}