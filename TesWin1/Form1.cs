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

        #region View
        //View
        ShowProduct view_product = new ShowProduct();
        ShowOrder view_order = new ShowOrder();
        ShowUser view_user = new ShowUser();

        AddOrder add_order = new AddOrder();
        AddUser add_user = new AddUser();
        AddTypeProduct add_typeproduct = new AddTypeProduct();
        #endregion

        #region Model
        //Model
        Product product = new Product();
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = product.getProduct();
            getType();
        }
        void getType()
        {
            ProductType product_type = new ProductType();
            typeproduct_comboBox.DataSource = product_type.getType();
            typeproduct_comboBox.DisplayMember = "TypeName";
            typeproduct_comboBox.ValueMember = "TypeID";
        }
        
        void addProduct()
        {
            string name = productname_textBox.Text;
            string detail = productdetail_textBox.Text;
            int price = int.Parse(productprice_textBox.Text);
            int type_pro = int.Parse(typeproduct_comboBox.SelectedValue.ToString());

            if((productprice_textBox.Text == "" || productdetail_textBox.Text == "") || (productprice_textBox.Text == null || typeproduct_comboBox.SelectedValue.ToString() == null))
            {
                MessageBox.Show("กรอกข้อมูลให้ครบถ้วน", "ผิดพลาด");

            }
            else
            {
                Product product = new Product(name, price, detail, type_pro)
                {
                    ProductName = name,
                    ProductPrice = price,
                    ProductDetail = detail,
                    TypeProduct = type_pro
                };
                int res = product.addProduct();
            }
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("เพิ่มรายการสินค้านี้ ใช่หรือไม่ ??", "เพิ่มรายการ", MessageBoxButtons.YesNo);
            switch (result)
            {

                case DialogResult.Yes:
                    {
                        addProduct();
                        MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "เรียบร้อย");
                        break;
                    }
                case DialogResult.No:
                    {
                        productname_textBox.Text = "" ;
                        productdetail_textBox.Text = "";
                        productprice_textBox.Text= "";
                        typeproduct_comboBox.Text= "";
                        break;
                    }
            }  
        }
        private void addOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            add_order.Show();
            
            //MessageBox.Show("New command executed");
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {

        }

        #region view_product
        private void showProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_product.Show();
        }
        #endregion
        #region view_order
        private void showOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_order.Show();
        }
        #endregion

        #region view_user
        private void showUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_user.Show();
        }
        #endregion

        #region add_user
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_user.Show();
        }
        #endregion



        private void typeproduct_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            add_typeproduct.Show();
        }
    }
}
