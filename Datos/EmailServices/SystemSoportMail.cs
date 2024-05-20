using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EmailServices
{
    internal class SystemSoportMail: ServidorDeCorreosMaestro
    {
        //Constructor
        public SystemSoportMail()
        {
            //senderMail = "soporteproyectoinventarioug@gmail.com";
            //password = "@admin1234";
            senderMail = Environment.GetEnvironmentVariable("SUPPORT_EMAIL") ?? "soporteproyectoinventarioug@gmail.com";
            password = Environment.GetEnvironmentVariable("SUPPORT_EMAIL_PASSWORD") ?? "@admin1234";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            inicializarSmtpClient();
        }

    }
}
