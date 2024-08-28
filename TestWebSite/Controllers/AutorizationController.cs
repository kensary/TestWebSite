using Microsoft.AspNetCore.Mvc;
using TestWebSite.DB;
using TestWebSite.Models.VIewModels;
using TestWebSite.Models;


namespace TestWebSite.Controllers
{
    public class AutorizationController : Controller
    {
        private readonly DataContext _dataContext;
        public AutorizationController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginModel)
        {
            UsersAc? user = _dataContext.UsersAca.FirstOrDefault(I => I.Login == loginModel.Login && I.Password == loginModel.Password);
            if (user == null)
            {
                return View(); 
            }
            return RedirectToAction("Profile","Profile",new { user.Id });
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel registerModel)
        {
            if (registerModel.Password == registerModel.CopyPassword && registerModel.Login.Length < 30 && registerModel.Password.Length > 6)
            {
                if (registerModel.Login.Length > 4 && registerModel.Login.Length <20)
                {
                    if (_dataContext.UsersAca.FirstOrDefault(I => I.Login == registerModel.Login) == null)
                    {
                        UsersAc user = new UsersAc() { Login = registerModel.Login , Email = registerModel.Email, Password = registerModel.Password};
                        _dataContext.UsersAca.Add(user);
                        _dataContext.SaveChanges();
                        return RedirectToAction("Login");
                    }
                }
            }
            return View();
        }
    }
}
