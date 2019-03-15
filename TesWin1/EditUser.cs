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
    public partial class EditUser : Form
    {
        UserList.User user = new UserList.User();

        Array gender = new[] {
                        new { Text = "Men", Value = "M" },
                        new { Text = "Women", Value = "W" }
        };
        public EditUser()
        {
            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            getUser();
            getGen();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            editUser();
        }
        void getUser()
        {
            user_comboBox.DataSource = user.getUser();
            user_comboBox.DisplayMember = "FirstName";
            user_comboBox.ValueMember = "UserID";
        }
        void getGen()
        {
            comboBox1.DataSource = gender;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }
        void editUser()
        {
            int userid = int.Parse(user_comboBox.SelectedValue.ToString());
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


            UserList.User users = new UserList.User(userid, firstname, lastname, email, tel, username, gender, birthday, numaddress, tambon, amphoe, city, country, postnum)
            {
                UserID = userid,
                Firstname = firstname,
                Lastname = lastname,
                Email = email,
                Tel = tel,
                Username = username,
                Gender = gender,
                BirthDay = birthday,
                NumAddress = numaddress,
                Tambun = tambon,
                Amphoe = amphoe,
                City = city,
                Country = country,
                Postnumber = postnum
            };
            int res = users.editUser();
        }
    }
}
