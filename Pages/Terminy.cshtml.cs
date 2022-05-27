using Microsoft.AspNetCore.Identity;
using Microsoft.Data.Sqlite;
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
        private readonly string _connectionString = string.Empty;
        public UserManager<IdentityUser> UserManager;
     
        public string DzieñTygodnia { get; set; }
        public IEnumerable<Terminy> Terminy { get; set; }
       
        
        public TerminyModel(ITerminyRepository repository, IConfiguration configuration, UserManager<IdentityUser> usrManager)
        {
            UserManager = usrManager;
            this.repo = repository;
            _mailTo = configuration["mailSettings:mailTo"];
            _mailFrom = configuration["mailSettings:mailFrom"];
            _connectionString = configuration["ConnectionStrings:AccountsDB"];
        }
        public async Task OnGet()
        {
            Terminy = await repo.GetAllTerminyAsync();
            
        } 
        public async Task<IActionResult> OnPostAsync(int id, string column, string day, string value)
        {
            
            var user = await UserManager.GetUserAsync(User);
            using (MailMessage mail = new MailMessage())
            using (SmtpClient smtpClient = new SmtpClient())
            {
                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(_mailFrom, Environment.GetEnvironmentVariable("HAS£O"));
                smtpClient.EnableSsl = true;
                mail.Body = $"U¿ytkownik: {user.UserName} o numerze: {user.PhoneNumber} zapisa³ siê na termin: {day} o godzinie {value} ";
                mail.IsBodyHtml = false;
                mail.From = new MailAddress(_mailFrom, "Zapis na korepetycje");
                mail.To.Add(_mailTo);
                mail.Subject = $"Nowy termin zarezerwowany przez {user.PhoneNumber} na termin: {day} o godzinie {value}";
                smtpClient.Send(mail);
            }
           var query = $"UPDATE [TERMINY] set [{column}] = 'Niedostêpny' where id = {id}";
            using (var con = new SqliteConnection(_connectionString))
            using (var cmd = new SqliteCommand())
            {
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
                return RedirectToPage("Potwierdzenie");
        }
    }
}
