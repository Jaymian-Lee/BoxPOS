using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassasysteem
{
    internal class Register
    {
        public int Id { get; set; } //Id inplaats van CheckoudId, alle classes een korte naam geven en de forms een lange naam (bijv. RegisterForm)
        public Invoice InvoiceId { get; set; }         

        public Register(int id, Invoice invoiceId)
        {
            Id = id;
            InvoiceId = invoiceId;
        }

    }
}
