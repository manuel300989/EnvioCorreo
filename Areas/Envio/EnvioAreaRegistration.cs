using System.Web.Mvc;

namespace MvcSendEmail.Areas.Envio
{
    public class EnvioAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Envio";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Envio_default",
                "Envio",
                new { action = "SendEmail", controller = "Send" }
            );
        }
    }
}
