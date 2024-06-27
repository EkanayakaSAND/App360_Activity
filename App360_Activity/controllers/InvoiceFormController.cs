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

        public InvoiceFormController(List<Product> products, double cash) {
            this.cartProducts = products;
        }
        public InvoiceFormController(List<Product> products) { 
            this.cartProducts = products;
        }
    }
}
