using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVC5.Helpers
{
    public class CustomRazorViewEngine : RazorViewEngine
    {
        public bool IsSubArea { get; set; }

        protected override bool FileExists(ControllerContext controllerContext, string virtualPath)
        {
            if (IsSubArea)
            {
                string currentArea = controllerContext.RouteData.DataTokens["area"].ToString();
                string currentController = controllerContext.RouteData.Values["controller"].ToString();
                string currentAction = controllerContext.RouteData.Values["action"].ToString();

                string partialUrl = $"/{currentArea}/Views/{currentController}/{currentAction}";

                return virtualPath.Contains(partialUrl);
            }
            else
            {
                return base.FileExists(controllerContext, virtualPath);
            }
        }
    }
}