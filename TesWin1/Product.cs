using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace TesWin1
{
    class Product
    {
        SqlConnection con = new SqlConnection(Properties.Resources.ConnectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductDetail { get; set; }
        public int TypeProduct { get; set; }


        public Product()
        {

        }

        public Product(string productname, int productprice, string productdetail, int typeproduct)
        {
            ProductName = productname;
            ProductPrice = productprice;
            ProductDetail = productdetail;
            TypeProduct = typeproduct;
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
        public DataTable getTypeProduct()
        {
            adapter.SelectCommand = new SqlCommand("uspGetTypeProduct", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dr = new DataTable();
            con.Open();
            adapter.Fill(dr);
            Debug.Write(dr);
            con.Close();

            return (dr);
        }

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
    }
}
