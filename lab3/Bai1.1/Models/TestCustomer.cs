using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai1._1.Models
{
    public class TestCustomer
    {
        public List<Customer> Test;
        public TestCustomer()
        {
            Test = new List<Customer>()
            {
                new Customer() { Name = "Thiết Kế Đồ Hoạ", img = "/img/dohoa.jfif" },
                new Customer() { Name = "Lập Trình Máy Tính - Thiết Bị Di Động", img = "/img/didong.png" },
                new Customer() { Name = "Thiết Kế WEBSITE", img = "/img/wedsite.jfif" },
                new Customer() { Name = "CNTT-Ứng Dụng Phần Mềm", img = "/img/udpm.jfif" }
            };
        }
    }
}
