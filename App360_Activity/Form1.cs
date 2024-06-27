using App360_Activity.controllers;
using App360_Activity.models;

namespace App360_Activity;

public partial class MainForm : Form
{
    private MainFormController mainFormController;
    private double subTotal = 0;
    public MainForm(MainFormController controller)
    {
        InitializeComponent();
        this.mainFormController = controller;
        SetFormSizeToDisplay();

        InitializeProductsDataGridView();
        InitializeProductComboBox();
        InitializeCartProductsDataGridView();
    }


    private void SetFormSizeToDisplay()
    {
        Screen primaryScreen = Screen.PrimaryScreen;

        this.Width = primaryScreen.Bounds.Width;
        this.Height = primaryScreen.Bounds.Height;

        this.StartPosition = FormStartPosition.CenterScreen;

        headerPanel.Width = primaryScreen.Bounds.Width;

    }

    private void InitializeProductComboBox()
    {
        List<Product> products = mainFormController.GetProducts();

        productsComboBox.DataSource = products;
        productsComboBox.DisplayMember = "Name";
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
    private void InitializeProductsDataGridView()
    {
        productDataGridView.ColumnCount = 5;

        productDataGridView.Columns[0].Name = "Id";
        productDataGridView.Columns[1].Name = "Name";
        productDataGridView.Columns[2].Name = "Category";
        productDataGridView.Columns[3].Name = "Price";
        productDataGridView.Columns[4].Name = "Quantity";

        SetColumnWidths(new int[] {5, 50, 20, 15, 10 }, productDataGridView);

        LoadProducts();
    }

    private void InitializeCartProductsDataGridView()
    {
        cartDataGridView.ColumnCount = 4;

        cartDataGridView.Columns[0].Name = "Id";
        cartDataGridView.Columns[1].Name = "Name";
        cartDataGridView.Columns[2].Name = "Price";
        cartDataGridView.Columns[3].Name = "Quantity";

        SetColumnWidths(new int[] {5, 40, 30, 25 }, cartDataGridView);
    }

    private void LoadProducts()
    {
        var products = mainFormController.GetProducts();
        productDataGridView.Rows.Clear();
        foreach (var product in products)
        {
            productDataGridView.Rows.Add(product.Id, product.Name, product.Category, product.Price.ToString(), product.Quantity);
        }
    }

    private void LoadCartProducts()
    {
        int cartTotal = mainFormController.getTotalCartCount();

        var cartProducts = mainFormController.GetCartProducts();
        cartDataGridView.Rows.Clear();
        subTotal = 0;

        if(cartTotal == 0)
        {
            subTotal = 0;
            cartDataGridView.Rows.Clear();
            subTotalText.Text = subTotal.ToString();
        }
        else
        {
            foreach (var product in cartProducts)
            {
                subTotal += product.Price * product.Quantity;

                cartDataGridView.Rows.Add(product.Id, product.Name, product.Price.ToString(), product.Quantity);

                subTotalText.Text = subTotal.ToString();

            }
        }
        
    }

    private void cartAddButton_Click(object sender, EventArgs e)
    {
        if (productsComboBox.SelectedItem != null)
        {
            Product selectedProduct = (Product)productsComboBox.SelectedItem;

            try
            {
                if (qtyText.Text.All(char.IsDigit) && qtyText.Text != "")
                {

                    string id = selectedProduct.Id;
                    int qty = Convert.ToInt32(qtyText.Text);

                    mainFormController.AddToCart(id, qty);

                    LoadCartProducts();

                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Please Enter Valid Quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void deleteCartButton_Click(object sender, EventArgs e)
    {
        if (cartDataGridView.SelectedRows.Count > 0) {

            DataGridViewRow selectedRow = cartDataGridView.SelectedRows[0];

            string id = Convert.ToString(selectedRow.Cells[0].Value);

            if (id != null) {
                try
                {
                    double reduce = mainFormController.DeleteFromCart(id);
                    subTotal -= reduce;
                    LoadCartProducts();
                    LoadProducts() ;
                }
                catch (Exception ex) {
                    MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        else
        {
            MessageBox.Show("Select a product to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
