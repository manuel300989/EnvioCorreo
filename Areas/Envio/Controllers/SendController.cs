using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;


namespace MvcSendEmail.Areas.Envio.Controllers
{
    public class SendController : Controller
    {
        //
        // GET: /Envio/Send/
        [HttpPost]
        public Int32 SendEmail(Models.Correo Parametros)
        {
            try
            {
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(Parametros.From);
                    mailMessage.Subject = Parametros.Asunto;
                    mailMessage.Body = Parametros.Body;
                    mailMessage.IsBodyHtml = true;
                    mailMessage.To.Add(new MailAddress(Parametros.To));
                    SmtpClient smtp = new SmtpClient();
                    smtp.Send(mailMessage);
                }
                return 1;
            }
            catch
            {
                return 0;
            }
        }

    }
}
