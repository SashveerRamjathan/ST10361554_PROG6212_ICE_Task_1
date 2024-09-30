namespace ST10361554_PROG6212_ICE_Task_1
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            CloseButton = new Button();
            PurchaseProductButton = new Button();
            ProductQuantityNumericUpDown = new NumericUpDown();
            ProductQuantityLabel = new Label();
            ProductsListBox = new ListBox();
            TitleLabel = new Label();
            ProductsListBoxLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Firebrick;
            CloseButton.Location = new Point(667, 404);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(121, 36);
            CloseButton.TabIndex = 22;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // PurchaseProductButton
            // 
            PurchaseProductButton.BackColor = Color.LimeGreen;
            PurchaseProductButton.Location = new Point(12, 404);
            PurchaseProductButton.Name = "PurchaseProductButton";
            PurchaseProductButton.Size = new Size(121, 36);
            PurchaseProductButton.TabIndex = 21;
            PurchaseProductButton.Text = "Purchase Product";
            PurchaseProductButton.UseVisualStyleBackColor = false;
            PurchaseProductButton.Click += PurchaseProductButton_Click;
            // 
            // ProductQuantityNumericUpDown
            // 
            ProductQuantityNumericUpDown.Location = new Point(12, 355);
            ProductQuantityNumericUpDown.Name = "ProductQuantityNumericUpDown";
            ProductQuantityNumericUpDown.Size = new Size(314, 23);
            ProductQuantityNumericUpDown.TabIndex = 20;
            // 
            // ProductQuantityLabel
            // 
            ProductQuantityLabel.AutoSize = true;
            ProductQuantityLabel.BackColor = Color.Transparent;
            ProductQuantityLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ProductQuantityLabel.ForeColor = Color.White;
            ProductQuantityLabel.Location = new Point(12, 337);
            ProductQuantityLabel.Name = "ProductQuantityLabel";
            ProductQuantityLabel.Size = new Size(252, 15);
            ProductQuantityLabel.TabIndex = 19;
            ProductQuantityLabel.Text = "Enter the quantity  you would like to purchase:";
            // 
            // ProductsListBox
            // 
            ProductsListBox.FormattingEnabled = true;
            ProductsListBox.ItemHeight = 15;
            ProductsListBox.Location = new Point(12, 75);
            ProductsListBox.Name = "ProductsListBox";
            ProductsListBox.Size = new Size(493, 244);
            ProductsListBox.TabIndex = 18;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.Font = new Font("Segoe UI Semibold", 13.5F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(12, 11);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(222, 25);
            TitleLabel.TabIndex = 17;
            TitleLabel.Text = "Process Sales Transaction";
            // 
            // ProductsListBoxLabel
            // 
            ProductsListBoxLabel.AutoSize = true;
            ProductsListBoxLabel.BackColor = Color.Transparent;
            ProductsListBoxLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ProductsListBoxLabel.ForeColor = Color.White;
            ProductsListBoxLabel.Location = new Point(12, 57);
            ProductsListBoxLabel.Name = "ProductsListBoxLabel";
            ProductsListBoxLabel.Size = new Size(349, 15);
            ProductsListBoxLabel.TabIndex = 23;
            ProductsListBoxLabel.Text = "Select the product you want to purchase from the list box below:";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WarehouseBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ProductsListBoxLabel);
            Controls.Add(CloseButton);
            Controls.Add(PurchaseProductButton);
            Controls.Add(ProductQuantityNumericUpDown);
            Controls.Add(ProductQuantityLabel);
            Controls.Add(ProductsListBox);
            Controls.Add(TitleLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Inventory Management System: Sales Transaction";
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseButton;
        private Button PurchaseProductButton;
        private NumericUpDown ProductQuantityNumericUpDown;
        private Label ProductQuantityLabel;
        private ListBox ProductsListBox;
        private Label TitleLabel;
        private Label ProductsListBoxLabel;
    }
}