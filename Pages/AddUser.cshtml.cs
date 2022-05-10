using Korepetycje_Matematyka.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Korepetycje_Matematyka.Pages
{
    public class AddUserModel : PageModel
    {
        public Account NewUser { get; set; }
         
        public void OnPost()
        {

        }
    }
}
