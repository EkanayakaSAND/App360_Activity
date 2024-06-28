using App360_Activity.controllers;
using App360_Activity.models;
using System.Windows.Forms;

namespace App360_Activity;

public partial class MainForm : Form
{
    private MainFormController mainFormController;
    private double subTotal = 0;
    private string paymentMethod;
    private double cash = 0;
    private double total = 0;
    private double discount = 0;

    private System.Windows.Forms.Timer timer;

    public MainForm(MainFormController controller)
    {
        InitializeComponent();
        this.mainFormController = controller;
        SetFormSizeToDisplay();

        timer = new System.Windows.Forms.Timer();
        timer.Interval = 1000;
        timer.Tick += Timer_Tick;

        timer.Start();
        UpdateDate();

        InitializeProductsDataGridView();
        InitializeProductComboBox();
        InitializeCartProductsDataGridView();

        discountText.TextAlignChanged += discountText_TextChanged;

        cashRadioButton.Checked = true;

        cashRadioButton.CheckedChanged += radioButton_CheckedChanged;
        cardRadioButton.CheckedChanged += radioButton_CheckedChanged;
        bankRadioButton.CheckedChanged += radioButton_CheckedChanged;
    }
    private void Timer_Tick(object sender, EventArgs e)
    {
        timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
    }

    private void UpdateDate()
    {
        dateLabel.Text = DateTime.Now.ToString("D");
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

        productDataGridView.DefaultCellStyle.Font = new Font("Arial", 12);
        productDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

        productDataGridView.Columns[0].Name = "Id";
        productDataGridView.Columns[1].Name = "Name";
        productDataGridView.Columns[2].Name = "Category";
        productDataGridView.Columns[3].Name = "Price";
        productDataGridView.Columns[4].Name = "Quantity";

        SetColumnWidths(new int[] { 5, 50, 20, 15, 10 }, productDataGridView);

        LoadProducts();
    }

    private void InitializeCartProductsDataGridView()
    {
        cartDataGridView.DefaultCellStyle.Font = new Font("Arial", 12);
        cartDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

        cartDataGridView.ColumnCount = 4;

        cartDataGridView.Columns[0].Name = "Id";
        cartDataGridView.Columns[1].Name = "Name";
        cartDataGridView.Columns[2].Name = "Price";
        cartDataGridView.Columns[3].Name = "Quantity";

        SetColumnWidths(new int[] { 5, 40, 30, 25 }, cartDataGridView);
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

        if (cartTotal == 0)
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
        if (cartDataGridView.SelectedRows.Count > 0)
        {

            DataGridViewRow selectedRow = cartDataGridView.SelectedRows[0];

            string id = Convert.ToString(selectedRow.Cells[0].Value);

            if (id != null)
            {
                try
                {
                    double reduce = mainFormController.DeleteFromCart(id);
                    subTotal -= reduce;
                    LoadCartProducts();
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        else
        {
            MessageBox.Show("Select a product to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void discountText_TextChanged(object sender, EventArgs e)
    {
        if (discountText.Text == "")
        {
            totalText.Text = subTotal.ToString();

        }
        else if (discountText.Text.All(char.IsDigit))
        {

            double discount = Convert.ToDouble(discountText.Text);

            if (discount < 100)
            {
                AddDiscount();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Discount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        else
        {

            MessageBox.Show("Please Enter Valid Discount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            totalText.Text = "";
        }
    }

    private void AddDiscount()
    {
        //total = 0;
        discount = Convert.ToDouble(discountText.Text);

        total = subTotal - subTotal * (discount / 100);

        totalText.Text = total.ToString("0.00");
    }

    private void radioButton_CheckedChanged(object sender, EventArgs e)
    {
        RadioButton radioButton = sender as RadioButton;
        if (radioButton.Checked)
        {
            if (radioButton == cashRadioButton)
            {
                paymentMethod = "Cash Payment";
                cashLabel.Visible = true;
                cashText.Visible = true;
            }
            else if (radioButton == cardRadioButton)
            {
                paymentMethod = "Card Payment";
                cashLabel.Visible = false;
                cashText.Visible = false;
            }
            else if (radioButton == bankRadioButton)
            {
                paymentMethod = "Bank Transfer";
                cashLabel.Visible = false;
                cashText.Visible = false;
            }
        }
    }

    private void completeOrderButton_Click(object sender, EventArgs e)
    {

        if (cashRadioButton.Checked)
        {

            int productCount = mainFormController.getTotalCartCount();
            if (productCount > 0)
            {
                if (cashText.Text == "")
                {
                    MessageBox.Show("Please Enter Valid Cash.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cashText.Text.All(char.IsDigit))
                {
                    cash = Convert.ToDouble(cashText.Text);
                    InvoiceFormController controller = new InvoiceFormController(mainFormController.GetCartProducts(), subTotal, discount, cash, true);
                    InvoiceForm invoiceForm = new InvoiceForm(controller);
                    invoiceForm.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Cash.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    totalText.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Cart can not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        else
        {
            int productCount = mainFormController.getTotalCartCount();
            if (productCount > 0)
            {
                InvoiceFormController controller = new InvoiceFormController(mainFormController.GetCartProducts(), subTotal, discount, false);
                InvoiceForm invoiceForm2 = new InvoiceForm(controller);
                invoiceForm2.Show();
            }
            else
            {
                MessageBox.Show("Cart can not be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }

    private void clearButton_Click(object sender, EventArgs e)
    {
        mainFormController.DeleteCart();
        LoadCartProducts();
        LoadProducts();
        total = 0;
        totalText.Text = string.Empty;
        discount = 0;
        discountText.Text = string.Empty;
        subTotal = 0;
        subTotalText.Text = string.Empty;
        cash = 0;
        cashText.Text = string.Empty;
    }

}
