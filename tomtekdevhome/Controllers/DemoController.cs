using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tomtekdevhome.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        // GET: Demo
        public ActionResult LStudio()
        {
            return View();
        }

        // GET: Demo
        public ActionResult CDLD()
        {
            return View();
        }

        // GET: Demo
        public ActionResult ADLD()
        {
            return View();  //Redirect("http://dldistance20170514123910.azurewebsites.net"); 
        }

        // GET: Demo
        //public ActionResult Github()
        //{
        //    return View();
        //}
    }
}