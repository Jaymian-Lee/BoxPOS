
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassasysteem
{
    internal class Product
    {
        DAL DAL = new DAL();
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

       public Product(int id, string productName, string productDescription, double productPrice, int productQuantity)
        {
            Id = id;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
        }

        public void AddProducts(string productName, string productDescription, double productPrice, int productQuantity) 
        { 
            DAL.AddProducts(productName, productDescription, productPrice, productQuantity);   
        }

    }



}
