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
            timeLabel = new Label();
            dateLabel = new Label();
            okButton = new Button();
            cancelButton = new Button();
            panel1 = new Panel();
            invoiceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            produtsDetailPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productsDataGridView
            // 
            productsDataGridView.BackgroundColor = Color.White;
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Location = new Point(3, 3);
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.Size = new Size(539, 462);
            productsDataGridView.TabIndex = 0;
            // 
            // produtsDetailPanel
            // 
            produtsDetailPanel.BackColor = Color.White;
            produtsDetailPanel.Controls.Add(subTotalText);
            produtsDetailPanel.Controls.Add(subTotalLabel);
            produtsDetailPanel.Controls.Add(discountText);
            produtsDetailPanel.Controls.Add(discountLabel);
            produtsDetailPanel.Controls.Add(balanceText);
            produtsDetailPanel.Controls.Add(balanceLabel);
            produtsDetailPanel.Controls.Add(totalText);
            produtsDetailPanel.Controls.Add(totalLabel);
            produtsDetailPanel.Controls.Add(productsDataGridView);
            produtsDetailPanel.Location = new Point(24, 101);
            produtsDetailPanel.Name = "produtsDetailPanel";
            produtsDetailPanel.Size = new Size(542, 668);
            produtsDetailPanel.TabIndex = 1;
            // 
            // subTotalText
            // 
            subTotalText.BackColor = SystemColors.ControlLightLight;
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
            discountText.BackColor = SystemColors.ControlLightLight;
            discountText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountText.Location = new Point(382, 532);
            discountText.Name = "discountText";
            discountText.ReadOnly = true;
            discountText.Size = new Size(108, 29);
            discountText.TabIndex = 6;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountLabel.Location = new Point(266, 535);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(98, 21);
            discountLabel.TabIndex = 5;
            discountLabel.Text = "Discount (%)";
            // 
            // balanceText
            // 
            balanceText.BackColor = SystemColors.ControlLightLight;
            balanceText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balanceText.Location = new Point(382, 621);
            balanceText.Name = "balanceText";
            balanceText.ReadOnly = true;
            balanceText.Size = new Size(108, 29);
            balanceText.TabIndex = 4;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balanceLabel.Location = new Point(266, 624);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(97, 21);
            balanceLabel.TabIndex = 3;
            balanceLabel.Text = "Balance (Rs.)";
            // 
            // totalText
            // 
            totalText.BackColor = SystemColors.ControlLightLight;
            totalText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalText.Location = new Point(382, 576);
            totalText.Name = "totalText";
            totalText.ReadOnly = true;
            totalText.Size = new Size(108, 29);
            totalText.TabIndex = 2;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(266, 579);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(80, 21);
            totalLabel.TabIndex = 1;
            totalLabel.Text = "Total (Rs.)";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.White;
            timeLabel.Location = new Point(435, 33);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(42, 20);
            timeLabel.TabIndex = 10;
            timeLabel.Text = "Time";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.ForeColor = Color.White;
            dateLabel.Location = new Point(435, 11);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(41, 20);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Date";
            // 
            // okButton
            // 
            okButton.BackColor = Color.Green;
            okButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            okButton.ForeColor = Color.White;
            okButton.Location = new Point(477, 798);
            okButton.Name = "okButton";
            okButton.Size = new Size(89, 44);
            okButton.TabIndex = 2;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Red;
            cancelButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(370, 798);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(89, 44);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(timeLabel);
            panel1.Controls.Add(invoiceLabel);
            panel1.Controls.Add(dateLabel);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 79);
            panel1.TabIndex = 4;
            // 
            // invoiceLabel
            // 
            invoiceLabel.AutoSize = true;
            invoiceLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceLabel.ForeColor = Color.White;
            invoiceLabel.Location = new Point(259, 29);
            invoiceLabel.Name = "invoiceLabel";
            invoiceLabel.Size = new Size(92, 24);
            invoiceLabel.TabIndex = 0;
            invoiceLabel.Text = "INVOICE";
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 247);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label timeLabel;
        private Label dateLabel;
        private Label invoiceLabel;
    }
}