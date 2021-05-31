using System.Web.Mvc;
using WebAppMVC5.Helpers;

namespace WebAppMVC5.Areas.GroupOne.SubGroupOne
{
    public static class SubGroupOneRazorViewEngine
    {
        public static RazorViewEngine RazorViewEngine
        {
            get
            {
                return new CustomRazorViewEngine
                {
                    IsSubArea = true,
                    AreaPartialViewLocationFormats = new[] { "~/Areas/GroupOne/SubGroupOne/Views/{1}/{0}.cshtml", "~/Areas/GroupOne/SubGroupOne/Views/Shared/{0}.cshtml" },
                    AreaMasterLocationFormats = new[] { "~/Areas/GroupOne/SubGroupOne/Views/{1}/{0}.cshtml" },
                    AreaViewLocationFormats = new[] { "~/Areas/GroupOne/SubGroupOne/Views/{1}/{0}.cshtml" }
                };
            }
        }
    }
}