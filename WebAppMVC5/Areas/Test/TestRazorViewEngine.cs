using System.Web.Mvc;

namespace WebAppMVC5.Areas.Test
{
    public static class TestRazorViewEngine
    {
        public static RazorViewEngine RazorViewEngine
        {
            get
            {
                return new RazorViewEngine
                {
                    AreaPartialViewLocationFormats = new[] { "~/Areas/Test/Views/{1}/{0}.cshtml", "~/Areas/Test/Views/Shared/{0}.cshtml" },
                    AreaMasterLocationFormats = new[] { "~/Areas/Test/Views/{1}/{0}.cshtml" },
                    AreaViewLocationFormats = new[] { "~/Areas/Test/Views/{1}/{0}.cshtml" }
                };
            }
        }
    }
}