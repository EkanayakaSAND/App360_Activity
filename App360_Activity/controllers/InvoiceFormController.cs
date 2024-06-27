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

        public InvoiceFormController(List<Product> products, double cash, bool isCash) {
            this.cartProducts = products;
            this.cash = cash;
            this.isCash = isCash;
        }
        public InvoiceFormController(List<Product> products, bool isCash) { 
            this.cartProducts = products;
            this.isCash=isCash;
        }

        public bool IsCash() { 
            return isCash;
        }
    }
}
