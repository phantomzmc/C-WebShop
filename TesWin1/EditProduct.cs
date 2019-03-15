using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesWin1
{
    public partial class EditProduct : Form
    {
        Product product = new Product();
        
        public EditProduct()
        {
            InitializeComponent(); 
        }
        private void EditProduct_Load(object sender, EventArgs e)
        {
            getTypeProduct();

        }
        void getTypeProduct()
        {
            ProductType product_type = new ProductType();
            comboBox1.DataSource = product_type.getType();
            comboBox1.DisplayMember = "TypeName";
            comboBox1.ValueMember = "TypeID";

            edit_proid_textBox.Text = product.ProductID.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int proid = int.Parse(edit_proid_textBox.Text.ToString());
            string proname = edit_proname_textBox.Text.ToString();
            int proprice = int.Parse(edit_proprice_textBox.Text.ToString());
            string prodetail = edit_prodetail_textBox.Text.ToString();
            int type_pro = int.Parse(comboBox1.SelectedValue.ToString());

            Product product = new Product(proid, proname, proprice, prodetail, type_pro)
            {
                ProductID = proid,
                ProductName = proname,
                ProductPrice = proprice,
                ProductDetail = prodetail,
                TypeProduct = type_pro
            };
            int res = product.editProduct();
            MessageBox.Show(proname + proprice + prodetail,"",MessageBoxButtons.OKCancel);
            
        }

        private void edit_cancel_button_Click(object sender, EventArgs e)
        {
            edit_proid_textBox.Text = "";
            edit_proname_textBox.Text = "";
            edit_proprice_textBox.Text = "";
            edit_prodetail_textBox.Text = "";
        }
    }
}
