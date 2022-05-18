using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
    [Authorize(Roles = "Admins")]
    public class CreateTerminyModel : PageModel
    {
        private ITerminyRepository repo;
        [FromRoute]
        public int Id { get; set; }
        [BindProperty]
        public Terminy Terminy { get; set; }
      
        public CreateTerminyModel(ITerminyRepository repository)
        {
            this.repo = repository;
        }
        public async Task<IActionResult> OnGet()
        {
            Terminy = await repo.GetOneAsync(Id);
            return Page();
        }
        public IActionResult OnPostEdit()
        {
            if (ModelState.IsValid)
            {
                Terminy.Id = Id;
                repo.UpdateAsync(Terminy);
                repo.SaveChangesAsync();
            }
            return RedirectToPage("ADMIN_ListaTerminów");
        }
    }
}
