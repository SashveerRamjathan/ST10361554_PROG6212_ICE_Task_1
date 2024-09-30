namespace ST10361554_PROG6212_ICE_Task_1
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            TitleLabel = new Label();
            ProductCategoryLabel = new Label();
            GroceryCheckBox = new CheckBox();
            ElectronicCheckBox = new CheckBox();
            ClothingCheckBox = new CheckBox();
            ProductNameLabel = new Label();
            ProductNameTextBox = new TextBox();
            ProductPriceTextBox = new TextBox();
            ProductPriceLabel = new Label();
            ProductQuantityLabel = new Label();
            ProductQuantityNumericUpDown = new NumericUpDown();
            AddProductButton = new Button();
            CloseButton = new Button();
            InputPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(12, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(173, 28);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Add New Product";
            // 
            // ProductCategoryLabel
            // 
            ProductCategoryLabel.AutoSize = true;
            ProductCategoryLabel.BackColor = Color.Transparent;
            ProductCategoryLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ProductCategoryLabel.ForeColor = Color.White;
            ProductCategoryLabel.Location = new Point(12, 56);
            ProductCategoryLabel.Name = "ProductCategoryLabel";
            ProductCategoryLabel.Size = new Size(314, 15);
            ProductCategoryLabel.TabIndex = 2;
            ProductCategoryLabel.Text = "Choose the category of the product you would like to add:";
            // 
            // GroceryCheckBox
            // 
            GroceryCheckBox.AutoSize = true;
            GroceryCheckBox.BackColor = Color.Transparent;
            GroceryCheckBox.ForeColor = Color.White;
            GroceryCheckBox.Location = new Point(12, 84);
            GroceryCheckBox.Name = "GroceryCheckBox";
            GroceryCheckBox.Size = new Size(67, 19);
            GroceryCheckBox.TabIndex = 3;
            GroceryCheckBox.Text = "Grocery";
            GroceryCheckBox.UseVisualStyleBackColor = false;
            GroceryCheckBox.CheckedChanged += GroceryCheckBox_CheckedChanged;
            // 
            // ElectronicCheckBox
            // 
            ElectronicCheckBox.AutoSize = true;
            ElectronicCheckBox.BackColor = Color.Transparent;
            ElectronicCheckBox.ForeColor = Color.White;
            ElectronicCheckBox.Location = new Point(126, 84);
            ElectronicCheckBox.Name = "ElectronicCheckBox";
            ElectronicCheckBox.Size = new Size(83, 19);
            ElectronicCheckBox.TabIndex = 4;
            ElectronicCheckBox.Text = "Electronics";
            ElectronicCheckBox.UseVisualStyleBackColor = false;
            ElectronicCheckBox.CheckedChanged += ElectronicCheckBox_CheckedChanged;
            // 
            // ClothingCheckBox
            // 
            ClothingCheckBox.AutoSize = true;
            ClothingCheckBox.BackColor = Color.Transparent;
            ClothingCheckBox.ForeColor = Color.White;
            ClothingCheckBox.Location = new Point(254, 84);
            ClothingCheckBox.Name = "ClothingCheckBox";
            ClothingCheckBox.Size = new Size(72, 19);
            ClothingCheckBox.TabIndex = 5;
            ClothingCheckBox.Text = "Clothing";
            ClothingCheckBox.UseVisualStyleBackColor = false;
            ClothingCheckBox.CheckedChanged += ClothingCheckBox_CheckedChanged;
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.BackColor = Color.Transparent;
            ProductNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ProductNameLabel.ForeColor = Color.White;
            ProductNameLabel.Location = new Point(12, 124);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(169, 15);
            ProductNameLabel.TabIndex = 6;
            ProductNameLabel.Text = "Enter the name of the product:";
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(12, 142);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(314, 23);
            ProductNameTextBox.TabIndex = 7;
            // 
            // ProductPriceTextBox
            // 
            ProductPriceTextBox.Location = new Point(12, 218);
            ProductPriceTextBox.Name = "ProductPriceTextBox";
            ProductPriceTextBox.Size = new Size(314, 23);
            ProductPriceTextBox.TabIndex = 9;
            // 
            // ProductPriceLabel
            // 
            ProductPriceLabel.AutoSize = true;
            ProductPriceLabel.BackColor = Color.Transparent;
            ProductPriceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ProductPriceLabel.ForeColor = Color.White;
            ProductPriceLabel.Location = new Point(12, 200);
            ProductPriceLabel.Name = "ProductPriceLabel";
            ProductPriceLabel.Size = new Size(165, 15);
            ProductPriceLabel.TabIndex = 8;
            ProductPriceLabel.Text = "Enter the price of the product:";
            // 
            // ProductQuantityLabel
            // 
            ProductQuantityLabel.AutoSize = true;
            ProductQuantityLabel.BackColor = Color.Transparent;
            ProductQuantityLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ProductQuantityLabel.ForeColor = Color.White;
            ProductQuantityLabel.Location = new Point(12, 283);
            ProductQuantityLabel.Name = "ProductQuantityLabel";
            ProductQuantityLabel.Size = new Size(300, 15);
            ProductQuantityLabel.TabIndex = 10;
            ProductQuantityLabel.Text = "Enter the quantity of the product you would like to add:";
            // 
            // ProductQuantityNumericUpDown
            // 
            ProductQuantityNumericUpDown.Location = new Point(12, 301);
            ProductQuantityNumericUpDown.Name = "ProductQuantityNumericUpDown";
            ProductQuantityNumericUpDown.Size = new Size(314, 23);
            ProductQuantityNumericUpDown.TabIndex = 11;
            // 
            // AddProductButton
            // 
            AddProductButton.BackColor = Color.LimeGreen;
            AddProductButton.Location = new Point(12, 402);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(121, 36);
            AddProductButton.TabIndex = 13;
            AddProductButton.Text = "Add Product";
            AddProductButton.UseVisualStyleBackColor = false;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Firebrick;
            CloseButton.Location = new Point(667, 402);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(121, 36);
            CloseButton.TabIndex = 14;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // InputPanel
            // 
            InputPanel.BackColor = Color.Transparent;
            InputPanel.Location = new Point(423, 60);
            InputPanel.Name = "InputPanel";
            InputPanel.Size = new Size(334, 264);
            InputPanel.TabIndex = 12;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WarehouseBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseButton);
            Controls.Add(AddProductButton);
            Controls.Add(InputPanel);
            Controls.Add(ProductQuantityNumericUpDown);
            Controls.Add(ProductQuantityLabel);
            Controls.Add(ProductPriceTextBox);
            Controls.Add(ProductPriceLabel);
            Controls.Add(ProductNameTextBox);
            Controls.Add(ProductNameLabel);
            Controls.Add(ClothingCheckBox);
            Controls.Add(ElectronicCheckBox);
            Controls.Add(GroceryCheckBox);
            Controls.Add(ProductCategoryLabel);
            Controls.Add(TitleLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Inventory Management System: Add Product";
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label ProductCategoryLabel;
        private CheckBox GroceryCheckBox;
        private CheckBox ElectronicCheckBox;
        private CheckBox ClothingCheckBox;
        private Label ProductNameLabel;
        private TextBox ProductNameTextBox;
        private TextBox ProductPriceTextBox;
        private Label ProductPriceLabel;
        private Label ProductQuantityLabel;
        private NumericUpDown ProductQuantityNumericUpDown;
        private Button AddProductButton;
        private Button CloseButton;
        private Panel InputPanel;
    }
}