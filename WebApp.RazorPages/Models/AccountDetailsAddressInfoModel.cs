using System.ComponentModel.DataAnnotations;

namespace WebApp.RazorPages.Models
{
    public class AccountDetailsAddressInfoModel
    {

        [Display(Name = "Address", Prompt = "Enter your address", Order = 0)]
        [Required(ErrorMessage = "Invalid first name")]
        public string Addressline_1 { get; set; } = null;

        [Display(Name = "Address 2", Prompt = "Enter your address", Order = 1)]

        public string? Addressline_2 { get; set; }


        [Display(Name = "Postal code", Prompt = "Enter your postal code", Order = 2)]
        [Required(ErrorMessage = "Postal code is required")]
        [DataType(DataType.PostalCode)]

        public string PostalCode { get; set; } = null;

        [Display(Name = "City", Prompt = "Enter your City", Order = 3)]
        [Required(ErrorMessage = "City is required ")]


        public string City { get; set; } = null;
    }
}
