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

        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int OrderQty { get; set; }
        public int OrderPrice { get; set; }
        public DateTime OrderTime { get; set; }
        public int UserID { get; set; }

        public Order()
        {

        }

        public Order(int orderid)
        {
            OrderID = orderid;
        }
        public Order(int productid, int orderqty, int orderprice, int userid, DateTime ordertime)
        {
            ProductID = productid;
            OrderQty = orderqty;
            OrderPrice = orderprice;
            UserID = userid;
            OrderTime = ordertime;
        }

        
        public DataTable getOrder()
        {

            con.Open();
            SqlCommand sql_com = new SqlCommand("uspGetOrder", con);

            adapter.SelectCommand = sql_com;
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();

            return (dt);
        }

        public int addOrder()
        {
            SqlCommand sql_com = new SqlCommand("uspAddOrder", con);
            adapter.InsertCommand = sql_com;
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.AddWithValue("@ProductID", ProductID);
            adapter.InsertCommand.Parameters.AddWithValue("@OrderQty", OrderQty);
            adapter.InsertCommand.Parameters.AddWithValue("@OrderPrice", OrderPrice);
            adapter.InsertCommand.Parameters.AddWithValue("@UserID", UserID);
            adapter.InsertCommand.Parameters.AddWithValue("@OrderTime", OrderTime);

            con.Open();
            int res = adapter.InsertCommand.ExecuteNonQuery();
            con.Close();

            return res;
        }

        public int delOrder()
        {
            SqlCommand sql_com = new SqlCommand("uspDelOrder", con);
            adapter.InsertCommand = sql_com;
            adapter.InsertCommand.Parameters.AddWithValue("@OrderID", OrderID);

            con.Open();
            int res = adapter.InsertCommand.ExecuteNonQuery();
            con.Close();

            return res;
        
        }

        
    }

    
}
