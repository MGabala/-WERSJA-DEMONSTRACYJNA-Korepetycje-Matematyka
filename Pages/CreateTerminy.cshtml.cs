using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
    public class CreateTerminyModel : PageModel
    {
        private ICRUDRepository repo;
        [FromRoute]
        public int Id { get; set; }
        public Terminy Terminy { get; set; }
        public CreateTerminyModel(ICRUDRepository repository)
        {
            this.repo = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public void OnGet()
        {
        }
    }
}
