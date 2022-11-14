using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bai3.Models
{
    public class Employee
    {
        [Display(Name = "Serial No")]
        public byte EmployeeId { get; set; }

        [Display(Name = "Name")]
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
