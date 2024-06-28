using App360_Activity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App360_Activity.controllers;

public class MainFormController
{
    private List<Product> products;
    private List<Product> cartProducts;

    public MainFormController()
    {

        products = new List<Product>();
        cartProducts = new List<Product>();

        AddProducts();

    }

    private void AddProducts()
    {
        products = new List<Product> {
            new Product { Id = "1", Name = "Apple iPhone 11 64GB", Category = "Smartphone", Price = 140500.00, Quantity = 8 },
            new Product { Id = "2", Name = "CMF By Nothing Neckband Pro", Category = "Accessories", Price = 15900.00, Quantity = 20 },
            new Product { Id = "3", Name = "Samsung Galaxy S24 Plus Case", Category = "Accessories", Price = 5100.00, Quantity = 30 },
            new Product { Id = "4", Name = "Apple iPhone 15 Pro Max", Category = "Smartphone", Price = 590000.00, Quantity = 3 },
            new Product { Id = "5", Name = "Samsung Galaxy A25 5G", Category = "Smartphone", Price = 79000.00, Quantity = 6 },
        };
    }

    public List<Product> GetProducts() { 
        return products;
    }

    public List<Product> GetCartProducts() { 
        return cartProducts;
    }

    public int getTotalProductsCount()
    {
        return products.Count;
    }

    public int getTotalCartCount() {
        return cartProducts.Count;
    }

    public void AddToCart(string id, int qty)
    {
        var product = products.Find(x => x.Id == id);

        if (product != null) {
            if (qty > 0 && qty <= product.Quantity) {
                product.Quantity -= qty;

                var cartProduct = new Product { Id = product.Id, Name = product.Name, Category = product.Category, Price = product.Price, Quantity = qty };
                cartProducts.Add(cartProduct);
                id = null;
            }
            else
            {
                throw new Exception("Invalid Quantity");
            }
        }
        else
        {
            MessageBox.Show("Please Enter Valid Product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    public double DeleteFromCart(string id) {

        var deleteProduct = cartProducts.Find(x => x.Id == id);
        var product = products.Find(product => product.Id == id);

        if (deleteProduct != null && product != null) {
            var qty = deleteProduct.Quantity;
            cartProducts.Remove(deleteProduct);
            product.Quantity += qty;

            return product.Price*qty;
        }
        else
        {
            throw new Exception("Invalid product");
        }
    }

    public void DeleteCart(bool isSuccess)
    {
        if (isSuccess)
        {
            cartProducts.Clear();
        }
        else
        {
            foreach (var product in cartProducts)
            {
                string id = product.Id;
                Product updateProduct = products.FirstOrDefault(x => x.Id == id);

                if (updateProduct != null)
                {
                    updateProduct.Quantity += product.Quantity;
                }
            }
            cartProducts.Clear();
        }
    }
}