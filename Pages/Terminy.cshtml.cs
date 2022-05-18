using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
    [Authorize(Roles = "User")]

    public class TerminyModel : PageModel
    {
        private ITerminyRepository repo;
        public IEnumerable<Terminy> Terminy { get; set; }

        public TerminyModel(ITerminyRepository repository)
        {
            this.repo = repository;
        }
        public async Task OnGet()
        {
            //Accounts = await AccountsRepo.GetAllAsync();
            Terminy = await repo.GetAllTerminyAsync();
        }
     
    }
}
