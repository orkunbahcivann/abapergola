using AbaPergola.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AbaPergola.Controllers
{
    public class DefaultENController : Controller
    {
        // GET: DefaultEN
        
        public ActionResult Home()
        {
            
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Draws_3d()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();


        }

        [HttpPost]
        public ActionResult Contact(Contact model)
                
              {
            if (ModelState.IsValid)
            {
                var body = new StringBuilder();
                body.AppendLine("Ad & Soyad: " + model.name);
                body.AppendLine("E-Mail Adresi: " + model.email);
                body.AppendLine("Konu: " + model.Subject);
                body.AppendLine("Mesaj: " + model.message);
                mail.MailSender(body.ToString());
            }
            //if (name != null && email != null)
            //{
            //    WebMail.SmtpServer = "mail.kurumsaleposta.com";
            //    WebMail.EnableSsl = true;
            //    WebMail.UserName = "info@abapergola.eu";
            //    WebMail.Password = "AbaPer597102";
            //    WebMail.SmtpPort = 465;
            //    WebMail.From = "info@abapergola.eu";
            //    WebMail.Send("info@abapergola.eu", subject, email + "</br>" + message);
                
            //    ViewBag.Alarm = "Your message has been successfull";
            //}
            //else
            //{
            //    ViewBag.Alarm = "Error, please try again.";
            //}

            return View();
        }
    }
}