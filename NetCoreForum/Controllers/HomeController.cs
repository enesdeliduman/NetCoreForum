using Microsoft.AspNetCore.Mvc;
using NetCoreForum.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace NetCoreForum.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
