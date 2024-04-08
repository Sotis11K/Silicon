using System.ComponentModel.DataAnnotations;

namespace WebApp.RazorPages.Models
{
    public class AccountDetailsBasicInfoModel
    {

        [DataType(DataType.ImageUrl)]
        public string? ProfileImage { get; set; }



        [Display(Name = "First Name", Prompt = "Enter your first name", Order = 0)]
        [Required(ErrorMessage = "Invalid first name")]
        [MinLength(2, ErrorMessage = "Invalid first name")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name", Prompt = "Enter your last name", Order = 1)]
        [Required(ErrorMessage = "Invalid last name")]
        [MinLength(2, ErrorMessage = "Invalid last name")]

        public string LastName { get; set; } = null!;

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address", Prompt = "Enter your email address", Order = 2)]
        [RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]{2,}$", ErrorMessage = "Invalid email address")]

        public string Email { get; set; } = null!;

        [Display(Name = "Phone", Prompt = "Enter your phone", Order = 3)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone is required")]

        public string Phone { get; set; } = null!;

        [Display(Name = "Bio", Prompt = "Add a short bio...", Order = 4)]
        [DataType(DataType.MultilineText)]

        public string? Bio { get; set; }


    }
}
