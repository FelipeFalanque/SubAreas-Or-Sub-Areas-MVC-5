using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Helpers;

namespace WebApp.Areas.GrupoOne.SubGrupoTwo
{
    public class SubGrupoTwoAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "SubGrupoTwo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            ViewEngines.Engines.Add(new CustomRazorViewEngine
            {
                IsSubArea = true,
                AreaPartialViewLocationFormats = new[] { "~/Areas/GrupoOne/SubGrupoTwo/Views/{1}/{0}.cshtml", "~/Areas/GrupoOne/SubGrupoTwo/Views/Shared/{0}.cshtml" },
                AreaMasterLocationFormats = new[] { "~/Areas/GrupoOne/SubGrupoTwo/Views/{1}/{0}.cshtml" },
                AreaViewLocationFormats = new[] { "~/Areas/GrupoOne/SubGrupoTwo/Views/{1}/{0}.cshtml" }
            });

            context.MapRoute(
                name: "SubGrupoTwo_default",
                url: "SubGrupoTwo/{controller}/{action}/{id}",
                defaults: new { area = "SubGrupoTwo", controller = "Index", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebApp.Areas.GrupoOne.SubGrupoTwo.Controllers" }
            );
        }
    }
}