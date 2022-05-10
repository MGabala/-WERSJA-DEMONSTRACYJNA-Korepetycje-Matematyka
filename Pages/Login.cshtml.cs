using Korepetycje_Matematyka.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
    public class LoginModel : PageModel
    {
        public Account TryLogin { get; set; }
        public void OnGet()
        {
        }
    }
}
