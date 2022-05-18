using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages.Account
{
    public class DetailsModel : PageModel
    {
        private UserManager<IdentityUser> userManager;
        public DetailsModel(UserManager<IdentityUser> manager)
        {
            userManager = manager;
        }
        public IdentityUser? IdentityUser { get; set; }
        public string? Cookie { get; set; }
        public async Task OnGetAsync()
        {
            Cookie = Request.Cookies[".AspNetCore.Identity.Application"];
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                IdentityUser = await
                    userManager.FindByNameAsync(User.Identity.Name);
            }
        }
        
    
    }
}