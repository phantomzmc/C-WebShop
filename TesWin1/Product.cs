using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace TesWin1
{
    public class Product
    {
        SqlConnection con = new SqlConnection(Properties.Resources.ConnectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductDetail { get; set; }
        public int TypeProduct { get; set; }

        //construter
        public Product() { }
        public Product(int productid) { }
        public Product(int productid,string productname, int productprice, string productdetail, int typeproduct) { }
        public Product(string productname, int productprice, string productdetail, int typeproduct) { }


        public int addProduct()
        {
            adapter.InsertCommand = new SqlCommand("uspAddProduct", con);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

            adapter.InsertCommand.Parameters.AddWithValue("@ProductName", ProductName);
            adapter.InsertCommand.Parameters.AddWithValue("@ProductPrice", ProductPrice);
            adapter.InsertCommand.Parameters.AddWithValue("@ProductDetail", ProductDetail);
            adapter.InsertCommand.Parameters.AddWithValue("@TypeProduct", TypeProduct);

            con.Open();
            int res = adapter.InsertCommand.ExecuteNonQuery();
            con.Close();

            return res;
        }

        public DataTable selectProduct()
        {
            adapter.SelectCommand = new SqlCommand("uspSelectProduct", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@ProductID", ProductID);

            con.Open();
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();

            return (dt);
        }

        public DataTable getProduct()
        {
            adapter.SelectCommand = new SqlCommand("uspGetProduct", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();

            return (dt);
        }

        public int delProduct()
        {
            adapter.DeleteCommand = new SqlCommand("uspDelProduct", con);
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

            adapter.DeleteCommand.Parameters.AddWithValue("@ProductID", ProductID);

            con.Open();
            int res = adapter.DeleteCommand.ExecuteNonQuery();
            con.Close();

            return res;
        }

        public int editProduct()
        {
            adapter.UpdateCommand = new SqlCommand("uspUpdateProduct", con);
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adapter.UpdateCommand.Parameters.AddWithValue("@ProductID", ProductID);
            adapter.UpdateCommand.Parameters.AddWithValue("@ProductName", ProductName);
            adapter.UpdateCommand.Parameters.AddWithValue("@ProductPrice", ProductPrice);
            adapter.UpdateCommand.Parameters.AddWithValue("@ProductDetail", ProductDetail);
            adapter.UpdateCommand.Parameters.AddWithValue("@TypeProduct", TypeProduct);

            con.Open();
            int res = adapter.UpdateCommand.ExecuteNonQuery();
            con.Close();
            return res;
        }
        public int setProID(int proid)
        {
            ProductID = proid;
            return proid;
        }
    }
}
