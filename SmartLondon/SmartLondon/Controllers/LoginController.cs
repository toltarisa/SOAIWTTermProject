using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SmartLondon.Utilities;

namespace SmartLondon.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName(nameof(Index))]
        [ValidateAntiForgeryToken]
        public IActionResult LoginForm(string username, string password)
        {
            DatabaseUtility database = new DatabaseUtility();

            ClaimsIdentity identity = null;
            var isUserExist = database.LoginUser(username, password);

            if (isUserExist)
            {
                //create the identity for user
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.Role, "User"),
                });

                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Home");
            }

            ViewData["userNotFound"] = "Girdiğiniz kullanıcı bilgilerinde bir kullanıcı bulunamadı.";
            return View();
        }
        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
    }
}