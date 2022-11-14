using bai3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai3.Controllers
{
    public class EmployeeControllers : Controller
    {
        List<Models.Employee> emp = new List<Employee>
        {
            new Employee
            {
                EmployeeId = 2,
                EmployeeName = "FpolyHCM",
                Address = "391A Nam Kỳ Khởi Nghĩa, Phường 8, Quận 3, Hồ Chí Minh ",
                Phone = "028 3526 8799"
            },
            new Employee
            {
                EmployeeId = 3,
                EmployeeName = "FpolyHCM",
                Address = "391A Nam Kỳ Khởi Nghĩa, Phường 8, Quận 3, Hồ Chí Minh ",
                Phone = "028 3526 8799"
            },
            new Employee
            {
                EmployeeId = 1,
                EmployeeName = "FpolyHCM",
                Address = "391A Nam Kỳ Khởi Nghĩa, Phường 8, Quận 3, Hồ Chí Minh ",
                Phone = "028 3526 8799"
            },
            new Employee
            {
                EmployeeId = 4,
                EmployeeName = "FpolyHCM",
                Address = "391A Nam Kỳ Khởi Nghĩa, Phường 8, Quận 3, Hồ Chí Minh ",
                Phone = "028 3526 8799"
            },
            new Employee
            {
                EmployeeId = 5,
                EmployeeName = "FpolyHCM",
                Address = "391A Nam Kỳ Khởi Nghĩa, Phường 8, Quận 3, Hồ Chí Minh ",
                Phone = "028 3526 8799"
            }
        };
        ViewBag.employee = emp;
        return View();
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
