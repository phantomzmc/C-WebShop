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
    public partial class AddTypeProduct : Form
    {
        public AddTypeProduct()
        {
            InitializeComponent();
        }

        private void AddTypeProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typename = textBox1.Text.ToString();
            string typedetail = textBox2.Text.ToString();

            label1.Text = typename;
            label2.Text = typedetail;

            ProductType producttype = new ProductType(typename, typedetail)
            {
                TypeName = typename,
                TypeDetail = typedetail
            };
            int res = producttype.addProductType();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            label1.Text = "ชื่อประเภทสินค้า :";
            label2.Text = "รายละเอียดประเภทสินค้า :";
        }
    }
}
