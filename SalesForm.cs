using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ST10361554_PROG6212_ICE_Task_1.Classes;

namespace ST10361554_PROG6212_ICE_Task_1
{
    public partial class SalesForm : Form
    {
        // ProductMethods instance to access the products list
        private readonly ProductMethods _methods;

        public SalesForm(ProductMethods methods)
        {
            InitializeComponent();
            _methods = methods;

            // Populate the products list
            PopulateProducts();

            // Set the maximum value of the numeric up down control to the maximum value of an integer
            ProductQuantityNumericUpDown.Maximum = int.MaxValue;
        }

        private void PurchaseProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected index of the product
                int index = ProductsListBox.SelectedIndex;

                // Check if a product is selected
                // If not, show a message box and return
                if (index == -1)
                {
                    MessageBox.Show("Please select a product to purchase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the product at the selected index
                var product = _methods.products[index];

                // Check if the product is null
                // If it is, show a message box and return
                if (product == null)
                {
                    MessageBox.Show("Product could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the quantity of the product to purchase
                int quantity = (int)ProductQuantityNumericUpDown.Value;

                // Check if the quantity is 0
                // If it is, show a message box and return
                if (quantity == 0)
                {
                    MessageBox.Show("Enter a quantity greater than 0 to purchase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Process the sale
                var result = _methods.ProcessSale(product, quantity);

                // Show a message box with the result of the transaction
                // If the transaction was successful, show a success message box
                // If the transaction was not successful, show an error message box
                MessageBox.Show($"{result}", "Transaction Status", MessageBoxButtons.OK, result.Equals("Sale successful") ? MessageBoxIcon.Information : MessageBoxIcon.Exclamation);

                // Populate the products list, to update the stock quantity
                PopulateProducts();

                // Reset the quantity numeric up down control
                ProductQuantityNumericUpDown.Value = 0;
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void PopulateProducts()
        {
            // Clear the products list box
            ProductsListBox.Items.Clear();

            // Add each product to the products list box
            for (int i = 0; i < _methods.products.Count; i++)
            {
                ProductsListBox.Items.Add($"({i+1}) {_methods.products[i].Name}, {_methods.products[i].StockQuantity} units");
            }
        }
    }
}
