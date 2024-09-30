namespace ST10361554_PROG6212_ICE_Task_1
{
    partial class UpdateProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProductForm));
            TitleLabel = new Label();
            ProductsListBox = new ListBox();
            ProductQuantityNumericUpDown = new NumericUpDown();
            ProductQuantityLabel = new Label();
            CloseButton = new Button();
            UpdateProductButton = new Button();
            ProductsListBoxLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(12, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(193, 25);
            TitleLabel.TabIndex = 2;
            TitleLabel.Text = "Update Product Stock";
            // 
            // ProductsListBox
            // 
            ProductsListBox.FormattingEnabled = true;
            ProductsListBox.ItemHeight = 15;
            ProductsListBox.Location = new Point(12, 73);
            ProductsListBox.Name = "ProductsListBox";
            ProductsListBox.Size = new Size(493, 244);
            ProductsListBox.TabIndex = 3;
            // 
            // ProductQuantityNumericUpDown
            // 
            ProductQuantityNumericUpDown.Location = new Point(12, 354);
            ProductQuantityNumericUpDown.Name = "ProductQuantityNumericUpDown";
            ProductQuantityNumericUpDown.Size = new Size(314, 23);
            ProductQuantityNumericUpDown.TabIndex = 13;
            // 
            // ProductQuantityLabel
            // 
            ProductQuantityLabel.AutoSize = true;
            ProductQuantityLabel.BackColor = Color.Transparent;
            ProductQuantityLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ProductQuantityLabel.ForeColor = Color.White;
            ProductQuantityLabel.Location = new Point(12, 336);
            ProductQuantityLabel.Name = "ProductQuantityLabel";
            ProductQuantityLabel.Size = new Size(224, 15);
            ProductQuantityLabel.TabIndex = 12;
            ProductQuantityLabel.Text = "Enter the quantity  you would like to add:";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Firebrick;
            CloseButton.Location = new Point(667, 402);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(121, 36);
            CloseButton.TabIndex = 16;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // UpdateProductButton
            // 
            UpdateProductButton.BackColor = Color.LimeGreen;
            UpdateProductButton.Location = new Point(12, 402);
            UpdateProductButton.Name = "UpdateProductButton";
            UpdateProductButton.Size = new Size(121, 36);
            UpdateProductButton.TabIndex = 15;
            UpdateProductButton.Text = "Update Quantity";
            UpdateProductButton.UseVisualStyleBackColor = false;
            UpdateProductButton.Click += UpdateProductButton_Click;
            // 
            // ProductsListBoxLabel
            // 
            ProductsListBoxLabel.AutoSize = true;
            ProductsListBoxLabel.BackColor = Color.Transparent;
            ProductsListBoxLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ProductsListBoxLabel.ForeColor = Color.White;
            ProductsListBoxLabel.Location = new Point(12, 55);
            ProductsListBoxLabel.Name = "ProductsListBoxLabel";
            ProductsListBoxLabel.Size = new Size(338, 15);
            ProductsListBoxLabel.TabIndex = 17;
            ProductsListBoxLabel.Text = "Select the product you want to update from the list box below:";
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WarehouseBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ProductsListBoxLabel);
            Controls.Add(CloseButton);
            Controls.Add(UpdateProductButton);
            Controls.Add(ProductQuantityNumericUpDown);
            Controls.Add(ProductQuantityLabel);
            Controls.Add(ProductsListBox);
            Controls.Add(TitleLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Inventory Management System: Update Product";
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private ListBox ProductsListBox;
        private NumericUpDown ProductQuantityNumericUpDown;
        private Label ProductQuantityLabel;
        private Button CloseButton;
        private Button UpdateProductButton;
        private Label ProductsListBoxLabel;
    }
}