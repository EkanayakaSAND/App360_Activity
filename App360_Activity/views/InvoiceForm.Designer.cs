namespace App360_Activity
{
    partial class InvoiceForm
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
            productsDataGridView = new DataGridView();
            produtsDetailPanel = new Panel();
            subTotalText = new TextBox();
            subTotalLabel = new Label();
            discountText = new TextBox();
            discountLabel = new Label();
            balanceText = new TextBox();
            balanceLabel = new Label();
            totalText = new TextBox();
            totalLabel = new Label();
            okButton = new Button();
            cancelButton = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            produtsDetailPanel.SuspendLayout();
            SuspendLayout();
            // 
            // productsDataGridView
            // 
            productsDataGridView.BackgroundColor = Color.White;
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Location = new Point(27, 24);
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.Size = new Size(463, 441);
            productsDataGridView.TabIndex = 0;
            // 
            // produtsDetailPanel
            // 
            produtsDetailPanel.Controls.Add(subTotalText);
            produtsDetailPanel.Controls.Add(subTotalLabel);
            produtsDetailPanel.Controls.Add(discountText);
            produtsDetailPanel.Controls.Add(discountLabel);
            produtsDetailPanel.Controls.Add(balanceText);
            produtsDetailPanel.Controls.Add(balanceLabel);
            produtsDetailPanel.Controls.Add(totalText);
            produtsDetailPanel.Controls.Add(totalLabel);
            produtsDetailPanel.Controls.Add(productsDataGridView);
            produtsDetailPanel.Location = new Point(38, 101);
            produtsDetailPanel.Name = "produtsDetailPanel";
            produtsDetailPanel.Size = new Size(516, 703);
            produtsDetailPanel.TabIndex = 1;
            // 
            // subTotalText
            // 
            subTotalText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subTotalText.Location = new Point(382, 490);
            subTotalText.Name = "subTotalText";
            subTotalText.ReadOnly = true;
            subTotalText.Size = new Size(108, 29);
            subTotalText.TabIndex = 8;
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subTotalLabel.Location = new Point(266, 493);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new Size(107, 21);
            subTotalLabel.TabIndex = 7;
            subTotalLabel.Text = "Sub Total (Rs.)";
            // 
            // discountText
            // 
            discountText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountText.Location = new Point(382, 543);
            discountText.Name = "discountText";
            discountText.ReadOnly = true;
            discountText.Size = new Size(108, 29);
            discountText.TabIndex = 6;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountLabel.Location = new Point(266, 546);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(98, 21);
            discountLabel.TabIndex = 5;
            discountLabel.Text = "Discount (%)";
            // 
            // balanceText
            // 
            balanceText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balanceText.Location = new Point(382, 633);
            balanceText.Name = "balanceText";
            balanceText.ReadOnly = true;
            balanceText.Size = new Size(108, 29);
            balanceText.TabIndex = 4;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balanceLabel.Location = new Point(266, 636);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(97, 21);
            balanceLabel.TabIndex = 3;
            balanceLabel.Text = "Balance (Rs.)";
            // 
            // totalText
            // 
            totalText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalText.Location = new Point(382, 590);
            totalText.Name = "totalText";
            totalText.ReadOnly = true;
            totalText.Size = new Size(108, 29);
            totalText.TabIndex = 2;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(266, 593);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(76, 21);
            totalLabel.TabIndex = 1;
            totalLabel.Text = "Total (Rs.)";
            // 
            // okButton
            // 
            okButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            okButton.Location = new Point(479, 820);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 33);
            okButton.TabIndex = 2;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(384, 820);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 33);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 63);
            panel1.TabIndex = 4;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 867);
            Controls.Add(panel1);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(produtsDetailPanel);
            Name = "InvoiceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            produtsDetailPanel.ResumeLayout(false);
            produtsDetailPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView productsDataGridView;
        private Panel produtsDetailPanel;
        private TextBox totalText;
        private Label totalLabel;
        private Button okButton;
        private Button cancelButton;
        private TextBox balanceText;
        private Label balanceLabel;
        private TextBox discountText;
        private Label discountLabel;
        private TextBox subTotalText;
        private Label subTotalLabel;
        private Panel panel1;
    }
}