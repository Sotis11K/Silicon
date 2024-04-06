using Microsoft.AspNetCore.Mvc;
using WebApp.RazorPages.Pages;

namespace WebApp.RazorPages.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        [Route("/signup")]
        public IActionResult SignUp() => View(new SignUpModel());




        [HttpPost]
        [Route("/signup")]
        public IActionResult SignUp(SignUpModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
