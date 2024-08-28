using Microsoft.AspNetCore.Mvc;
using TestWebSite.DB;
using TestWebSite.Models;
using TestWebSite.Models.VIewModels;

namespace TestWebSite.Controllers
{
    public class ProfileController : Controller
    {
        private readonly DataContext _dataContext;
        public ProfileController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Profile(int id)
        {
            UsersAc? user = _dataContext.UsersAca.FirstOrDefault(I => I.Id == id);
            if (user == null)
            {
                return RedirectToAction("Login", "Autorization");
            }
            ProfileViewModel prof = new ProfileViewModel() {Name = user.Login, Id = user.Id, Email = user.Email };
            return View(prof);
        }
        [HttpPost]
        public IActionResult Profile()
        {
            return  View();
        }
    }
}
