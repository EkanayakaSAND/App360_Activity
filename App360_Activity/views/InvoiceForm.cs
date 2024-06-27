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
        }
    }
}
