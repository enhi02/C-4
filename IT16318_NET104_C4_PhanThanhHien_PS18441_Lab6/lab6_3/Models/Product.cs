using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab6_3.Models
{
    public class Product
    {
        [Required]
        [MaxLength(30)]
        public string ProductName { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]

        public float Price { get; set; }


        [Range(0, 1000, ErrorMessage = "Please enter valid integer Number")]
        public int Quantity { get; set; }
    }
}
