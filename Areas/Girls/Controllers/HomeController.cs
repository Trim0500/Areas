using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areas.Areas.Girls.Controllers
{
    /// <summary>
    /// This is the home controller for the Girls area.
    /// Because of the routes specified by the startup file, the app will know to go to the index method of this controller when called upon.
    /// </summary>
    [Area("Girls")]
    public class HomeController : Controller
    {
        //[Route("[area]/[controller]")]
        //Create a greeting property for the ViewBag unique to the boys area o use in the index file
        public IActionResult Index()
        {
            ViewBag.Greeting = "Girls just want to have fun";

            //return Content("There are 2 girls.");
            return View();
        }
    }
}
