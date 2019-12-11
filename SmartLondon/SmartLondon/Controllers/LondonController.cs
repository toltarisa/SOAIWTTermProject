using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartLondon.Utilities;

namespace SmartLondon.Controllers
{
    public class LondonController : Controller
    {
        public IActionResult Index()
        {
            var database = new DatabaseUtility();
            var getLocations = database.GetLocations();

            return Json(getLocations);
        }
    }
}