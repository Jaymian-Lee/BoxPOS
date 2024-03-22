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
    public partial class AddProductForm : Form
    {
        DAL DAL = new DAL();
        public AddProductForm()
        {
            InitializeComponent();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            DAL.AddProducts(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), Convert.ToInt32(textBox4.Text));
            MessageBox.Show("Product toegevoegd!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
