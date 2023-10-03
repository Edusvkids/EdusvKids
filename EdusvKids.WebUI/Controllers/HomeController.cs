﻿using EdusvKids.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EdusvKids.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Productos()
        {
            return View();
        }

        public IActionResult Monedas()
        {
            return View();
        }
        public IActionResult Descargar()
        {
            return View();
        }

        public IActionResult Pagar()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}