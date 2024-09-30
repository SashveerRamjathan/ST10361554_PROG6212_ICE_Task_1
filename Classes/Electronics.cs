using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6212_ICE_Task_1.Classes
{
    public class Electronics : Product
    {
        // Brand of the electronic product
        [Required(ErrorMessage = "Brand is required")]
        [StringLength(150, ErrorMessage = "Brand must be less than 150 characters")]
        public string Brand { get; set; }

        // Model number of the electronic product
        [Required(ErrorMessage = "Model number is required")]
        [StringLength(150, ErrorMessage = "Model number must be less than 150 characters")]
        public string ModelNumber { get; set; }

        // Warranty period of the electronic product
        [Required(ErrorMessage = "Warranty period is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Warranty period must be greater than or equal to 0")]
        public int WarrantyPeriod { get; set; }

        // Power consumption of the electronic product in watts
        [Required(ErrorMessage = "Power consumption is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Power consumption must be greater than or equal to 0")]
        public int PowerConsumption { get; set; }

        // Parameterized constructor
        public Electronics(string name, double price, int stockQuantity, string brand, string modelNumber, int powerConsumption, int warranty ) 
            : base(name, "Electronics", price, stockQuantity)
        {
            Brand = brand;
            ModelNumber = modelNumber;
            PowerConsumption = powerConsumption;
            WarrantyPeriod = warranty;
        }
    }
}
