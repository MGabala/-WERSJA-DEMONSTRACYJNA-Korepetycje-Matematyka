using Microsoft.AspNetCore.Authorization;

namespace Korepetycje_Matematyka.Pages
{
    [Authorize(Roles = "Admins")]
    public class AdminPage : PageModel
    {
    }
}
