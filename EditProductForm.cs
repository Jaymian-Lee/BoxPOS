using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kassasysteem
{
    public partial class EditProductForm : Form
    {
        DAL DAL = new DAL();
        public EditProductForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product(
                Int32.Parse(textBox1.Text), 
                textBox2.Text, 
                textBox3.Text, 
                Double.Parse(textBox4.Text), 
                Int32.Parse(textBox5.Text)
                );
            DAL.UpdateProduct(newProduct);
            MessageBox.Show("Product is gewijzigd!");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
