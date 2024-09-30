using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6212_ICE_Task_1.Classes
{
    public class Grocery : Product
    {
        // Expiry date of the grocery product
        [Required(ErrorMessage = "Expiry date is required")]
        public DateTime ExpiryDate { get; set; }

        // Weight of the grocery product in grams
        [Required(ErrorMessage = "Weight is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Weight must be greater than 0")]
        public double Weight { get; set; }

        // Parameterized constructor
        public Grocery(string name, double price, int stockQuantity, DateTime expiryDate, double weight) 
            : base(name, "Groceries", price, stockQuantity)
        {
            ExpiryDate = expiryDate;
            Weight = weight;
        }
    }
}
