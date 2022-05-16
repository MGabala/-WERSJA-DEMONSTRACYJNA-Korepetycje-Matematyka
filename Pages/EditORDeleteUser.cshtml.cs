using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
    public class EditORDeleteUserModel : PageModel
    {
        private IAccountRepository repo;
        [FromRoute]
        public int Id { get; set; }
        [BindProperty]
        public Account EditUser { get; set; }
        public EditORDeleteUserModel(IAccountRepository repository)
        {
            this.repo = repository;
        }
        public async Task<IActionResult> OnGet()
        {
            EditUser = await repo.GetOneAsync(Id);
            return Page();
        }
        public IActionResult OnPostEdit()
        {
            if (ModelState.IsValid)
            {
                EditUser.Id = Id;
                repo.UpdateAsync(EditUser);
            }
            return RedirectToPage("allusers");
        }
        public IActionResult OnPostDelete()
        {
            repo.DeleteAsync(Id);
            return RedirectToPage("allusers");
        }
    }
}
