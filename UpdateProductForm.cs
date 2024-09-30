using ST10361554_PROG6212_ICE_Task_1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10361554_PROG6212_ICE_Task_1
{
    public partial class UpdateProductForm : Form
    {
        // variable to hold the instance of the ProductMethods class
        private readonly ProductMethods _methods;

        public UpdateProductForm(ProductMethods methods)
        {
            InitializeComponent();
            _methods = methods;
            PopulateProducts();

            // set the maximum value of the numeric up down control to the maximum value of an integer
            ProductQuantityNumericUpDown.Maximum = int.MaxValue;
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                // get the index of the selected product
                int index = ProductsListBox.SelectedIndex;

                // check if a product has been selected,
                // if not, display a message to the user and return
                if (index == -1)
                {
                    MessageBox.Show("Please select a product to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // get the product at the selected index
                var product = _methods.products[index];

                // check if the product exists,
                // if not, display a message to the user and return
                if (product == null)
                {
                    MessageBox.Show("Product could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // get the quantity of the product to update
                int quantity = (int)ProductQuantityNumericUpDown.Value;

                // Update the stock quantity of the product
                var result = _methods.UpdateStockQuantity(product, quantity);

                // display a message to the user based on the result of the update
                if (result)
                {
                    MessageBox.Show("Product stock quantity updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateProducts();
                    ProductQuantityNumericUpDown.Value = 0;
                    return;
                }
                else
                {
                    MessageBox.Show("Product stock quantity could not be updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
        
        // method to populate the products list box
        private void PopulateProducts()
        {
            // clear the items in the products list box
            ProductsListBox.Items.Clear();

            // loop through the products list and add each product to the products list box
            for (int i = 0; i < _methods.products.Count; i++)
            {
                ProductsListBox.Items.Add($"({i+1}) {_methods.products[i].Name}, {_methods.products[i].StockQuantity} units");
            }
        }
    }
}
