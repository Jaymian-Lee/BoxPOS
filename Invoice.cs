using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassasysteem
{
    internal class InvoiceClass
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public string ProductName { get; set; }
        public int InvoicePrice { get; set; }

        public InvoiceClass(int id, Product product, Customer customer, string productName, int invoicePrice)
        {
            Id = id;
            Product = product;
            Customer = customer;
            ProductName = productName;
            InvoicePrice = invoicePrice;
        }
    }
}
