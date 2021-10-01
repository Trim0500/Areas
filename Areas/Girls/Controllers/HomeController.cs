using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areas.Areas.Girls.Controllers
{
    [Area("Girls")]
    public class HomeController : Controller
    {
        //[Route("[area]/[controller]")]
        public IActionResult Index()
        {
            ViewBag.Greeting = "Girls just want to have fun";

            //return Content("There are 2 girls.");
            return View();
        }
    }
}
