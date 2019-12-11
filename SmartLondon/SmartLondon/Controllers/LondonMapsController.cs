using Microsoft.AspNetCore.Mvc;

namespace SmartLondon.Controllers
{
    public class LondonMapsController : Controller
    {
        public IActionResult Index(string searchKey)
        {
            if (string.IsNullOrWhiteSpace(searchKey))
                return View();
            else
                return RedirectToAction("Index", "Home");
        }
    }
}