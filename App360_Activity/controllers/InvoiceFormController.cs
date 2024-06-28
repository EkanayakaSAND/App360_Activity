using App360_Activity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App360_Activity.controllers
{
    public class InvoiceFormController
    {
        private List<Product> cartProducts;
        private double cash;
        private bool isCash;
        private double total;
        private double discount;

        public InvoiceFormController(List<Product> products,double total,double discount, double cash, bool isCash) {
            this.cartProducts = products;
            this.total = total;
            this.cash = cash;
            this.isCash = isCash;
            this.discount = discount;
        }
        public InvoiceFormController(List<Product> products, double total,double discount, bool isCash) { 
            this.cartProducts = products;
            this.total = total;
            this.cash = 0;
            this.isCash=isCash;
            this.discount = discount;
        }

        public bool IsCash() { 
            return isCash;
        }

        public List<Product> GetCartProducts() { 
            return cartProducts;
        }

        public double GetCash() { 
            return cash;
        }

        public double GetTotal() { 
            return total;
        }

        public double GetDiscount() { 
            return discount;
        }
    }
}
