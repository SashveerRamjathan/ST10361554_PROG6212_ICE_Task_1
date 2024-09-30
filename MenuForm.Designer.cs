namespace ST10361554_PROG6212_ICE_Task_1
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            TitleLabel = new Label();
            AddNewProductButton = new Button();
            UpdateProductButton = new Button();
            DisplayInventoryReportButton = new Button();
            ProcessSaleButton = new Button();
            CloseAppButton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(329, 29);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(139, 32);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Main Menu";
            // 
            // AddNewProductButton
            // 
            AddNewProductButton.Location = new Point(145, 117);
            AddNewProductButton.Name = "AddNewProductButton";
            AddNewProductButton.Size = new Size(138, 55);
            AddNewProductButton.TabIndex = 1;
            AddNewProductButton.Text = "Add New Product";
            AddNewProductButton.UseVisualStyleBackColor = true;
            AddNewProductButton.Click += AddNewProductButton_Click;
            // 
            // UpdateProductButton
            // 
            UpdateProductButton.Location = new Point(509, 117);
            UpdateProductButton.Name = "UpdateProductButton";
            UpdateProductButton.Size = new Size(138, 55);
            UpdateProductButton.TabIndex = 2;
            UpdateProductButton.Text = "Update Existing Product Stock";
            UpdateProductButton.UseVisualStyleBackColor = true;
            UpdateProductButton.Click += UpdateProductButton_Click;
            // 
            // DisplayInventoryReportButton
            // 
            DisplayInventoryReportButton.Location = new Point(145, 236);
            DisplayInventoryReportButton.Name = "DisplayInventoryReportButton";
            DisplayInventoryReportButton.Size = new Size(138, 55);
            DisplayInventoryReportButton.TabIndex = 3;
            DisplayInventoryReportButton.Text = "Display Inventory Report";
            DisplayInventoryReportButton.UseVisualStyleBackColor = true;
            DisplayInventoryReportButton.Click += DisplayInventoryReportButton_Click;
            // 
            // ProcessSaleButton
            // 
            ProcessSaleButton.Location = new Point(509, 236);
            ProcessSaleButton.Name = "ProcessSaleButton";
            ProcessSaleButton.Size = new Size(138, 55);
            ProcessSaleButton.TabIndex = 4;
            ProcessSaleButton.Text = "Process Sales Transaction";
            ProcessSaleButton.UseVisualStyleBackColor = true;
            ProcessSaleButton.Click += ProcessSaleButton_Click;
            // 
            // CloseAppButton
            // 
            CloseAppButton.BackColor = Color.Firebrick;
            CloseAppButton.Location = new Point(145, 374);
            CloseAppButton.Name = "CloseAppButton";
            CloseAppButton.Size = new Size(502, 39);
            CloseAppButton.TabIndex = 5;
            CloseAppButton.Text = "Close";
            CloseAppButton.UseVisualStyleBackColor = false;
            CloseAppButton.Click += CloseAppButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WarehouseBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseAppButton);
            Controls.Add(ProcessSaleButton);
            Controls.Add(DisplayInventoryReportButton);
            Controls.Add(UpdateProductButton);
            Controls.Add(AddNewProductButton);
            Controls.Add(TitleLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Inventory Management System: Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Button AddNewProductButton;
        private Button UpdateProductButton;
        private Button DisplayInventoryReportButton;
        private Button ProcessSaleButton;
        private Button CloseAppButton;
    }
}
