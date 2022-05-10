using Korepetycje_Matematyka.Data;
using Korepetycje_Matematyka.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
         
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Add(NewUser);
                _context.SaveChanges();
            }
            
        }
    }
}
