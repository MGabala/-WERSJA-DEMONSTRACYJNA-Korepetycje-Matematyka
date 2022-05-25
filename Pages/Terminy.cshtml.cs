using Microsoft.AspNetCore.Identity;
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
        public UserManager<IdentityUser> UserManager;
     
        public string DzieñTygodnia { get; set; }
        public IEnumerable<Terminy> Terminy { get; set; }
       
        
        public TerminyModel(ITerminyRepository repository, IConfiguration configuration, UserManager<IdentityUser> usrManager)
        {
            UserManager = usrManager;
            this.repo = repository;
            _mailTo = configuration["mailSettings:mailTo"];
            _mailFrom = configuration["mailSettings:mailFrom"];
           
        }
        public async Task OnGet()
        {
            Terminy = await repo.GetAllTerminyAsync();
            
        } 
        public async Task<IActionResult> OnPostAsync(string name, string value)
        {
            var user = await UserManager.GetUserAsync(User);
            using (MailMessage mail = new MailMessage())
            using (SmtpClient smtpClient = new SmtpClient())
            {
                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(_mailFrom, Environment.GetEnvironmentVariable("HAS£O"));
                smtpClient.EnableSsl = true;
                mail.Body = $"U¿ytkownik: {user.UserName} o numerze: {user.PhoneNumber} zapisa³ siê na termin: {name} o godzinie {value} ";
                mail.IsBodyHtml = false;
                mail.From = new MailAddress(_mailFrom, "TYTU£ ");
                mail.To.Add(_mailTo);
                mail.Subject = "TEST";
                smtpClient.Send(mail);
            }
            return RedirectToPage("Potwierdzenie");
        }
    }
}
