
using System.ComponentModel.DataAnnotations;

namespace Korepetycje_Matematyka.Data
{
    public class DataAccount
    {
        public int Id { get; set; } 
        [Required]
        public string? Login { get; set; }
        [Required]
        public string? Password { get; set; }
        [Phone]
        public string? PhoneNumber { get; set; }
    }
}
