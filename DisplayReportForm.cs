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
    public partial class DisplayReportForm : Form
    {
        // variable to hold the instance of the ProductMethods class
        private readonly ProductMethods _methods;

        public DisplayReportForm(ProductMethods methods)
        {
            InitializeComponent();
            _methods = methods;

            // make the rich text box read only
            ProductsRichTextBox.ReadOnly = true;
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                // clear the rich text box
                ProductsRichTextBox.Clear();

                // generate the inventory report
                var report = _methods.GenerateInventoryReport(_methods.products);

                // if the report is null, display an error message
                if (report == null)
                {
                    MessageBox.Show("No products in inventory to generate report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // loop through the report and display the products in the rich text box
                for (int i = 0; i < report.Count; i++)
                {
                    ProductsRichTextBox.AppendText($"({i+1})\n {report[i].ToString()}\n");
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
    }
}
