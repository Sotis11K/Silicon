using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace WebApp.RazorPages.Models;

public class SignUpFormModel
{
    [DisplayName ("First Name")]
    [Required(ErrorMessage = "Invalid last name")]
    public string FirstName { get; set; } = null;

    [DisplayName("Last Name")]
    [Required(ErrorMessage = "Invalid last name")]
    public string LastName { get; set; } = null;

    [DisplayName("Email address")]
    [Required(ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null;

    [DisplayName("Password")]
    [Required(ErrorMessage = "Invalid password")]
    public string Password { get; set; } = null;

    [DisplayName("Confirm password")]
    [Required(ErrorMessage = "Must confirm password")]
    [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
    public string ConfirmPassword { get; set; } = null;


    [Required(ErrorMessage = "You must agree to the terms & conditions")]
    public bool Terms { get; set; }
}
