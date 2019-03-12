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
    public partial class AddOrder : Form
    {
        private int qty = 0;
        private int price = 0;
        private int total = 0;
        //private int promo_id = 0;
        //private int promo_type = 0;
        //private int discount = 0;
        public AddOrder()
        {
            InitializeComponent();
        }
        Array items = new[] {
                        new { Text = "1", Value = "1" },
                        new { Text = "2", Value = "2" },
                        new { Text = "3", Value = "3" },
                        new { Text = "4", Value = "4" },
                        new { Text = "5", Value = "5" }
        };
        //model
        InterfaceUser user = new UserList.User();
        Product product = new Product();
        Promotion promo = new Promotion();

        InterfaceProduct iproduct = new Product();


        private void AddOrder_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            getUser();
            getProduct();
            getQty();
            getPromotion();

            qty_label.Text = qty.ToString();
            price_label2.Text = "Price";
            date_label.Text = date.ToString();
        }

        void getPromotion()
        {
            promo_comboBox.DataSource = promo.getPromotion();
            promo_comboBox.DisplayMember = "PromotionName";
            promo_comboBox.ValueMember = "PromotionID";

        }
        void getUser()
        {
            user_comboBox.DataSource = user.getUser();
            user_comboBox.DisplayMember = "FirstName";
            user_comboBox.ValueMember = "UserID";
        }
        void getProduct()
        {
            product_comboBox.DataSource = iproduct.getProduct();
            product_comboBox.DisplayMember = "ProductName";
            product_comboBox.ValueMember = "ProductID";
        }
        void changedProduct()
        {
            Product product = new Product(int.Parse(product_comboBox.SelectedValue.ToString()));
            DataTable dt = iproduct.selectProduct();
            price_label2.Text = Convert.ToString(dt.Rows[0]["ProductPrice"]);

            price = Convert.ToInt32(dt.Rows[0]["ProductPrice"]);
            
        }
        void selectPromotion()
        {
            Promotion promo = new Promotion(int.Parse(promo_comboBox.SelectedValue.ToString()));
            DataTable dt = promo.selectPromotion();

            //promo_comboBox.Text = Convert.ToString(dt.Rows[0]["PromotionDiscount"]);

            //promo_type = Convert.ToInt32(dt.Rows[0]["PromotionType"]);
            //discount = Convert.ToInt32(dt.Rows[0]["PromotionDiscount"]);

        }
        void sumTotal()
        {
            total = price * qty;
            total_label.Text = total.ToString();
        }
        void getQty()
        {  
            qty_comboBox.DataSource = items;
            qty_comboBox.DisplayMember = "Text";
            qty_comboBox.ValueMember = "Value";
            qty = int.Parse(qty_comboBox.SelectedValue.ToString());
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("OK", "Submit",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                changedProduct();
                sumTotal();
                //selectPromotion();
            }
        }

        private void product_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //qty_label.Text = product_comboBox.SelectedValue.ToString();
            sumTotal();
        }

        private void qty_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            qty_label.Text =qty_comboBox.SelectedValue.ToString();
            getQty();
            sumTotal();
        }

        private void submit_button2_Click(object sender, EventArgs e)
        {
            int productid = int.Parse(product_comboBox.SelectedValue.ToString());
            int orderqty = int.Parse(qty_label.Text);
            int orderprice = int.Parse(total_label.Text);
            int userid = int.Parse(user_comboBox.SelectedValue.ToString());
            DateTime ordertime = DateTime.Now;

            Order orders = new Order(productid, orderqty, orderprice,userid,ordertime);
            int res = orders.addOrder();

            MessageBox.Show("Add Order OK!!");
        }

        private void promo_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             
        }
    }
}
