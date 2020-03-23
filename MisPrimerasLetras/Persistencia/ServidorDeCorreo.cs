using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Persistencia
{
    public abstract  class  ServidorDeCorreo
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmtClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void EnviarEmail(string subject, string cuerpo, string usuarioEmail)
        {
            var mailMessage = new MailMessage();

            try
            {
                mailMessage.From = new MailAddress(senderMail);
                mailMessage.To.Add(usuarioEmail);
                mailMessage.Subject = subject;
                mailMessage.Body = cuerpo;
                mailMessage.Priority = MailPriority.Normal; //indicamos la prioridad
                smtpClient.Send(mailMessage);
            }
            catch
            {

            }
            finally
            {
                mailMessage.Dispose(); // liberamos recursos
                smtpClient.Dispose();

            }
        }
    }
}
