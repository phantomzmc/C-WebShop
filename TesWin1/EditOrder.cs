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
    public partial class EditOrder : Form
    {
        int qty = 0;
        public EditOrder()
        {
            InitializeComponent();
        }


        private void EditOrder_Load(object sender, EventArgs e)
        {
            selectOrder();
            getProduct();
            getQty();
        }
        void selectOrder()
        {
            OrderDic.Order order = new OrderDic.Order();

            order.getOrderid();

        }
        void getProduct()
        {
            Product product = new Product();
            comboBox1.DataSource = product.getProduct();
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ProductID";
        }
        void getQty()
        {
            Array items = new[] {
                        new { Text = "1", Value = "1" },
                        new { Text = "2", Value = "2" },
                        new { Text = "3", Value = "3" },
                        new { Text = "4", Value = "4" },
                        new { Text = "5", Value = "5" }
        };
            comboBox2.DataSource = items;
            comboBox2.DisplayMember = "Text";
            comboBox2.ValueMember = "Value";
            this.qty = int.Parse(comboBox2.SelectedValue.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getQty();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getProduct();
        }

        private void edit_order_button_Click(object sender, EventArgs e)
        {
            int orderid = int.Parse(edit_order_textBox.Text.ToString());
            int productid = int.Parse(comboBox1.SelectedValue.ToString());
            int orderqty = this.qty;
            DateTime ordertime = DateTime.Now;

            OrderDic.Order order = new OrderDic.Order(orderid, productid, orderqty, ordertime);
            int res = order.editOrder();


        }
    }
}
