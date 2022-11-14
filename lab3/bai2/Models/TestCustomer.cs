using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai2.Models
{
    public class TestCustomer
    {
        public List<Customer> _customerList;

        public TestCustomer()
        {
            _customerList = new List<Customer>()
            {
                new Customer() {Images = "/img/didong.png",Ten = "iPhone one Pro Max 64gb",GiaGop = "Chỉ từ 1.512.000đ/ tháng", Gia = "18.390.000 đ",DanhGia ="img/67dg.PNG", ManHinh = "OLED6.5 Super Retina XDR", Camera = "1 camera 12 MP", Pin = "3969 mAh", Ram = "4 GB", CPU = "Apple A13 Bionic", HeDH = "Bao đền"},
                new Customer() {Images = "/img/dohoa.jfif",Ten = "iPhone two Pro Max 256gb",GiaGop = "Chỉ từ 1.689.000đ/ tháng", Gia = "18.390.000 đ",DanhGia ="img/439dg.PNG", ManHinh = "OLED6.5 Super Retina XDR", Camera = "1 camera 12 MP", Pin = "3969 mAh", Ram = "4 GB", CPU = "Apple A13 Bionic", HeDH = "Bao đền"},
                new Customer() {Images = "/img/udpm.jfif",Ten = "iPhone tree 128gb",GiaGop = "Chỉ từ 1.565.000đ/ tháng", Gia = "23.490.000 đ", DanhGia ="img/67dg.PNG", ManHinh = "OLED6.1Super Retina XDR", Camera = "1 camera 12 MP", Pin = "3240 mAh", Ram = "4 GB", CPU = "Apple A15 Bionic", HeDH = "Bao đền"},
                new Customer() {Images = "/img/wedsite.jfif",Ten = "iPhone Four Pro Max 256gb",GiaGop = "Chỉ từ 1.653.000đ/ tháng", Gia = "32.490.000 đ", DanhGia ="img/439dg.PNG",ManHinh = "OLED6.7 Super Retina XDR", Camera = "1 camera 12 MP", Pin = "4352 mAh", Ram = "6 GB", CPU = "Apple A15 Bionic", HeDH = "Bao đền"}

            };

        }
    }
}
