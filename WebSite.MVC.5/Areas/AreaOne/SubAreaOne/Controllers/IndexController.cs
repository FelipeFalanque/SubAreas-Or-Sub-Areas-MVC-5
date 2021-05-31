using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.MVC._5.Areas.AreaOne.SubAreaOne.Controllers
{
    public class IndexController : Controller
    {
        // GET: AreaOne/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}