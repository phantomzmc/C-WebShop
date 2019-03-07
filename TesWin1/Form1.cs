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

        //View
        ShowProduct view_product = new ShowProduct();
        ShowOrder view_order = new ShowOrder();
        ShowUser view_user = new ShowUser();

        //Model
        Product product = new Product();


        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = product.getProduct();
            getType();
        }
        void getType()
        {
            typeproduct_comboBox.DataSource = product.getTypeProduct();
            typeproduct_comboBox.DisplayMember = "TypeName";
            typeproduct_comboBox.ValueMember = "TypeID";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string name = productname_textBox.Text;
            string detail = productdetail_textBox.Text;
            int price = int.Parse(productprice_textBox.Text);
            int type_pro = int.Parse(typeproduct_comboBox.SelectedValue.ToString());

            Product product = new Product(name, price, detail, type_pro);
            int res = product.addProduct();
            

        }
        private void addOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show("New command executed");
        }

        private void showProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_product.Show();
        }

        private void showOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_order.Show();
        }

        private void showUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_user.Show();
        }
    }
}
