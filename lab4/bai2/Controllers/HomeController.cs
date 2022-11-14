using bai2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace bai2.Controllers
{
    [Route("Home")]

    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        [Route("")]
        [Route("Index")]
        public string Index()
        {
            return "Index() Action Method of StudentController";
        }

        [Route("Delaties/{id?}")]
        public string Delaties(int id)
        {
            return "Delaties() Action Method of StudentController and " + id.ToString();
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

    }
}
