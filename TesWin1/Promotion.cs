using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TesWin1
{
    class Promotion
    {
        SqlConnection con = new SqlConnection(Properties.Resources.ConnectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();
        public int PromotionID { get; set; }
        public string PromotionName { get; set; }
        public int PromotionDiscount { get; set; }
        public int PromotionType { get; set; }

        public Promotion()
        {

        }
        public Promotion (int promoid)
        {
            PromotionID = promoid;
        }

        public DataTable getPromotion()
        {
            SqlCommand sql_com = new SqlCommand("uspGetPromotion", con);
            adapter.SelectCommand = sql_com;

            con.Open();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();

            return (dt);

        }
        public DataTable selectPromotion()
        {
            SqlCommand sql_com = new SqlCommand("uspSelectPromotion", con);
            adapter.SelectCommand = sql_com;
            adapter.SelectCommand.Parameters.AddWithValue("@PromotionID", PromotionID);

            con.Open();
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();

            return (dt);
        
        }


        
    }
}
