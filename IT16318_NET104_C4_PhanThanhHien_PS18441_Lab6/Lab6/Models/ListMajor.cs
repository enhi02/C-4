using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6.Models
{
    public class ListMajor
    {
        public List<Majors> _list;
        public ListMajor()
        {
            _list = new List<Majors>()
            {
                 new Majors("/Images/designweb.png","Thiết kế website"),
                 new Majors("/Images/diencongnghiepfpoly.png","Điện tử và Tự động hóa"),
                 new Majors("/Images/QuanlyKSFpoly.png","Quản trị khách sạn"),
                  new Majors("/Images/quantrinhahangfpoly.png","Quản lý nhà hàng")
            };
        }
    }
}
