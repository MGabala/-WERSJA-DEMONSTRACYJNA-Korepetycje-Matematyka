using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
    public class ADMIN_ListaTerminówModel : PageModel
    {
        private ITerminyRepository repo;
        public IEnumerable<Terminy> Terminy { get; set; }

        public ADMIN_ListaTerminówModel(ITerminyRepository repository)
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
