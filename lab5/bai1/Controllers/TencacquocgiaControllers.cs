using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai1.Controllers
{
    public class TencacquocgiaControllers : Controller
    {
        public IActionResult London()
        {
            return View();
        }
        public IActionResult Paris()
        {
            return View();
        }
        public IActionResult Tokyo()
        {
            return View();
        }
    }
}
