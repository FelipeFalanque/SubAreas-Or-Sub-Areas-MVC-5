using System.Web.Mvc;

namespace WebAppMVC5.Areas.GroupOne.SubGroupTwo
{
    public static class SubGroupTwoRazorViewEngine
    {
        public static RazorViewEngine RazorViewEngine
        {
            get
            {
                return new RazorViewEngine
                {
                    AreaPartialViewLocationFormats = new[] { "~/Areas/GroupOne/SubGroupTwo/Views/{1}/{0}.cshtml", "~/Areas/GroupOne/SubGroupTwo/Views/Shared/{0}.cshtml" },
                    AreaMasterLocationFormats = new[] { "~/Areas/GroupOne/SubGroupTwo/Views/{1}/{0}.cshtml" },
                    AreaViewLocationFormats = new[] { "~/Areas/GroupOne/SubGroupTwo/Views/{1}/{0}.cshtml" }
                };
            }
        }
    }
}