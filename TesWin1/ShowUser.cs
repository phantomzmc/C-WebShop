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
        InterfaceUser users = new UserList.User();
        public ShowUser()
        {
            InitializeComponent();
        }

        private void ShowUser_Load(object sender, EventArgs e)
        {
            getUser();
        }
        void getUser()
        {
            user_dataGridView.DataSource = users.getUser();
        }
    }
}
