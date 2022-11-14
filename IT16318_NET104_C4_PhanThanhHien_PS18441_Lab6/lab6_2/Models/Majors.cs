using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6_2.Models
{
    public class Majors
    {
        public string img { get; set; }
        public string name { get; set; }
        public Majors(string img, string name)
        {
            this.img = img;
            this.name = name;
        }
    }
}
