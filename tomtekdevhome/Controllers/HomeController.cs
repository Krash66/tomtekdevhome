using System.Web.Mvc;
using tomtekdevhome.Models;
using System.Net.Mail;
using System.Threading.Tasks;

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
            ViewBag.Message = "About TomTek Development's owner";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(ContactFormModels model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Phone: {2}</p><p>Subject: {3}</p><p>Message:</p><p>{4}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("tomkarasch@gmail.com"));
                message.To.Add(new MailAddress("tomtekdev@gmail.com"));
                message.Subject = "From Contact Page at TomTekDev Homepage";
                message.Body = string.Format(body, model.Name, model.Email, model.Phone, model.Subject, model.Message);
                message.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View();
        }

        public ActionResult Sent()
        {
            return View();
        }

        public ActionResult Error
        {
            get
            {
                return View();
            }
        }
        
        //public ActionResult Demo()
        //{
        //    ViewBag.Message = "A Few Demonstration Projects";

        //    return View();
        //}

        //public ActionResult DLdistance()
        //{
        //    ViewBag.Message = "Damerau-Levenshtein Distance";

        //    return View();
        //}

        public ActionResult LAMP()
        {
            ViewBag.Message = "Unix/Apache hosted TomTek Website using dHTMLx";

            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "Administrator panel";

            return View();
        }
    }
}