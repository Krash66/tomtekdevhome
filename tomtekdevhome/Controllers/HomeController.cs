using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tomtekdevhome.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Our Mission at TomTek Development";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "TomTek Development";

            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.Message = "Tom Karasch's Resume";

            return View();
        }

        public ActionResult Demo()
        {
            ViewBag.Message = "A few of our Past Projects";

            return View();
        }

        public ActionResult DLdistance()
        {
            ViewBag.Message = "Damerau-Levenshtein Distance";

            return View();
        }
    }
}