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

            return new ContentResult()
            {
                Content = "Hello from the beers controller!"
            };

        }
    }
}