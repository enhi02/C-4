using bai2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai2.Controllers
{
    public class StudentControllers : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Student Deatails Page";
            ViewData["Header"] = "Student Deatails";
            Student student = new Student() 
            { 
                StudentId = 1,
                Name = "Fpoly",
                Branch = "HCM",
                Section = "Nam Ky Khoi Nghia",
            };
            ViewData["Student"] = student;
            return View();
        }// hình như chưa coppy
    }
}
