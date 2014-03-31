using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSendEmail.Areas.Envio.Models
{
    public class Correo
    {
        string _From;

        public string From
        {
            get { return _From; }
            set { _From = value; }
        }

        string _To;

        public string To
        {
            get { return _To; }
            set { _To = value; }
        }

        string _Asunto;

        public string Asunto
        {
            get { return _Asunto; }
            set { _Asunto = value; }
        }

        string _Body;

        public string Body
        {
            get { return _Body; }
            set { _Body = value; }
        }

        string _Credential;

        public string Credential
        {
            get { return _Credential; }
            set { _Credential = value; }
        }


    }
}