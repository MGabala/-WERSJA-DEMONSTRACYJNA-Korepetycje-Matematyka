using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
    [Authorize(Roles = "Admins")]
    public class AdminPanelModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
