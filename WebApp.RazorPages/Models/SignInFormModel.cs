using System.ComponentModel.DataAnnotations;

namespace WebApp.RazorPages.Models
{
    public class SignInFormModel
    {



        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email", Prompt = "Enter your email address")]
        [Required(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null;



        [DataType(DataType.Password)]
        [Display(Name = "Password", Prompt = "********")]
        [Required(ErrorMessage = "Invalid password")]
        public string Password { get; set; } = null;



        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; } = false;
    }



}
