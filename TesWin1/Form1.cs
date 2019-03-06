using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TesWin1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Product product = new Product();
            dataGridView1.DataSource = product.getProduct();

            getType();
        }
        void getType()
        {
            Product product = new Product();
            typeproduct_comboBox.DataSource = product.getTypeProduct();
            typeproduct_comboBox.DisplayMember = "TypeName";
            typeproduct_comboBox.ValueMember = "TypeID";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
           //Product product = new Product(productname_textBox.Text, int.Parse(productprice_textBox.Text), productdetail_textBox.Text, int.Parse(typeproduct_comboBox.Text));
           //int res = product.addProduct();

        }

        private void typeproduct_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = typeproduct_comboBox.SelectedValue.ToString();
            label4.Text = txt;
        }
    }
}
