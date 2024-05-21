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
            //senderMail = "soporteproyectoinventarioug@hotmail.com";
            //password = "saqfapiskssctslo";
            senderMail = "soporte.proyectoinventarioug@libreriaug.tech";
            password = "dwOsULw8";
            //senderMail = Environment.GetEnvironmentVariable("SUPPORT_EMAIL") ?? "soporteproyectoinventarioug@hotmail.com";
            //password = Environment.GetEnvironmentVariable("SUPPORT_EMAIL_PASSWORD") ?? "saqfapiskssctslo";
            //host = "smtp-mail.outlook.com";
            //port = 587;
            host = "us2.smtp.mailhostbox.com";
            port = 587;
            STARTTLS = true;
            inicializarSmtpClient();
        }

    }
}
