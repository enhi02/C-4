using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab7.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int IdCat { get; set; }
        public string NameCat { get; set; }
        public string imagesCat { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
