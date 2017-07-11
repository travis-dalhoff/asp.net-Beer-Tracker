using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerTracker.Controllers
{
    public class BeersController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.BeerName = "Breakfast Stout";
            ViewBag.BreweryName = "Founders";
            ViewBag.Style = "Imperial Stout";
            ViewBag.Ibu = 60;
            ViewBag.Abv = 8.3;
            ViewBag.Description = "<p>Really good beer!</p>";

            return View();

        }
    }
}