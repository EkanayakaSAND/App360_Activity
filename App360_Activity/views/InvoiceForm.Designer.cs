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
            okButton = new Button();
            cancelButton = new Button();
            totalLabel = new Label();
            totalText = new TextBox();
            balanceText = new TextBox();
            balanceLabel = new Label();
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
            produtsDetailPanel.BackColor = Color.White;
            produtsDetailPanel.Controls.Add(balanceText);
            produtsDetailPanel.Controls.Add(balanceLabel);
            produtsDetailPanel.Controls.Add(totalText);
            produtsDetailPanel.Controls.Add(totalLabel);
            produtsDetailPanel.Controls.Add(productsDataGridView);
            produtsDetailPanel.Location = new Point(38, 81);
            produtsDetailPanel.Name = "produtsDetailPanel";
            produtsDetailPanel.Size = new Size(516, 606);
            produtsDetailPanel.TabIndex = 1;
            // 
            // okButton
            // 
            okButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            okButton.Location = new Point(479, 747);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 33);
            okButton.TabIndex = 2;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(384, 747);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 33);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(279, 490);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(76, 21);
            totalLabel.TabIndex = 1;
            totalLabel.Text = "Total (Rs.)";
            // 
            // totalText
            // 
            totalText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalText.Location = new Point(382, 487);
            totalText.Name = "totalText";
            totalText.Size = new Size(108, 29);
            totalText.TabIndex = 2;
            // 
            // balanceText
            // 
            balanceText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balanceText.Location = new Point(382, 531);
            balanceText.Name = "balanceText";
            balanceText.ReadOnly = true;
            balanceText.Size = new Size(108, 29);
            balanceText.TabIndex = 4;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balanceLabel.Location = new Point(279, 534);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(97, 21);
            balanceLabel.TabIndex = 3;
            balanceLabel.Text = "Balance (Rs.)";
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 803);
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
    }
}