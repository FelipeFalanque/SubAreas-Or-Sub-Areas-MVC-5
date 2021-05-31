using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC5.Helpers;

namespace WebAppMVC5.Areas.GroupOne.SubGroupTwo.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            // Como existem controladores e ações com o mesmo nome, é necessário fazer esta customização para que o controlador direcione a visualização correta.
            // apenas necessário quando há um controlador / ação com o mesmo nome em outro subgrupo

            // Because there are controllers and actions with the same name, it is necessary to make this customization so that the controller directs to the correct view.
            // only needed when there is a controller / action with the same name in another subgroup

            return View().CustomizeViewEngineCollection(SubGroupTwoRazorViewEngine.RazorViewEngine);
        }
    }
}