using Microsoft.AspNetCore.Mvc;

namespace TestWebSite.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
