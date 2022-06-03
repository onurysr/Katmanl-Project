using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class DersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
