using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab7.Models
{
    public partial class Products
    {
        public long ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Color { get; set; }
        public decimal UnitPrice { get; set; }
        public long AvailableQuantity { get; set; }
        public DateTime CreateDate { get; set; }
        public int? IdCat { get; set; }
        [Display(Name ="Image")]
        public string Img { get; set; }

        public virtual Categories IdCatNavigation { get; set; }
    }
}
