using bai1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace bai1.Controllers
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
            HttpContext.Session.SetString("name", "Phan Thanh Hiển");
            HttpContext.Session.SetString("email", "thanhhien@gmail.com");
            return View();    
        }

        public IActionResult About()
        {
            ViewBag.Name = HttpContext.Session.GetString("name");
            ViewBag.Name = HttpContext.Session.GetString("email");
            ViewData["Message"] = "Your about page, pleas refesh page after one minitue";
            ViewData["Title"] = "Demo session login";
            return View();
        }

        public IActionResult Privacy()
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
