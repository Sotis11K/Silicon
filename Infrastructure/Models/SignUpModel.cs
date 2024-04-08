using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class SignUpModel
    {
        [Display(Name = "First Name", Prompt = "Enter your first name", Order = 0)]
        [Required(ErrorMessage = "Invalid first name")]
        [MinLength(2, ErrorMessage = "Invalid first name")]
        public string FirstName { get; set; } = null;

        [Display(Name = "Last Name", Prompt = "Enter your last name", Order = 1)]
        [Required(ErrorMessage = "Invalid last name")]
        [MinLength(2, ErrorMessage = "Invalid last name")]

        public string LastName { get; set; } = null;

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address", Prompt = "Enter your email address", Order = 2)]
        [RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]{2,}$", ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null;

        [DataType(DataType.Password)]
        [Display(Name = "Password", Prompt = "********", Order = 3)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z\\d]).{8,}$", ErrorMessage = "Invalid password")]
        public string Password { get; set; } = null;

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password", Prompt = "********", Order = 4)]
        [Required(ErrorMessage = "Must confirm password")]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = null;

        [Display(Name = "I agree to the Terms & Conditions", Order = 5)]
        [CheckBoxRequired(ErrorMessage = "Please accept the terms and conditions")]
        public bool Terms { get; set; } = false;
    }
}
