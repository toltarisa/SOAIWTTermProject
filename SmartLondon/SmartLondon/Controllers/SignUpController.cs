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
                ViewData["userExist"] =
                    "Girdiğiniz kullanıcı adı daha önce alınmış, lütfen başka bir kullanıcı adı deneyiniz.";
                return View();
            }

            database.RegisterUser(username, email, password);
            ViewData["registerSuccess"] = "Başarılı bir şekilde kayıt oldunuz.";
            return View();
        }
    }
}