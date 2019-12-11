using Microsoft.AspNetCore.Mvc;
using SmartLondon.Utilities;

namespace SmartLondon.Controllers
{
    public class LondonMapsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string searchKey)
        {
            var database = new DatabaseUtility();

            var getLocations = database.GetLocations();

            return Json(getLocations);
        }

        public IActionResult London(string district)
        {
            ViewData["district"] = district;

            return View();
        }
    }
}