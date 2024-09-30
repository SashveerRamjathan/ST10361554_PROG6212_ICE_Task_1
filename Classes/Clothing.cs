using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6212_ICE_Task_1.Classes
{
    public class Clothing : Product
    {
        // Size of the clothing product (e.g S, M, L, XL)
        [Required(ErrorMessage = "Size is required")]
        [StringLength(10, ErrorMessage = "Size must be less than 10 characters")]
        public string Size { get; set; }

        // Colour of the clothing product
        [Required(ErrorMessage = "Colour is required")]
        [StringLength(75, ErrorMessage = "Colour must be less than 75 characters")]
        public string Colour { get; set; }

        // Material of the clothing product
        [Required(ErrorMessage = "Material is required")]
        [StringLength(150, ErrorMessage = "Material must be less than 150 characters")]
        public string Material { get; set; }

        // Gender suitability of the clothing product (e.g., Men, Women, Unisex)
        [Required(ErrorMessage = "Gender suitability of the clothing product is required")]
        [StringLength(50, ErrorMessage = "Gender suitability of the clothing product must be less than 50 characters")]
        public string Gender { get; set; }

        // Parameterized constructor
        public Clothing(string name, double price, int stockQuantity, string size, string colour, string material, string gender) 
            : base(name, "Clothing", price, stockQuantity)
        {
            Size = size;
            Colour = colour;
            Material = material;
            Gender = gender;
        }
    }
}
