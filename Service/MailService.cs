using System.Net;
using System.Net.Mail;

namespace Korepetycje_Matematyka.Service
{
    public class MailService : IMailService
    {
        private readonly string _mailTo = string.Empty;
        private readonly string _mailFrom = string.Empty;
        public MailService(IConfiguration configuration)
        {
            _mailTo = configuration["mailSettings:mailTo"];
            _mailFrom = configuration["mailSettings:mailFrom"];
        }
        public void Send()
        {
                using (MailMessage mail = new MailMessage())
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    smtpClient.Host = "smtp-mail.outlook.com";
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential(_mailFrom, Environment.GetEnvironmentVariable("HASŁO"));
                    smtpClient.EnableSsl = true;
                    String body = @"
                                   <html>
                                   <head></head>
                                   <body>    
                                 xd
                                   </body>
                                   </html>
                               ";

                    mail.IsBodyHtml = true;
                    mail.From = new MailAddress(_mailFrom, "TYTUŁ ");
                    mail.To.Add(_mailTo);
                    mail.Subject = "TEST";
                    smtpClient.Send(mail);
                }
            }
        }
    }

