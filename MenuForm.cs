using ST10361554_PROG6212_ICE_Task_1.Classes;

namespace ST10361554_PROG6212_ICE_Task_1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        // Create an instance of the ProductMethods class
        ProductMethods methods = new ProductMethods();

        private void AddNewProductButton_Click(object sender, EventArgs e)
        {
            // Open the AddProductForm
            AddProductForm addProductForm = new AddProductForm(methods);

            // Show the AddProductForm
            addProductForm.Show();
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            // Check if there are products in the inventory
            if (methods.products.Count > 0)
            {
                // Open the UpdateProductForm
                UpdateProductForm updateProductForm = new UpdateProductForm(methods);

                // Show the UpdateProductForm
                updateProductForm.Show();
            }
            else
            {
                MessageBox.Show("No products in inventory to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayInventoryReportButton_Click(object sender, EventArgs e)
        {
            // Check if there are products in the inventory
            if (methods.products.Count > 0)
            {
                // Open the DisplayReportForm
                DisplayReportForm displayReportForm = new DisplayReportForm(methods);

                // Show the DisplayReportForm
                displayReportForm.Show();
            }
            else
            {
                MessageBox.Show("No products in inventory to generate report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessSaleButton_Click(object sender, EventArgs e)
        {
            // Check if there are products in the inventory
            if (methods.products.Count > 0)
            {
                // Open the SalesForm
                SalesForm salesForm = new SalesForm(methods);
                
                // Show the SalesForm
                salesForm.Show();
            }
            else
            {
                MessageBox.Show("No products in inventory to purchase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }
    }
}
