namespace App360_Activity
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            headerPanel = new Panel();
            headerMainLabel = new Label();
            productDataGridView = new DataGridView();
            productsComboBox = new ComboBox();
            cartAddButton = new Button();
            cartQtyLabel = new Label();
            qtyText = new TextBox();
            cartPanel = new Panel();
            cartDataGridView = new DataGridView();
            cartHeaderLabel = new Label();
            productsMainLabel = new Label();
            subTotalLabel = new Label();
            subTotalText = new TextBox();
            discountText = new TextBox();
            discountLabel = new Label();
            totalText = new TextBox();
            totalLabel = new Label();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            cartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartDataGridView).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Navy;
            headerPanel.Controls.Add(headerMainLabel);
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1903, 90);
            headerPanel.TabIndex = 0;
            // 
            // headerMainLabel
            // 
            headerMainLabel.AutoSize = true;
            headerMainLabel.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            headerMainLabel.ForeColor = Color.White;
            headerMainLabel.Location = new Point(12, 20);
            headerMainLabel.Name = "headerMainLabel";
            headerMainLabel.Size = new Size(148, 50);
            headerMainLabel.TabIndex = 0;
            headerMainLabel.Text = "App360";
            // 
            // productDataGridView
            // 
            productDataGridView.BackgroundColor = Color.White;
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Location = new Point(1189, 172);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.Size = new Size(692, 844);
            productDataGridView.TabIndex = 1;
            // 
            // productsComboBox
            // 
            productsComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productsComboBox.FormattingEnabled = true;
            productsComboBox.Location = new Point(67, 171);
            productsComboBox.Name = "productsComboBox";
            productsComboBox.Size = new Size(444, 29);
            productsComboBox.TabIndex = 2;
            productsComboBox.Text = "- Select the Product -";
            // 
            // cartAddButton
            // 
            cartAddButton.BackColor = Color.FromArgb(0, 0, 192);
            cartAddButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartAddButton.ForeColor = Color.White;
            cartAddButton.Image = (Image)resources.GetObject("cartAddButton.Image");
            cartAddButton.ImageAlign = ContentAlignment.MiddleLeft;
            cartAddButton.Location = new Point(759, 168);
            cartAddButton.Name = "cartAddButton";
            cartAddButton.Padding = new Padding(5, 0, 0, 0);
            cartAddButton.Size = new Size(83, 35);
            cartAddButton.TabIndex = 3;
            cartAddButton.Text = "  ADD";
            cartAddButton.UseVisualStyleBackColor = false;
            // 
            // cartQtyLabel
            // 
            cartQtyLabel.AutoSize = true;
            cartQtyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cartQtyLabel.Location = new Point(541, 174);
            cartQtyLabel.Name = "cartQtyLabel";
            cartQtyLabel.Size = new Size(77, 21);
            cartQtyLabel.TabIndex = 4;
            cartQtyLabel.Text = "Quantity :";
            // 
            // qtyText
            // 
            qtyText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qtyText.Location = new Point(624, 171);
            qtyText.Name = "qtyText";
            qtyText.Size = new Size(100, 29);
            qtyText.TabIndex = 5;
            // 
            // cartPanel
            // 
            cartPanel.BackColor = Color.White;
            cartPanel.Controls.Add(cartDataGridView);
            cartPanel.Controls.Add(cartHeaderLabel);
            cartPanel.Location = new Point(67, 242);
            cartPanel.Name = "cartPanel";
            cartPanel.Size = new Size(775, 507);
            cartPanel.TabIndex = 6;
            // 
            // cartDataGridView
            // 
            cartDataGridView.BackgroundColor = Color.White;
            cartDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartDataGridView.Location = new Point(40, 46);
            cartDataGridView.Name = "cartDataGridView";
            cartDataGridView.Size = new Size(694, 437);
            cartDataGridView.TabIndex = 1;
            // 
            // cartHeaderLabel
            // 
            cartHeaderLabel.AutoSize = true;
            cartHeaderLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartHeaderLabel.ForeColor = Color.Navy;
            cartHeaderLabel.Location = new Point(342, 9);
            cartHeaderLabel.Name = "cartHeaderLabel";
            cartHeaderLabel.Size = new Size(49, 25);
            cartHeaderLabel.TabIndex = 0;
            cartHeaderLabel.Text = "Cart";
            // 
            // productsMainLabel
            // 
            productsMainLabel.AutoSize = true;
            productsMainLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productsMainLabel.Location = new Point(1502, 134);
            productsMainLabel.Name = "productsMainLabel";
            productsMainLabel.Size = new Size(87, 25);
            productsMainLabel.TabIndex = 7;
            productsMainLabel.Text = "Products";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subTotalLabel.Location = new Point(547, 800);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new Size(114, 21);
            subTotalLabel.TabIndex = 8;
            subTotalLabel.Text = "Sub Total (Rs.) :";
            // 
            // subTotalText
            // 
            subTotalText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subTotalText.Location = new Point(690, 795);
            subTotalText.Name = "subTotalText";
            subTotalText.ReadOnly = true;
            subTotalText.Size = new Size(152, 29);
            subTotalText.TabIndex = 9;
            // 
            // discountText
            // 
            discountText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountText.Location = new Point(690, 849);
            discountText.Name = "discountText";
            discountText.Size = new Size(152, 29);
            discountText.TabIndex = 11;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountLabel.Location = new Point(547, 854);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(113, 21);
            discountLabel.TabIndex = 10;
            discountLabel.Text = "Discount (%)   :";
            // 
            // totalText
            // 
            totalText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalText.Location = new Point(690, 909);
            totalText.Name = "totalText";
            totalText.ReadOnly = true;
            totalText.Size = new Size(152, 29);
            totalText.TabIndex = 13;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(547, 914);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(112, 21);
            totalLabel.TabIndex = 12;
            totalLabel.Text = "Total (Rs.)       :";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(totalText);
            Controls.Add(totalLabel);
            Controls.Add(discountText);
            Controls.Add(discountLabel);
            Controls.Add(subTotalText);
            Controls.Add(subTotalLabel);
            Controls.Add(productsMainLabel);
            Controls.Add(cartPanel);
            Controls.Add(qtyText);
            Controls.Add(cartQtyLabel);
            Controls.Add(cartAddButton);
            Controls.Add(productsComboBox);
            Controls.Add(productDataGridView);
            Controls.Add(headerPanel);
            MaximumSize = new Size(1920, 1080);
            Name = "MainForm";
            Text = "MainForm";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            cartPanel.ResumeLayout(false);
            cartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cartDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerPanel;
        private Label headerMainLabel;
        private DataGridView productDataGridView;
        private ComboBox productsComboBox;
        private Button cartAddButton;
        private Label cartQtyLabel;
        private TextBox qtyText;
        private Panel cartPanel;
        private Label cartHeaderLabel;
        private DataGridView cartDataGridView;
        private Label productsMainLabel;
        private Label subTotalLabel;
        private TextBox subTotalText;
        private TextBox discountText;
        private Label discountLabel;
        private TextBox totalText;
        private Label totalLabel;
    }
}
