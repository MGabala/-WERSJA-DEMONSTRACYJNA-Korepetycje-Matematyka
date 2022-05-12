
namespace Korepetycje_Matematyka.Pages
{
    public class AddUserModel : PageModel
    {
        private ICRUDRepository repo;

        [BindProperty]
        public Account NewUser { get; set; }
        public AddUserModel(ICRUDRepository repository)
        {
            this.repo = repository;
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                repo.CreateAsync(NewUser);
            }
            return RedirectToPage("allusers");
        }
    }
}
