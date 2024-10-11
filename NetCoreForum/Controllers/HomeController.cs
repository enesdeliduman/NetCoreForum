using Microsoft.AspNetCore.Mvc;
using NetCoreForum.Models;
using System.Diagnostics;

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
