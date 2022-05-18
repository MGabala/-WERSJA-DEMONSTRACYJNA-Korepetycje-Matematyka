using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
    [Authorize(Roles = "Admins")]
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
        public async Task<IActionResult> OnPostAsync(string id)
        {
            IdentityUser user = await UserManager.FindByIdAsync(id);
            if (user != null)
            {
                await UserManager.DeleteAsync(user);
            }
            return RedirectToPage();
        }
    }
}