﻿using System;
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
            getOrder();
        }

        void getOrder()
        {
            Order orders = new Order();
            order_dataGridView.DataSource = orders.getOrder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int proid = int.Parse(del_proid_textBox.Text.ToString());

            Order order = new Order(proid);
            int res = order.delOrder();
        }
    }
}
