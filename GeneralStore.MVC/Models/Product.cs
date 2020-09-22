using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    // the class that represents the fields in the database table that will store the products in the general store application.
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "# In Stock")]
        public int InventoryCount { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Food Item")]
        public bool IsFood { get; set; }

    }
}