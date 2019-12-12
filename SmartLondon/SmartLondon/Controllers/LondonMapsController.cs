using Microsoft.AspNetCore.Mvc;
using SmartLondon.Models;
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
            var database = new DatabaseUtility();
            var detailView = new DetailView()
            {
                Safety = database.GetSafety(district),
                School = database.GetSchools(district),
                GreenSpace = database.GetGreenSpace(district),
                RentPerMonth = database.GetRentPerMonth(district),
                TravelInfo = database.GetTravelInfo(district),
                GeneralDescription = database.GetGeneralDescription(district)

            };

            return View(detailView);
        }
    }
}