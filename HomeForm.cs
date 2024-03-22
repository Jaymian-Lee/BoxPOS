using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassasysteem
{
    public partial class HomeForm : Form
    {


        public HomeForm()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            RegisterFom register = new RegisterFom();
            register.ShowDialog();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            RegisterFom register = new RegisterFom();
            register.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProductForm products = new ProductForm();
            products.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ProductForm products = new ProductForm();
            products.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Invoice invoices = new Invoice();
            invoices.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Invoice invoices = new Invoice();
            invoices.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           CustomerForm customers = new CustomerForm();
           customers.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            CustomerForm customers = new CustomerForm();
            customers.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
