using Microsoft.AspNetCore.Mvc;
using NetCoreForum.ViewModels.UserViewModels;

namespace NetCoreForum.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(CreateUserViewModel createUserViewModel)
        {
            if (ModelState.IsValid)
            {

            }
            return View(createUserViewModel);
        }

    }
}
