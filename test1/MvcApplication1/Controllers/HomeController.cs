using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "OneLegacy";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "OneLegacy.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "OneLegacy contact page.";

            return View();
        }
    }
}
