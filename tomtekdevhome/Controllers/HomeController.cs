using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tomtekdevhome.Models;
using System.Net.Mail;

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

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactForm vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = EMailMsg();
                    msz.From = new MailAddress(vm.Email);//Email which you are getting 
                                                         //from contact us page 
                    msz.To.Add("tomtekdev@gmail.com");//Where mail will be sent 
                    msz.Subject = vm.Subject;
                    msz.Body = vm.Message;
                    SmtpClient smtp = new SmtpClient()
                    {
                        Host = "smtp.gmail.com",

                        Port = 993,

                        Credentials = new System.Net.NetworkCredential
                    ("tomtekdev@gmail.com", "Bartisgr8"),

                        EnableSsl = true
                    };
                    smtp.Send(msz);

                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us ";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $"Sorry, there is a Problem here processing your request: {ex.Message}";
                }
            }

            return View();
        }

        private static MailMessage EMailMsg()
        {
            return new MailMessage();
        }

        public ActionResult Error
        {
            get
            {
                return View();
            }
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

        public ActionResult LAMP()
        {
            ViewBag.Message = "Web Studio Database tool";

            return View();
        }
    }
}