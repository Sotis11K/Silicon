using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.RazorPages.Models;

namespace WebApp.RazorPages.Pages
{
    public class signinModel : PageModel
    {

        [BindProperty]
        public SignInFormModel Form { get; set; } = new SignInFormModel();
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/index");
        }
    }
}
