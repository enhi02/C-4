using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab6_2.Models
{
    public class ListMajor
    {
        [Display(Name ="CÁC NGÀNH ĐÀO TẠO")]
        public string stringtittle { get; set; } = "CÁC NGÀNH ĐÀO TẠO";
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
