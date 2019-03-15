using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TesWin1
{
    public class ProductType
    {
        SqlConnection con = new SqlConnection(Properties.Resources.ConnectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();

        public string TypeName { get; set; }
        public string TypeDetail { get; set; }

        public ProductType() { }
        public ProductType(string typename,string typedetail) { }


        public DataTable getType()
        {
            adapter.SelectCommand = new SqlCommand("uspGetTypeProduct", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dr = new DataTable();
            con.Open();
            adapter.Fill(dr);
            con.Close();

            return (dr);
        }
        public int addProductType()
        {
            adapter.InsertCommand = new SqlCommand("uspAddProductType", con);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.AddWithValue("@TypeName", TypeName);
            adapter.InsertCommand.Parameters.AddWithValue("@TypeDetail", TypeDetail);

            con.Open();
            int res = adapter.InsertCommand.ExecuteNonQuery();
            con.Close();

            return res;

        }
        
    }
}
