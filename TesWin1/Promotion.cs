using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace TesWin1
{
    public class PromotionList : IDictionary<int,PromotionList.Promotion>
    {
        public int PromotionID { get; set; }
        private Dictionary<int, Promotion> promodic = new Dictionary<int, Promotion>();

        public Promotion this[int key] {
            get
            {
                return (Promotion)promodic[key];
            }
            set
            {
                promodic[key] = value;
            }
        }

        

        public ICollection<int> Keys => promodic.Keys.OfType<int>().ToList();

        public ICollection<Promotion> Values => promodic.Values.OfType<Promotion>().ToList();

        public int Count => this.promodic.Count;

        public bool IsReadOnly { get; }

        public void Add(int key, Promotion value)
        {
            this.promodic.Add(key, value);
        }

        public void Add(KeyValuePair<int, Promotion> item)
        {
            this.promodic.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            this.promodic.Clear();
        }

        public bool Contains(KeyValuePair<int, Promotion> item)
        {
            return this.promodic.Contains(item);
        }

        public bool ContainsKey(int key)
        {
            return this.promodic.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<int, Promotion>[] array, int arrayIndex)
        {
            
        }

        public IEnumerator<KeyValuePair<int, Promotion>> GetEnumerator()
        {
            return this.promodic.GetEnumerator();
        }

        public bool Remove(int key)
        {
            return this.promodic.Remove(key);
        }

        public bool Remove(KeyValuePair<int, Promotion> item)
        {
            return this.promodic.Remove(item.Key);
        }



        public bool TryGetValue(int key, out Promotion value)
        {
            return this.promodic.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.promodic.GetEnumerator();
        }

        //public void selectPromo()
        //{
        //    SqlConnection con = new SqlConnection(Properties.Resources.ConnectionString);
        //    DataTable dt = new DataTable();

        //    try
        //    {
        //        SqlDataAdapter adapter = new SqlDataAdapter();
        //        SqlCommand sql_com = new SqlCommand("uspSelectPromotion", con);
        //        adapter.SelectCommand = sql_com;
        //        adapter.SelectCommand.Parameters.AddWithValue("@PromotionID", PromotionID);

        //        con.Open();
        //        adapter.SelectCommand.ExecuteNonQuery();
        //        adapter.Fill(dt);

        //        foreach (DataRow items in dt.Rows)
        //        {
        //            Promotion promo = new Promotion()
        //            {
        //                PromotionID = int.Parse(items["PromotionID"].ToString ()),
        //                PromotionName = items["PromotionName"].ToString(),
        //                PromotionDiscount = int.Parse(items["PromotionDiscount"].ToString()),
        //                PromotionType = int.Parse(items["PromotionType"].ToString())
        //            };
        //            this.promodic.Add(promo.PromotionID, promo);

        //        }
        //    }
        //    catch (SqlException error)
        //    {
        //        string str_error = error.Message;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
        public class Promotion
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
            public Promotion(int promoid)
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
                SqlConnection con = new SqlConnection(Properties.Resources.ConnectionString);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand sql_com = new SqlCommand("uspSelectPromotion", con);
                adapter.SelectCommand = sql_com;
                adapter.SelectCommand.Parameters.AddWithValue("@PromotionID", PromotionID);

                con.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.Fill(dt);
                con.Close();

                return (dt);

            }
        }
    }
}
