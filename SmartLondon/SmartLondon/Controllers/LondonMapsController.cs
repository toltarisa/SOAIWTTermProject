using Microsoft.AspNetCore.Mvc;
using SmartLondon.Models;
using SmartLondon.Utilities;
using System;

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
                GeneralDescription = database.GetGeneralDescription(district),
                SchoolCount = database.GetSchoolCount(district),
                GetAverageTax = database.GetAverageTax(district),
            };

            ViewData["districtName"] = district;

            double safety = Convert.ToDouble(detailView.Safety);
            detailView.SafetyPercentage = safety * 100;

            return View(detailView);
        }

        [HttpPost, ActionName("London")]
        public IActionResult LondonForm(string districtName, string content)
        {
            var database = new DatabaseUtility();
            var username = User.Identity.Name;
            var userId = database.GetUserId(username);

            database.AddAComment(districtName, userId, content);

            return RedirectToAction("Index", "Home");
        }
    }
}