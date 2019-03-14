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
    public partial class ShowOrder : Form
    {
        public ShowOrder()
        {
            InitializeComponent();
        }

        private void ShowOrder_Load(object sender, EventArgs e)
        {
            //getOrder();
            OrderDic orders = new OrderDic();
            orders.getOrder();
            order_dataGridView.DataSource = orders.Values;

        }

        void getOrder()
        {
            OrderDic.Order orders = new OrderDic.Order();
            order_dataGridView.DataSource = orders.getOrder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int proid = int.Parse(del_proid_textBox.Text.ToString());

            OrderDic.Order orders = new OrderDic.Order(int.Parse(del_proid_textBox.Text.ToString()));
            int res = orders.delOrder();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            //ordersid = int.Parse(edit_order_textBox.Text.ToString());

            OrderDic.Order orders = new OrderDic.Order(int.Parse(edit_order_textBox.Text.ToString()));
            EditOrder edit_order = new EditOrder();
            edit_order.Show();
            //InterfaceOrder orders = new Order(proid);
            //int res = orders.editOrder();
        }
    }
}
