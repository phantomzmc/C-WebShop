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
    public partial class ShowProduct : Form
    {
        

        public ShowProduct()
        {
            InitializeComponent();
        }

        private void ShowProduct_Load(object sender, EventArgs e)
        {
            Product product = new Product();
            dataGridView1.DataSource = product.getProduct();

        }

        private void del_proid_button_Click(object sender, EventArgs e)
        {
            int proid = int.Parse(del_proid_textBox.Text.ToString());

            Product product = new Product(proid);
            int res = product.delProduct();
            MessageBox.Show("ลบรายการที่ " + proid + "เรียบร้อย");
            
        }

        private void edit_proid_button_Click(object sender, EventArgs e)
        {
            EditProduct edit_view = new EditProduct();
            
            string proid = edit_proid_textBox.Text.ToString();
            var product = new Product(int.Parse(proid))
            {
                ProductID = int.Parse(proid)
            };
            product.setProID(int.Parse(proid));
            edit_view.Show();
        }
    }
}
