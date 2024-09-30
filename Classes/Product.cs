using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6212_ICE_Task_1.Classes
{
    public class Product
    {
        // GUID for the product
        [Required(ErrorMessage = "Product ID is required")]
        public string ProductID { get; set; }

        // Name of the product
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(150, ErrorMessage = "Product name must be less than 150 characters")]
        public string Name { get; set; }

        // Category of the product
        [Required(ErrorMessage = "Product category is required")]
        public string Category { get; set; }

        // Price of the product
        [Required(ErrorMessage = "Product price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public double Price { get; set; }

        // Stock quantity of the product
        [Required(ErrorMessage = "Product stock quantity is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity must be greater than or equal to 0")]
        public int StockQuantity { get; set; }


        // Parameterized constructor
        public Product(string name, string category, double price, int stockQuantity)
        {
            ProductID = GenerateProductID();
            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockQuantity;
        }

        // Overloaded + operator to add stock quantity
        public static Product operator +(Product product, int quantity)
        {
            product.StockQuantity += quantity;

            return product;
        }

        // Overloaded - operator to subtract stock quantity
        public static Product operator -(Product product, int quantity)
        {
            product.StockQuantity -= quantity;

            return product;
        }

        // Generate a GUID for the product
        protected string GenerateProductID()
        {
            return Guid.NewGuid().ToString();
        }

        // Override the ToString method to display the product details
        public override string ToString()
        {
            return $"Name: {Name} \nCategory: {Category} \nStock Quantity: {StockQuantity} unit(s)\n";
        }
    }
}
