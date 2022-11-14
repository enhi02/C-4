using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai1.controller
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Index() Action Method of StudentController";
        }
        public string Details(string id)
        {
            return "Details() Action Method of StudentController and " + id.ToString();

        }
    }
}
