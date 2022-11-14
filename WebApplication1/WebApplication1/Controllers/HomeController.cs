using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly passmonContext _context;

        public HomeController(passmonContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var listProduct = _context.Product.ToList();
            return View(listProduct);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Product.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.fail = "Please fill again";
            }

            return View();
        }
    }
}