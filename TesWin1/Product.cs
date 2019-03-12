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
    public class Product : InterfaceProduct
    {
        SqlConnection con = new SqlConnection(Properties.Resources.ConnectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();

        public int ProductID { get; set; }
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
        public Product(int productid)
        {
            ProductID = productid;
        }


        int InterfaceProduct.addProduct()
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

        DataTable InterfaceProduct.selectProduct()
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

        DataTable InterfaceProduct.getProduct()
        {
            adapter.SelectCommand = new SqlCommand("uspGetProduct", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();

            return (dt);
        }

        DataTable InterfaceProduct.getType()
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
    }
}
