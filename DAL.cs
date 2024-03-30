using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassasysteem
{
    internal class DAL
    {

        public List<Customer> customers = new List<Customer>();
        public List<Product> products = new List<Product>();

        string connectionString = "Data Source=DESKTOP-IR29NG7;Initial Catalog=Box;Integrated Security=True";

        public void AddCustomer(Customer customer) { 
            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO dbCustomer (CustomerFirstname, CustomerLastname, CustomerAddress, CustomerZipCode, CustomerPhoneNumber, CustomerEmail) VALUES (@CustomerFirstname, @CustomerLastname, @CustomerAddress, @CustomerZipCode, @CustomerPhoneNumber, @CustomerEmail)";
                    command.Parameters.AddWithValue("@CustomerFirstname", customer.CustomerFirstname);
                    command.Parameters.AddWithValue("@CustomerLastname", customer.CustomerLastname);
                    command.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
                    command.Parameters.AddWithValue("@CustomerZipCode", customer.CustomerZipCode);
                    command.Parameters.AddWithValue("@CustomerPhoneNumber", customer.CustomerPhoneNumber);
                    command.Parameters.AddWithValue("@CustomerEmail", customer.CustomerEmail);

                    command.ExecuteNonQuery();
                }
            }
        }

     

        public void RemoveCustomer(int Id)
        {
            string connectionString = "Data Source=DESKTOP-IR29NG7;Initial Catalog=Box;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.CommandText = "DELETE dbCustomer WHERE Id = @Id";
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                { 
                connection.ConnectionString = connectionString;
                connection.Open();

                string sql = "UPDATE dbCustomer SET CustomerFirstname = @CustomerFirstname, CustomerLastname = @CustomerLastname, CustomerAddress = @CustomerAddress, CustomerZipcode = @CustomerZipcode, CustomerPhoneNumber = @CustomerPhoneNumber, CustomerEmail = @CustomerEmail WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", customer.Id);
                    command.Parameters.AddWithValue("@CustomerFirstname", customer.CustomerFirstname);
                    command.Parameters.AddWithValue("@CustomerLastname", customer.CustomerLastname);
                    command.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
                    command.Parameters.AddWithValue("@CustomerZipcode", customer.CustomerZipCode);
                    command.Parameters.AddWithValue("@CustomerPhoneNumber", customer.CustomerPhoneNumber);
                    command.Parameters.AddWithValue("@CustomerEmail", customer.CustomerEmail);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            }
            catch (SqlException ex) { throw ex; }
            // finally { connection.Dispose(); }
        }



        public void FillCustomersFromDb()
        {
            customers.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, CustomerFirstname, CustomerLastname, CustomerAddress, CustomerZipCode, CustomerPhoneNumber, CustomerEmail FROM dbCustomer ORDER BY id";
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            customers.Add(new Customer(Int32.Parse(dataReader[0].ToString())
                                                               , dataReader[1].ToString()
                                                               , dataReader[2].ToString()
                                                               , dataReader[3].ToString()
                                                               , dataReader[4].ToString()
                                                               , dataReader[5].ToString()
                                                               , dataReader[6].ToString()
                                                               )
                                        );
                        }
                    }
                }
            }
        }
            public void AddProducts(string name, string description, double price, int quantity)
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.ConnectionString = connectionString;
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO dbProduct (ProductName, ProductDescription, ProductPrice, ProductQuantity) VALUES (@ProductName, @ProductDescription, @ProductPrice, @ProductQuantity)";
                        command.Parameters.AddWithValue("@ProductName", name);
                        command.Parameters.AddWithValue("@ProductDescription", description);
                        command.Parameters.AddWithValue("@ProductPrice", price);
                        command.Parameters.AddWithValue("@ProductQuantity", quantity);

                        command.ExecuteNonQuery();
                    }
                }
            }
        // TODO OOP toepassen | objecten invoegen in plaats van losse variabelen | Opgelost - 30-03-2024
        public void UpdateProduct(Product product)
        {
            // Gebruik using om de connectie te openen en te sluiten
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) { 
                connection.ConnectionString = connectionString;
                connection.Open();

                string sql = "UPDATE dbProduct SET ProductName = @ProductName, ProductDescription = @ProductDescription, productPrice = @productPrice, ProductQuantity = @ProductQuantity WHERE Id = @Id";
                // implementeert de IDisposable interface en zorgt ervoor dat de connectie wordt gesloten
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", product.Id);
                    command.Parameters.AddWithValue("@ProductName", product.ProductName);
                    command.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                    command.Parameters.AddWithValue("@productPrice", product.ProductPrice);
                    command.Parameters.AddWithValue("@ProductQuantity", product.ProductQuantity);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            }
            catch (SqlException ex) { throw ex; }
            // Kan weg als ik using bij de sqlconnection gebruik
            // finally { connection.Dispose(); }
        }
        public void RemoveProduct(int Id)
        {
            string connectionString = "Data Source=DESKTOP-IR29NG7;Initial Catalog=Box;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.CommandText = "DELETE dbProduct WHERE Id = @Id";
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                    }
                    command.ExecuteNonQuery();
                }
            }
        }


        public void FillProductsFromDb()
            {
                products.Clear();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.ConnectionString = connectionString;
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = "SELECT Id, ProductName, ProductDescription, productPrice, ProductQuantity FROM dbProduct ORDER BY id";
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                products.Add(new Product(Int32.Parse(dataReader[0].ToString())
                                                                 , dataReader[1].ToString()
                                                                 , dataReader[2].ToString()
                                                                 , Double.Parse(dataReader[3].ToString())
                                                                 , Int32.Parse(dataReader[4].ToString())
                                                                 )
                                 );
                            }
                        }
                    }
                }
            }

    }

    }

