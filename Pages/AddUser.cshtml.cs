
namespace Korepetycje_Matematyka.Pages
{
    public class AddUserModel : PageModel
    {
        [BindProperty]
        public Account NewUser { get; set; }
        private readonly DbContextAccount _context;
        public AddUserModel(DbContextAccount context )
        {
            _context = context ?? throw new ArgumentNullException( nameof( context ) );
        }
         
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Add(NewUser);
                _context.SaveChanges();
               
            }
            return Page();
        }
    }
}
