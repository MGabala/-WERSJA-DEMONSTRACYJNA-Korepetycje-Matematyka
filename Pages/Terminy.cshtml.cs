using Korepetycje_Matematyka.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
    [Authorize(Roles = "User")]

    public class TerminyModel : PageModel
    {
        private readonly IMailService _mailService;
        private ITerminyRepository repo;
        public IEnumerable<Terminy> Terminy { get; set; }

        public TerminyModel(ITerminyRepository repository, IMailService mailService)
        {
            this.repo = repository;
            this._mailService = mailService;
        }
        public async Task OnGet()
        {
            //Accounts = await AccountsRepo.GetAllAsync();
            Terminy = await repo.GetAllTerminyAsync();
            _mailService.Send();
        }
     
    }
}
