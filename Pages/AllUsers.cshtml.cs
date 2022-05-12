using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
    public class AllUsersModel : PageModel
    {
        private ICRUDRepository AccountsRepo;
        public IEnumerable<Account> Accounts { get; set; }

        public AllUsersModel(ICRUDRepository repository)
        {
            this.AccountsRepo = repository;
        }
        public async Task OnGet()
        {
            Accounts = await AccountsRepo.GetAllAsync();
           
        }
    }
}
