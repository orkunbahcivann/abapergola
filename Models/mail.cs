using AbaPergola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace AbaPergola
{
    public class mail
    {
        public static void MailSender(string body)
        {
            var fromAddress = new MailAddress("info@abapergola.eu");
            var toAddress = new MailAddress("info@abapergola.eu");
            const string subject = "AbaPergola | Sitenizden Gelen İletişim Formu";
            using (var smtp = new SmtpClient
            {
                Host = "mail.kurumsaleposta.com",
                Port = 465 / 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential(fromAddress.Address, "AbaPer597102")
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }

            //}
            //public static void MailSender(string body) {

            //    var cnt = new Contact();
            //MailMessage mail = new MailMessage();
            //SmtpClient SmtpServer = new SmtpClient("mail.kurumsaleposta.com");
            //mail.From = new MailAddress("info@abapergola.eu");
            //mail.To.Add("info@abapergola.eu");
            //mail.Subject = "başarılı";
            //mail.Body = "başarılı";
            //SmtpServer.Port = 465/587;
            //SmtpServer.Credentials = new System.Net.NetworkCredential("info@abapergola.eu", "AbaPer597102");
            //SmtpServer.EnableSsl = true;
            //SmtpServer.Send(mail);

            //    }
        }
    }
}