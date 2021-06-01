using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Areas.GrupoOne.SubGrupoTwo.Controllers
{
    public class IndexController : Controller
    {
        // GET: GrupoOne/Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SubGrupoTwo()
        {
            return View();
        }
    }
}