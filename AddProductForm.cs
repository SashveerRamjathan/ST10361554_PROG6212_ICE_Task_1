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
    public partial class AddProductForm : Form
    {
        private string? _productCategory;

        // ProductMethods instance to access the AddProduct method
        private readonly ProductMethods _methods;

        public AddProductForm(ProductMethods methods)
        {
            InitializeComponent();
            _methods = methods;

            // Set the maximum value for the quantity numeric up-down control
            ProductQuantityNumericUpDown.Maximum = int.MaxValue;
        }

        private void GroceryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If the Grocery checkbox is checked, uncheck the other checkboxes
            // and set the product category to "Grocery"
            // Also, display the input fields for Grocery products
            if (GroceryCheckBox.Checked)
            {
                ElectronicCheckBox.Checked = false;
                ClothingCheckBox.Checked = false;
                _productCategory = "Grocery";
                DisplayGroceryInputs();
            }
        }

        private void ElectronicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If the Electronic checkbox is checked, uncheck the other checkboxes
            // and set the product category to "Electronics"
            // Also, display the input fields for Electronic products
            if (ElectronicCheckBox.Checked)
            {
                GroceryCheckBox.Checked = false;
                ClothingCheckBox.Checked = false;
                _productCategory = "Electronics";
                DisplayElectronicsInputs();
            }
        }

        private void ClothingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If the Clothing checkbox is checked, uncheck the other checkboxes
            // and set the product category to "Clothing"
            // Also, display the input fields for Clothing products
            if (ClothingCheckBox.Checked)
            {
                GroceryCheckBox.Checked = false;
                ElectronicCheckBox.Checked = false;
                _productCategory = "Clothing";
                DisplayClothingInputs();
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            // If no product category is selected, show a warning message and return
            if (_productCategory == null)
            {
                MessageBox.Show("Please choose a product category.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect product details
            string name = ProductNameTextBox.Text;
            string priceText = ProductPriceTextBox.Text;
            int quantity = (int)ProductQuantityNumericUpDown.Value;
            double price = 0;

            // Validate common fields
            List<string> errorMessages = new List<string>();

            // Check if the name is empty
            if (string.IsNullOrWhiteSpace(name))
            {
                errorMessages.Add("Product Name is required.");
            }

            // Check if the price is empty or invalid
            if (string.IsNullOrWhiteSpace(priceText) || !double.TryParse(priceText, out price))
            {
                errorMessages.Add("Valid Product Price is required.");
            }

            try
            {
                bool result = false;

                // Add product based on the selected category
                if (GroceryCheckBox.Checked)
                {
                    DateTime expiryDate;
                    double weight;

                    // Check if the expiry date is valid
                    if (!DateTime.TryParse(InputPanel.Controls[1].Text, out expiryDate))
                    {
                        errorMessages.Add("Expiry Date is invalid.");
                    }

                    // Check if the weight is valid
                    if (!double.TryParse(InputPanel.Controls[3].Text, out weight))
                    {
                        errorMessages.Add("Enter a valid value for weight");
                    }

                    // If there are no errors, add the product
                    if (errorMessages.Count == 0)
                    {
                        result = _methods.AddProduct(name, price, quantity, expiryDate, weight);
                    }
                    else
                    {
                        // Display errors
                        if (errorMessages.Any())
                        {
                            MessageBox.Show(string.Join("\n", errorMessages), "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                else if (ElectronicCheckBox.Checked)
                {
                    // Collect electronic product details
                    string brand = InputPanel.Controls[1].Text;
                    string modelNumber = InputPanel.Controls[3].Text;
                    int warrantyPeriod = 0;
                    int powerConsumption = 0;

                    // Check if the brand is empty
                    if (string.IsNullOrEmpty(brand))
                    {
                        errorMessages.Add("Product brand is required.");
                    }

                    // Check if the model number is empty
                    if (string.IsNullOrEmpty(modelNumber))
                    {
                        errorMessages.Add("Product model number is required.");
                    }

                    // Check if the warranty period is empty or invalid
                    if (string.IsNullOrEmpty(InputPanel.Controls[5].Text) || !int.TryParse(InputPanel.Controls[5].Text, out warrantyPeriod))
                    {
                        errorMessages.Add("Enter a valid warranty period");
                    }

                    // Check if the power consumption is empty or invalid
                    if (string.IsNullOrEmpty(InputPanel.Controls[7].Text) || !int.TryParse(InputPanel.Controls[7].Text, out powerConsumption))
                    {
                        errorMessages.Add("Enter a valid power consumption value");
                    }

                    // If there are no errors, add the product
                    if (errorMessages.Count == 0)
                    {
                        result = _methods.AddProduct(name, price, quantity, brand, modelNumber, powerConsumption, warrantyPeriod);
                    }
                    else
                    {
                        // Display errors
                        if (errorMessages.Any())
                        {
                            MessageBox.Show(string.Join("\n", errorMessages), "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                }
                else if (ClothingCheckBox.Checked)
                {
                    // Collect clothing product details
                    string size = InputPanel.Controls[1].Text;
                    string colour = InputPanel.Controls[3].Text;
                    string material = InputPanel.Controls[5].Text;
                    string gender = InputPanel.Controls[7].Text;

                    // Check if the size is empty
                    if (string.IsNullOrEmpty(size))
                    {
                        errorMessages.Add("Choose a valid size for the clothing product");
                    }

                    // Check if the colour is empty
                    if (string.IsNullOrEmpty(colour))
                    {
                        errorMessages.Add("Product colour is required.");
                    }

                    // Check if the material is empty
                    if (string.IsNullOrEmpty(material))
                    {
                        errorMessages.Add("Product material is required.");
                    }

                    // Check if the gender choice is empty
                    if (string.IsNullOrEmpty(gender))
                    {
                        errorMessages.Add("Choose a valid gender suitability for the clothing product");
                    }

                    // If there are no errors, add the product
                    if (errorMessages.Count == 0)
                    {
                        result = _methods.AddProduct(name, price, quantity, size, colour, material, gender);
                    }
                    else
                    {
                        // Display errors
                        if (errorMessages.Any())
                        {
                            MessageBox.Show(string.Join("\n", errorMessages), "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                }

                // If the product was added successfully, show a success message and clear the input fields
                if (result)
                {
                    ClearInputPanel();
                    ProductNameTextBox.Clear();
                    ProductPriceTextBox.Clear();
                    ProductQuantityNumericUpDown.Value = 0;
                    GroceryCheckBox.Checked = false;
                    ElectronicCheckBox.Checked = false;
                    ClothingCheckBox.Checked = false;
                    _productCategory = null;

                    MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void ClearInputPanel()
        {
            // Clear the input panel
            InputPanel.Controls.Clear();
        }

        // Reference:
        // The following methods add controls to the form programmatically at run time without using the designer.
        // Source: adegeo (2022). Add Controls Without a User Interface - Windows Forms .NET Framework. Microsoft.com.
        // Available at: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-add-controls-without-a-user-interface-to-windows-forms?view=netframeworkdesktop-4.8 [Accessed 22 Aug. 2024].
        private void DisplayGroceryInputs()
        {
            ClearInputPanel();

            Font labelFont = new Font("Segoe UI Semibold", 9, FontStyle.Bold);

            // Define the width for the input fields (spanning the width of the panel minus margins)
            int inputWidth = InputPanel.ClientSize.Width - 20; // Margin of 10 on each side

            // Expiry Date Label [0]
            Label lblExpiryDate = new Label
            {
                Text = "Expiry Date:",
                Location = new Point(10, 10),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = labelFont,
                Width = inputWidth
            };
            // Expiry Date Picker [1]
            DateTimePicker dtpExpiryDate = new DateTimePicker
            {
                Location = new Point(10, 30), // Below the label
                Format = DateTimePickerFormat.Short,
                Width = inputWidth
            };

            // Weight Label [2]
            Label lblWeight = new Label
            {
                Text = "Weight (grams):",
                Location = new Point(10, 70),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = labelFont,
                Width = inputWidth
            };
            // Weight TextBox [3]
            TextBox txtWeight = new TextBox
            {
                Location = new Point(10, 90), // Below the label
                Width = inputWidth
            };

            // Add controls to the InputPanel
            InputPanel.Controls.Add(lblExpiryDate);
            InputPanel.Controls.Add(dtpExpiryDate);
            InputPanel.Controls.Add(lblWeight);
            InputPanel.Controls.Add(txtWeight);
        }

        private void DisplayElectronicsInputs()
        {
            ClearInputPanel();

            Font labelFont = new Font("Segoe UI Semibold", 9, FontStyle.Bold);

            // Define the width for the input fields (spanning the width of the panel minus margins)
            int inputWidth = InputPanel.ClientSize.Width - 20; // Margin of 10 on each side

            // Brand Label [0]
            Label lblBrand = new Label
            {
                Text = "Brand:",
                Location = new Point(10, 10),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = labelFont,
                Width = inputWidth
            };
            // Brand TextBox [1]
            TextBox txtBrand = new TextBox
            {
                Location = new Point(10, 30),
                Width = inputWidth
            };

            // Model Number Label [2]
            Label lblModelNumber = new Label
            {
                Text = "Model Number:",
                Location = new Point(10, 70),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = labelFont,
                Width = inputWidth
            };
            // Model Number TextBox [3]
            TextBox txtModelNumber = new TextBox
            {
                Location = new Point(10, 90),
                Width = inputWidth
            };

            // Warranty Period Label [4]
            Label lblWarrantyPeriod = new Label
            {
                Text = "Warranty Period (months):",
                Location = new Point(10, 130),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = labelFont,
                Width = inputWidth
            };
            // Warranty Period TextBox [5]
            TextBox txtWarrantyPeriod = new TextBox
            {
                Location = new Point(10, 150),
                Width = inputWidth
            };

            // Power Consumption Label [6]
            Label lblPowerConsumption = new Label
            {
                Text = "Power Consumption (Watts):",
                Location = new Point(10, 190),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = labelFont,
                Width = inputWidth
            };
            // Power Consumption TextBox [7]
            TextBox txtPowerConsumption = new TextBox
            {
                Location = new Point(10, 210),
                Width = inputWidth
            };

            // Add controls to the InputPanel
            InputPanel.Controls.Add(lblBrand);
            InputPanel.Controls.Add(txtBrand);
            InputPanel.Controls.Add(lblModelNumber);
            InputPanel.Controls.Add(txtModelNumber);
            InputPanel.Controls.Add(lblWarrantyPeriod);
            InputPanel.Controls.Add(txtWarrantyPeriod);
            InputPanel.Controls.Add(lblPowerConsumption);
            InputPanel.Controls.Add(txtPowerConsumption);
        }

        private void DisplayClothingInputs()
        {
            ClearInputPanel();

            Font labelFont = new Font("Segoe UI Semibold", 9, FontStyle.Bold);

            // Define the width for the input fields (spanning the width of the panel minus margins)
            int inputWidth = InputPanel.ClientSize.Width - 20; // Margin of 10 on each side

            // Size Label [0]
            Label lblSize = new Label
            {
                Text = "Size:",
                Location = new Point(10, 10),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = labelFont,
                Width = inputWidth
            };
            // Size ComboBox [1]
            ComboBox cmbSize = new ComboBox
            {
                Location = new Point(10, 30),
                Width = inputWidth,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbSize.Items.AddRange(new string[] { "XS", "S", "M", "L", "XL", "XXL" });

            // Colour Label [2]
            Label lblColour = new Label
            {
                Text = "Colour:",
                Location = new Point(10, 70),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = labelFont,
                Width = inputWidth
            };
            // Colour TextBox [3]
            TextBox txtColour = new TextBox
            {
                Location = new Point(10, 90),
                Width = inputWidth
            };

            // Material Label [4]
            Label lblMaterial = new Label
            {
                Text = "Material:",
                Location = new Point(10, 130),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = labelFont,
                Width = inputWidth
            };
            // Material TextBox [5]
            TextBox txtMaterial = new TextBox
            {
                Location = new Point(10, 150),
                Width = inputWidth
            };

            // Gender Label [6]
            Label lblGender = new Label
            {
                Text = "Gender:",
                Location = new Point(10, 190),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = labelFont,
                Width = inputWidth
            };
            // Gender ComboBox [7]
            ComboBox cmbGender = new ComboBox
            {
                Location = new Point(10, 210),
                Width = inputWidth,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbGender.Items.AddRange(new string[] { "Male", "Female", "Unisex" });

            // Add controls to the InputPanel
            InputPanel.Controls.Add(lblSize);
            InputPanel.Controls.Add(cmbSize);
            InputPanel.Controls.Add(lblColour);
            InputPanel.Controls.Add(txtColour);
            InputPanel.Controls.Add(lblMaterial);
            InputPanel.Controls.Add(txtMaterial);
            InputPanel.Controls.Add(lblGender);
            InputPanel.Controls.Add(cmbGender);
        }



    }
}
