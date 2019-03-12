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
    public interface ControlUser
    {
        void addUser();
        void getUser();
    }
    
    public partial class AddUser : Form,ControlUser
    {
        private DateTime brithdate;
        public AddUser()
        {
            InitializeComponent();
        }
        Array gender = new[] {
                        new { Text = "Men", Value = "M" },
                        new { Text = "Women", Value = "W" }
        };
        //model
        UserList.User users = new UserList.User();

        private void AddUser_Load(object sender, EventArgs e)
        {
            getGen();
        }

        void addUser()
        {
            string firstname = firstname_textBox.Text.ToString();
            string lastname = lastname_textBox.Text.ToString();
            string email = email_textBox.Text.ToString();
            string tel = tel_textBox.Text.ToString();
            string username = username_textBox.Text.ToString();
            DateTime birthday = dateTimePicker1.Value.Date;
            string gender = comboBox1.SelectedValue.ToString();
            string numaddress = numaddress_textBox.Text.ToString();
            string tambon = tambun_textBox.Text.ToString();
            string amphoe = amphoe_textBox.Text.ToString();
            string city = city_textBox.Text.ToString();
            string country = country_textBox.Text.ToString();
            string postnum = postnum_textBox.Text.ToString();


            InterfaceUser users = new UserList.User(firstname,lastname,email,tel,username,gender,birthday,numaddress,tambon,amphoe,city,country,postnum);
            int res = users.addUser();
        }
        void getGen()
        {
            comboBox1.DataSource = gender;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            firstname_textBox.Text = "Name";
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            addUser();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            gen_label.Text = comboBox1.SelectedValue.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthdates = dateTimePicker1.Value;
            brithdate = birthdates;
            brithdate_label.Text = birthdates.ToString("dd/MMM/yyyy");
        }

        void ControlUser.addUser()
        {
            throw new NotImplementedException();
        }

        void ControlUser.getUser()
        {
            throw new NotImplementedException();
        }
    }
}
