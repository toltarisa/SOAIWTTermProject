using Microsoft.AspNetCore.Mvc;
using SmartLondon.Utilities;

namespace SmartLondon.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName(nameof(Index))]
        [ValidateAntiForgeryToken]
        public IActionResult SignUpForm(string username, string email, string password)
        {
            var database = new DatabaseUtility();
            var isUserExist = database.IsUserExist(username);

            if (isUserExist)
            {
                ViewData["userExist"] = "Username already exist. Please type a new username";
                return View();
            }

            database.RegisterUser(username, email, password);
            ViewData["registerSuccess"] = "Register successfully";
            return View();
        }
    }
}