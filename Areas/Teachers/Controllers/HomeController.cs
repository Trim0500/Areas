using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areas.Areas.Teachers.Controllers
{
    /// <summary>
    /// This is the home controller for the Teachers area.
    /// Because of the routes specified by the startup file, the app will know to go to the index method of this controller when called upon.
    /// </summary>
    [Area("Teachers")]
    public class HomeController : Controller
    {
        //Create a greeting property for the ViewBag unique to the boys area o use in the index file
        public IActionResult Index()
        {
            ViewBag.Greeting = "Hello Teachers!";

            return View();
        }
    }
}
