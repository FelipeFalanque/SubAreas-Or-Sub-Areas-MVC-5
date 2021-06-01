using System.Web.Mvc;

namespace WebApp.Areas.GrupoOne
{
    public class GrupoOneAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "GrupoOne";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name: "GrupoOne_default",
                url: "GrupoOne/{controller}/{action}/{id}",
                defaults: new { area = "GrupoOne", controller = "Index", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebApp.Areas.GrupoOne.Controllers" }
            );
        }
    }
}