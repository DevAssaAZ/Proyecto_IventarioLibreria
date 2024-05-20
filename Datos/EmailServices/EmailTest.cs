using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.EmailServices;

namespace EmailTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia de SystemSoportMail
            SystemSoportMail soporteMail = new SystemSoportMail();

            // Configurar destinatarios del correo
            List<string> destinatarios = new List<string> { "soporteproyectoinventarioug@gmail.com" };

            // Configurar asunto y cuerpo del correo
            string asunto = "Recuperacion de contraseña";
            string cuerpo = "A continuacion  el siguiente mensaje";

            // Enviar el correo
            soporteMail.sendMail(asunto, cuerpo, destinatarios);

            Console.WriteLine("Correo enviado exitosamente.");
        }
    }
}