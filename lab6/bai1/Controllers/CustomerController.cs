using bai1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            TestCustomer cus = new TestCustomer();
            return View(cus);
        }
    }
}
