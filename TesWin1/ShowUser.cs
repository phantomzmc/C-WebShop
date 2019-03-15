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
    public partial class ShowUser : Form
    {
        
        public ShowUser()
        {
            InitializeComponent();
        }

        private void ShowUser_Load(object sender, EventArgs e)
        {
            UserList u = new UserList();
            u.SelectUser();

            this.user_dataGridView.DataSource = u.Values;
            //getUser();
        }
        void getUser()
        {
            //user_dataGridView.DataSource = users.getUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditUser edit_user = new EditUser();
            edit_user.Show();
        }
    }
}
