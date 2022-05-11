
namespace Korepetycje_Matematyka.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Account TryLogin { get; set; }
        public void OnGet()
        {
        }

    }
}
