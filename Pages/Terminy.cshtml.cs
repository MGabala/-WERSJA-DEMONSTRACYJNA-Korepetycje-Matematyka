using Korepetycje_Matematyka.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Net.Mail;

namespace Korepetycje_Matematyka.Pages
{
  //  [Authorize(Roles = "User")]

    public class TerminyModel : PageModel
    {
        private ITerminyRepository repo;
        private readonly string _mailTo = string.Empty;
        private readonly string _mailFrom = string.Empty;
        public IEnumerable<Terminy> Terminy { get; set; }

        public TerminyModel(ITerminyRepository repository, IConfiguration configuration)
        {
            this.repo = repository;
            _mailTo = configuration["mailSettings:mailTo"];
            _mailFrom = configuration["mailSettings:mailFrom"];
        }
        public async Task OnGet()
        {
            //Accounts = await AccountsRepo.GetAllAsync();
            Terminy = await repo.GetAllTerminyAsync();
           
        }
        public async Task<IActionResult> OnPostAsync()
        {
            string ID = User.Identity.Name;
            using (MailMessage mail = new MailMessage())
            using (SmtpClient smtpClient = new SmtpClient())
            {
                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(_mailFrom, Environment.GetEnvironmentVariable("HAS£O"));
                smtpClient.EnableSsl = true;
                mail.Body = $"{ID}";
                mail.IsBodyHtml = false;
                mail.From = new MailAddress(_mailFrom, "TYTU£ ");
                mail.To.Add(_mailTo);
                mail.Subject = "TEST";
                smtpClient.Send(mail);
            }
            return Page();
        }
    }
}
