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
    public partial class ShowHistory : Form
    {
        public ShowHistory()
        {
            InitializeComponent();
        }

        private void ShowHistory_Load(object sender, EventArgs e)
        {
            HistoryList history = new HistoryList();
            history.selectHistory();
            dataGridView1.DataSource = history.Values;
        }
    }
}
