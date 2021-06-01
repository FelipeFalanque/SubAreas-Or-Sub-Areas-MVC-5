using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Helpers;

namespace WebApp.Areas.GrupoOne.SubGrupoOne
{
    public class SubGrupoOneAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "SubGrupoOne";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            ViewEngines.Engines.Add(new CustomRazorViewEngine
            {
                IsSubArea = true,
                AreaPartialViewLocationFormats = new[] { "~/Areas/GrupoOne/SubGrupoOne/Views/{1}/{0}.cshtml", "~/Areas/GrupoOne/SubGrupoOne/Views/Shared/{0}.cshtml" },
                AreaMasterLocationFormats = new[] { "~/Areas/GrupoOne/SubGrupoOne/Views/{1}/{0}.cshtml" },
                AreaViewLocationFormats = new[] { "~/Areas/GrupoOne/SubGrupoOne/Views/{1}/{0}.cshtml" }
            });

            context.MapRoute(
                name: "SubGrupoOne_default",
                url: "SubGrupoOne/{controller}/{action}/{id}",
                defaults: new { area = "SubGrupoOne", controller = "Index", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebApp.Areas.GrupoOne.SubGrupoOne.Controllers" }
            );
        }
    }
}