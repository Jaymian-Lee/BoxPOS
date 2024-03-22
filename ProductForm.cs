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
    public partial class ProductForm : Form
    {
        
        DAL DAL = new DAL();

        public ProductForm()
        {
            InitializeComponent();
            Refresh_Listview();
        }


        public void Refresh_Listview()
        {
            listView1.Items.Clear();
            DAL.products.Clear();
            DAL.FillProductsFromDb();
            foreach (Products product in DAL.products)
            {
                ListViewItem item = new ListViewItem(product.Id.ToString());
                item.SubItems.Add(product.ProductName);
                item.SubItems.Add(product.ProductDescription);
                item.SubItems.Add(product.ProductPrice.ToString());
                item.SubItems.Add(product.ProductQuantity.ToString());
                listView1.Items.Add(item);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            Refresh_Listview();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            RemoveProductForm removeProductForm = new RemoveProductForm();
            removeProductForm.ShowDialog();
            Refresh_Listview();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            EditProductForm editProductForm = new EditProductForm();
            editProductForm.ShowDialog();
            Refresh_Listview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh_Listview();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
