﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areas.Areas.Teachers.Controllers
{
    [Area("Teachers")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Greeting = "Hello Teachers!";

            return View();
        }
    }
}
