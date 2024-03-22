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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();

            Refresh_Listview();

        }

        DAL DAL = new DAL();
        public void Refresh_Listview()
        {
            listView1.Items.Clear();
            DAL.customers.Clear();
            DAL.FillCustomersFromDb();
            foreach (Customer customer in DAL.customers)
            {
                ListViewItem item = new ListViewItem(customer.Id.ToString());
                item.SubItems.Add(customer.CustomerFirstname);
                item.SubItems.Add(customer.CustomerLastname);
                item.SubItems.Add(customer.CustomerAddress);
                item.SubItems.Add(customer.CustomerZipCode);
                item.SubItems.Add(customer.CustomerPhoneNumber);
                item.SubItems.Add(customer.CustomerEmail);
                listView1.Items.Add(item);  
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
            Refresh_Listview();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            RemoveCustomerPoppup removeProductPoppup = new RemoveCustomerPoppup();
            removeProductPoppup.ShowDialog();
            Refresh_Listview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh_Listview();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            EditCustomerForm editCustomerForm = new EditCustomerForm();
            editCustomerForm.ShowDialog();
            Refresh_Listview();
        }
    }
}

