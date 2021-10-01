using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areas.Areas.Boys.Controllers
{
    [Area("Boys")]
    public class HomeController : Controller
    {
        //[Route("[area]/[controller]")]
        public IActionResult Index()
        {
            ViewBag.Greeting = "Boys will be boys amirite?";

            //return Content("There are 16 guys.");
            return View();
        }
    }
}
