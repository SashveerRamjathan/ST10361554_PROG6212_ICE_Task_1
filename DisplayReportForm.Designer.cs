namespace ST10361554_PROG6212_ICE_Task_1
{
    partial class DisplayReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayReportForm));
            TitleLabel = new Label();
            ProductsRichTextBox = new RichTextBox();
            CloseButton = new Button();
            GenerateReportButton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(12, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(189, 23);
            TitleLabel.TabIndex = 3;
            TitleLabel.Text = "Inventory Stock Report";
            // 
            // ProductsRichTextBox
            // 
            ProductsRichTextBox.Location = new Point(12, 49);
            ProductsRichTextBox.Name = "ProductsRichTextBox";
            ProductsRichTextBox.Size = new Size(618, 262);
            ProductsRichTextBox.TabIndex = 4;
            ProductsRichTextBox.Text = "";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Firebrick;
            CloseButton.Location = new Point(667, 402);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(121, 36);
            CloseButton.TabIndex = 18;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // GenerateReportButton
            // 
            GenerateReportButton.BackColor = Color.LimeGreen;
            GenerateReportButton.Location = new Point(12, 402);
            GenerateReportButton.Name = "GenerateReportButton";
            GenerateReportButton.Size = new Size(121, 36);
            GenerateReportButton.TabIndex = 17;
            GenerateReportButton.Text = "Generate Report";
            GenerateReportButton.UseVisualStyleBackColor = false;
            GenerateReportButton.Click += GenerateReportButton_Click;
            // 
            // DisplayReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WarehouseBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseButton);
            Controls.Add(GenerateReportButton);
            Controls.Add(ProductsRichTextBox);
            Controls.Add(TitleLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DisplayReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Inventory Management System: Inventory Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private RichTextBox ProductsRichTextBox;
        private Button CloseButton;
        private Button GenerateReportButton;
    }
}