using App360_Activity.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App360_Activity
{
    public partial class InvoiceForm : Form
    {
        private InvoiceFormController invoiceFormController;
        public InvoiceForm(InvoiceFormController controller)
        {
            InitializeComponent();
            this.invoiceFormController = controller;

            InitializeCartProductsDataGridView();
        }

        private void InitializeCartProductsDataGridView()
        {
            productsDataGridView.ColumnCount = 4;

            productsDataGridView.Columns[0].Name = "Name";
            productsDataGridView.Columns[1].Name = "Price";
            productsDataGridView.Columns[2].Name = "Quantity";
            productsDataGridView.Columns[3].Name = "Sub Total";

            SetColumnWidths(new int[] { 50, 15, 15, 20 }, productsDataGridView);

            LoadCartProducts();
        }

        private void SetColumnWidths(int[] percentages, DataGridView dataGridView)
        {
            if (percentages.Sum() != 100)
            {
                throw new ArgumentException("Column percentages must add up to 100.");
            }

            int totalWidth = dataGridView.Width - dataGridView.RowHeadersWidth;

            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = (totalWidth * percentages[i]) / 100;
            }
        }

        private void LoadCartProducts()
        {
            var products = invoiceFormController.GetCartProducts();
            productsDataGridView.Rows.Clear();
            foreach (var product in products)
            {
                productsDataGridView.Rows.Add(product.Name, product.Price.ToString(), product.Quantity, product.Price * product.Quantity);
            }

            subTotalText.Text = invoiceFormController.GetTotal().ToString();
            discountText.Text = invoiceFormController.GetDiscount().ToString();
            double total = invoiceFormController.GetTotal() - invoiceFormController.GetTotal() * (invoiceFormController.GetDiscount() / 100);
            totalText.Text = total.ToString();

            bool isCash = invoiceFormController.IsCash();

            if (isCash)
            {
                double balance = invoiceFormController.GetCash() - total;
                balanceLabel.Visible = true;
                balanceText.Visible = true;

                balanceText.Text = balance.ToString();
            }
            else
            {
                balanceLabel.Visible = false;
                balanceText.Visible = false;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
