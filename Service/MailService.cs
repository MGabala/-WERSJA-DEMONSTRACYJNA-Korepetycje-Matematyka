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
           
        }
    }
}
