using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC5.Helpers;

namespace WebAppMVC5.Areas.GroupOne.SubGroupOne.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PageSubGroupOne()
        {
            return View();
        }
    }
}