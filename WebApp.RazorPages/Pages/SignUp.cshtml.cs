using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.RazorPages.Models;

namespace WebApp.RazorPages.Pages;

public class SignUpModel : PageModel
{
    public SignUpFormModel Form { get; set; } = null!;



    public void OnGet()
    {
        Form = new SignUpFormModel();
    }

    public void OnPost()
    {
    }
}
