using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6212_ICE_Task_1.Classes
{
    public class ProductMethods
    {

         public List<Product> products = new List<Product>();

        // List of validation messages
        public List<string> validationMessages = new List<string>();

        // Method to validate product details
        public static List<string> ValidateProduct(Product product)
        {
            try
            {
                
                var results = new List<ValidationResult>();
                var context = new ValidationContext(product);
                var response = new List<string>();

                // Validate the product object
                bool isValid = Validator.TryValidateObject(product, context, results, true);

                // If the product is not valid, add the error messages to the response list
                if (!isValid)
                {
                    foreach (var vr in results)
                    {
                        response.Add(vr.ErrorMessage!);
                    }
                }
                else
                {
                    response.Add("Product is valid");
                }

                return response;
            }
            catch (Exception ex)
            {
                return new List<string> { $"Error: {ex.Message}" };
            }
        }

        //  Method Overloading: Add new grocery  product, return true if successful and false if not
        public bool AddProduct(string name, double price, int quantity, DateTime expiryDate, double weight)
        {
            try
            {
                // Create a new grocery product
                Grocery item = new Grocery(name, price, quantity, expiryDate, weight);

                validationMessages.Clear();
                
                // Validate the product
                validationMessages = ValidateProduct(item);

                // If the product is valid, add it to the list of products
                if (validationMessages[0] == "Product is valid")
                {
                    products.Add(item);
                    validationMessages.Clear();
                    SortProductsByName();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Method Overloading: Add new clothing product, return true if successful and false if not
        public bool AddProduct(string name, double price, int quantity, string size, string colour, string material, string gender)
        {
            try
            {
                // Create a new clothing product
                Clothing item = new Clothing(name, price, quantity, size, colour, material, gender);

                validationMessages.Clear();

                // Validate the product
                validationMessages = ValidateProduct(item);

                // If the product is valid, add it to the list of products
                if (validationMessages[0] == "Product is valid")
                {
                    products.Add(item);
                    validationMessages.Clear();
                    SortProductsByName();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Method Overloading: Add new electronic product, return true if successful and false if not
        public bool AddProduct(string name, double price, int quantity, string brand, string modelNumber, int powerConsumption, int warranty)
        {
            try
            {
                // Create a new electronic product
                Electronics item = new Electronics(name, price, quantity, brand, modelNumber, powerConsumption, warranty);

                validationMessages.Clear();

                // Validate the product
                validationMessages = ValidateProduct(item);

                // If the product is valid, add it to the list of products
                if (validationMessages[0] == "Product is valid")
                {
                    products.Add(item);
                    validationMessages.Clear();
                    SortProductsByName();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Method to check if stock is available, return true if available and false if not
        public bool CheckStock(Product product, int quantity)
        {
            try
            {
                bool isStockValid = false;

                // Check if the stock quantity is greater than or equal to the quantity requested
                // If it is, set isStockValid to true
                // Otherwise, return false
                if (product.StockQuantity >= quantity)
                {
                    isStockValid = true;
                }

                return isStockValid;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Dynamic method to process the sale of a product, return a string message
        public string ProcessSale(dynamic product, int quantitySold)
        {
            try
            {
                // Check if the stock is available
                bool isStockAvailable = CheckStock(product, quantitySold);

                // If the stock is available, update the stock quantity
                // Otherwise, return an error message
                if (isStockAvailable)
                {
                    product = product - quantitySold;
                    return "Sale successful";
                }
                else
                {
                    return "Insufficient stock";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        // Anonymously typed method to display the inventory report, return a list of strings
        public List<string> GenerateInventoryReport(List<Product> products)
        {
            try
            {
                // Check if the product list is not null
                if (products != null)
                {
                    // Check if there are products in the list
                    if (products.Count > 0)
                    {
                        var report = new List<string>();

                        foreach (var item in products)
                        {
                            // Add the product details to the report list
                            report.Add(item.ToString());
                        }

                        return report;
                    }
                    else
                    {
                        return new List<string> { "No products available in inventory" };
                    }
                }
                else
                {
                    return new List<string> { "Product list is null" };
                }
            }
            catch (Exception ex)
            {
                return new List<string> { $"Error: {ex.Message}" };
            }
        }

        // Method to update the stock quantity of a product, return true if successful and false if not
        public bool UpdateStockQuantity(Product product, int quantityToAdd)
        {
            try
            {
                // Check if the product is not null and the quantity to add is greater than 0
                if (product != null && quantityToAdd > 0)
                {
                    // Update the stock quantity of the product
                    // Return true if successful
                    product  = product + quantityToAdd;
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Reference: 
        // The following code utilises the OrderBy method from System.Linq to sort a list of products alphabetically by their Name property.
        // Source: dotnet-bot (2024). Enumerable.OrderBy Method (System.Linq). Microsoft.com.
        // Available at: https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby?view=net-8.0 [Accessed 22 Aug. 2024].
        public void SortProductsByName()
        {
            // Sort the products list by name in alphabetical order using LINQ
            products = products.OrderBy(p => p.Name).ToList();
        }
    }
}
