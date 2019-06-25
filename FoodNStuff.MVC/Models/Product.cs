using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodNStuff.MVC.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "ID:")]
        public int ProductID { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Amount in Stock")]
        public int InventoryCount { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Food Product")]
        public bool IsFood { get; set; }

    }
}