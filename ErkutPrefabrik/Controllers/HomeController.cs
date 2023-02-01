using ErkutPrefabrik.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace ErkutPrefabrik.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contact()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Contact(Mail model)
        {
            MailMessage email = new MailMessage();
            email.To.Add("emirhan_1095_2001@hotmail.com");
            email.From = new MailAddress("emirhan_1095_2001@hotmail.com");
            email.Subject = "Websitesi: " + model.Subject;
            email.Body = "<b>İsim:</b> " + model.Name + "<br/><b>Mail:</b>  "+model.From + "<br/><b>İçerik: </b>" + model.Context + model.Phone;
            email.IsBodyHtml = true;



            SmtpClient smtp = new SmtpClient();

            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new NetworkCredential("emirhan_1095_2001@hotmail.com", "010203040506Ee");
            smtp.Host = "smtp.live.com";
            smtp.EnableSsl = true;
            smtp.Port = 465;    


            


            return View();
        }
    }



}