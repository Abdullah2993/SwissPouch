using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwissPouch.Controllers
{
    [OutputCache(Duration = 60*60*24)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Utilities");
        }

        public ActionResult Utilities()
        {
            return View();
        }

        public ActionResult Crypto()
        {
            return View();
        }
    }
}
