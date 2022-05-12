using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
    public class EditORDeleteUserModel : PageModel
    {
        private ICRUDRepository repo;
        [FromRoute]
        public int Id { get; set; }
        [BindProperty]
        public Account EditUser { get; set; }
        public EditORDeleteUserModel(ICRUDRepository repository)
        {
            this.repo = repository;
        }
        public async Task<IActionResult> OnGet()
        {
            EditUser = await repo.GetOneAsync(Id);
            return Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                EditUser.Id = Id;
                repo.UpdateAsync(EditUser);
            }
            return RedirectToPage("allusers");
        }
    }
}
