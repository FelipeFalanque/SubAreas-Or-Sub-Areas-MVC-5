using System.Web.Mvc;
using WebAppMVC5.Helpers;

namespace WebAppMVC5.Areas.Test.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PageTest()
        {
            return View();
        }
    }
}