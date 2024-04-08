// DetailsModel.cshtml.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.RazorPages.Models; // Make sure to include the namespace of your view model

namespace WebApp.RazorPages.Pages.Account
{
    public class DetailsModel : PageModel
    {
        public string Title { get; set; } = "Account Details";

        public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
        {
            ProfileImage = "/images/profile_picture.svg",
            FirstName = "Ella",
            LastName = "Kihlgren",
            Email = "john.doe@domain.com"
        };

        public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();

        public IActionResult OnPostBasicInfo()
        {
            return RedirectToPage("/account/details");
        }

        public IActionResult OnPostAddress()
        {
            return RedirectToPage("/account/details");
        }

    }
}
