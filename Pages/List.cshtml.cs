using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
    public class ListModel : PageModel
    {
        public UserManager<IdentityUser> UserManager;
        public ListModel(UserManager<IdentityUser> userManager)
        {
            UserManager = userManager;
        }
        public IEnumerable<IdentityUser?> Users { get; set; } = Enumerable.Empty<IdentityUser>();
        public async void OnGet()
        {
            Users = UserManager.Users;
        }
    }
}