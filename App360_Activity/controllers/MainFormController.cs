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
            new Product { Id = "1", Name = "Product A", Category = "Smartphone", Price = 70000.00, Quantity = 8 },
            new Product { Id = "2", Name = "Product B", Category = "Accessories", Price = 3000.00, Quantity = 20 },
            new Product { Id = "3", Name = "Product C", Category = "Accessories", Price = 1590.00, Quantity = 30 },
            new Product { Id = "4", Name = "Product D", Category = "Smartphone", Price = 120000.00, Quantity = 3 },
            new Product { Id = "5", Name = "Product E", Category = "Smartphone", Price = 590000.00, Quantity = 2 },
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
}