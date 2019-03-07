using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TesWin1
{
    class Order
    {
        SqlConnection con = new SqlConnection(Properties.Resources.ConnectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int OrderQty { get; set; }
        public int OrderPrice { get; set; }
        public DateTime OrderTime { get; set; }

        public Order()
        {

        }

        public DataTable getOrder()
        {
            adapter.SelectCommand = new SqlCommand("uspGetOrder", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();

            return (dt);
        }
    }

    
}
