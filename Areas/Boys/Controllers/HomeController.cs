using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areas.Areas.Boys.Controllers
{
    /// <summary>
    /// This is the home controller for the Boys area.
    /// Because of the routes specified by the startup file, the app will know to go to the index method of this controller when called upon.
    /// </summary>
    [Area("Boys")]
    public class HomeController : Controller
    {
        //[Route("[area]/[controller]")]
        //Create a greeting property for the ViewBag unique to the boys area o use in the index file
        public IActionResult Index()
        {
            ViewBag.Greeting = "Boys will be boys amirite?";

            //return Content("There are 16 guys.");
            return View();
        }
    }
}
