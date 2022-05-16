using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
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
            }
            return RedirectToPage("terminy");
        }
    }
}
