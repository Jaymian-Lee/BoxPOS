using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassasysteem
{
    public partial class RegisterFom : Form
    {
        public RegisterFom()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CustomerForm customersForm = new CustomerForm();
            customersForm.ShowDialog();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductForm productFom = new ProductForm();
            productFom.ShowDialog();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
