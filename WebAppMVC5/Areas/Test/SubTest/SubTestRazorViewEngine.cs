using System.Web.Mvc;

namespace WebAppMVC5.Areas.Test.SubTest
{
    public static class SubTestRazorViewEngine
    {
        public static RazorViewEngine RazorViewEngine
        {
            get
            {
                return new RazorViewEngine
                {
                    AreaPartialViewLocationFormats = new[] { "~/Areas/Test/SubTest/Views/{1}/{0}.cshtml", "~/Areas/Test/SubTest/Views/Shared/{0}.cshtml" },
                    AreaMasterLocationFormats = new[] { "~/Areas/Test/SubTest/Views/{1}/{0}.cshtml" },
                    AreaViewLocationFormats = new[] { "~/Areas/Test/SubTest/Views/{1}/{0}.cshtml" }
                };
            }
        }
    }
}