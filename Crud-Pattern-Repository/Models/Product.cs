using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Pattern_Repository.Models
{
    public class Product
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "This {0} field is required ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This {0} field is required ")]
        public string Description { get; set; }
        [Required(ErrorMessage = "This {0} field is required ")]
        public double Cost { get; set; }
        [Required(ErrorMessage = "This {0} field is required ")]
        public double SalePrice { get; set; }
        [Required(ErrorMessage = "This {0} field is required ")]
        public int Stock { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, string description, double cost, double salePrice, int stock)
        {
            Id = id;
            Name = name;
            Description = description;
            Cost = cost;
            SalePrice = salePrice;
            Stock = stock;
        }
    }
}
