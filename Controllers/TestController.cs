﻿using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
