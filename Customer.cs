using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kassasysteem
{
    internal class Customer
    {
        public int Id { get; set; }
        public string CustomerFirstname { get; set; }
        public string CustomerLastname { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }


        public Customer(int id, string customerFirstname, string customerLastname, string customerAddress, string customerZipCode, string customerPhoneNumber, string customerEmail) 
        {
            Id = id;
            CustomerFirstname = customerFirstname;
            CustomerLastname = customerLastname;
            CustomerAddress = customerAddress;
            CustomerZipCode = customerZipCode;
            CustomerPhoneNumber = customerPhoneNumber;
            CustomerEmail = customerEmail;
        }
    }
}
