using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Dynamic;

namespace Datos.EmailServices
{

    //Clase base
    public abstract class ServidorDeCorreosMaestro
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }



        //Metodo para iniciar el cliente smtp
        protected void inicializarSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;

        }

        //Metodo publico para enviar mensajes de correo
        public void sendMail(string subject, string body, List<string> recipientMail) 
        {
            var mailMessage = new MailMessage();
            try
            {
                //Dirreccion de correo
                mailMessage.From = new MailAddress(senderMail);
                //ciclo para recorrer la lista de correos
                foreach(string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }

                //Asunto Del Correo
                mailMessage.Subject = subject;

                //Cuerpo o mensaje del correo
                mailMessage.Body = body;

                //Indicar prioridad
                mailMessage.Priority = MailPriority.Normal;

                //Enviar mensaje
                smtpClient.Send(mailMessage);
                
            }catch(Exception ex)
            {

            }
            finally
            {
                //Desechar lo creado para liberar recursos
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }


    }
}
