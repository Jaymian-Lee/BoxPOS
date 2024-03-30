using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassasysteem
{
    public partial class AddCustomerForm : Form
    {

        DAL DAL = new DAL();

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Creëer een nieuw Customer object met de waarden uit de form
            Customer newCustomer = new Customer(0, // Gebruik 0 omdat de db automatisch een id aanmaakt met auto increment
                                                textBox1.Text,
                                                textBox2.Text,
                                                textBox3.Text,
                                                textBox4.Text,
                                                textBox5.Text,
                                                textBox6.Text);

            // Roep AddCustomer aan met het nieuwe Customer object
            DAL.AddCustomer(newCustomer);

            string message = "Gebruiker is toegevoegd";
            MessageBox.Show(message);
        }


        private void lastnameBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void stateBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void countryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
