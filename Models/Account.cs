
namespace Korepetycje_Matematyka.Data
{
    public class Account
    {
        public int Id { get; set; } 
        [Required(ErrorMessage ="Podaj poprawny login.")]
        public string? Login { get; set; }
        [Required(ErrorMessage ="Podaj poprawne hasło.")]
        public string? Password { get; set; }
        [Required(ErrorMessage ="Podaj poprawny numer telefonu."),MinLength(9, ErrorMessage ="Numer telefonu ma 9 cyfr ;)"),MaxLength(9)]
        public string? PhoneNumber { get; set; }
        [MaxLength(250)]
        public string? Desc { get; set; }
    }
}
