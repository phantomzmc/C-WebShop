using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace TesWin1
{
    public class OrderDic : IDictionary<int, OrderDic.Order>
    {

        private Dictionary<int, OrderDic.Order> orderdic= new Dictionary<int, OrderDic.Order>();

        public void getOrder()
        {
            SqlConnection con = new SqlConnection(Properties.Resources.ConnectionString);
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                con.Open();
                SqlCommand sql_com = new SqlCommand("uspGetOrder", con);
                adapter.SelectCommand = sql_com;
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(dt);

                foreach(DataRow item in dt.Rows)
                {
                    Order orders = new Order()
                    {
                        OrderID = int.Parse(item["OrderID"].ToString()),
                        ProductName = item["ProductName"].ToString(),
                        ProductPrice = int.Parse(item["ProductPrice"].ToString()),
                        OrderPrice = int.Parse(item["OrderPrice"].ToString()),
                        FirstName = item["FirstName"].ToString(),
                        LastName = item["LastName"].ToString(),
                        OrderQty = int.Parse(item["OrderQty"].ToString()),
                        
                    };
                    orderdic.Add(orders.OrderID, orders);
                    
                }
            }
            catch (SqlException error)
            {
                string str_error = error.Message;
            }
            finally
            {
                con.Close();

            }
        }

        #region Imprement
        public Order this[int key] {
            get
            {
                return (Order)orderdic[key];
            }
            set
            {
                orderdic[key] = value;
            }
        }
    
        public ICollection<int> Keys => orderdic.Keys.OfType<int>().ToList();

        public ICollection<Order> Values => orderdic.Values.OfType<Order>().ToList();

        public int Count => orderdic.Count;

        public bool IsReadOnly { get; }

        public void Add(int key, Order value)
        {
            orderdic.Add(key, value);
        }

        public void Add(KeyValuePair<int, Order> item)
        {
            orderdic.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            orderdic.Clear();
        }

        public bool Contains(KeyValuePair<int, Order> item)
        {
            return orderdic.Contains(item);
        }

        public bool ContainsKey(int key)
        {
            return orderdic.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<int, Order>[] array, int arrayIndex)
        {
            
        }

        public IEnumerator<KeyValuePair<int, Order>> GetEnumerator()
        {
            return orderdic.GetEnumerator();
        }

        public bool Remove(int key)
        {
            return orderdic.Remove(key);
        }

        public bool Remove(KeyValuePair<int, Order> item)
        {
            return orderdic.Remove(item.Key);
        }

        public bool TryGetValue(int key, out Order value)
        {
            return orderdic.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return orderdic.GetEnumerator();
        }

        #endregion
        public class Order
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

            public DataTable ObjData { get; set; }

            public Order()
            {

            }

            public Order(int orderid)
            {
                OrderID = orderid;
            }
            public Order(int orderid,int productid, int orderqty, DateTime ordertime)
            {

                OrderID = orderid;
                ProductID = productid;
                OrderQty = orderqty;
                OrderTime = ordertime;
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
                adapter.DeleteCommand = new SqlCommand("uspDelOrder", con);
                adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
                adapter.DeleteCommand.Parameters.AddWithValue("@OrderID", OrderID);

                con.Open();
                int res = adapter.DeleteCommand.ExecuteNonQuery();
                con.Close();

                return res;
            }

            public DataTable selectOrder()
            {
                adapter.SelectCommand = new SqlCommand("uspSelectOrder", con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@OrderID", OrderID);

                con.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                ObjData = dt;
                con.Close();

                return (dt);
            }
            public int getOrderid()
            {
                return OrderID;
            }
            public int editOrder()
            {
                SqlCommand sql_com = new SqlCommand("uspUpdateOrder", con);
                sql_com.CommandType = CommandType.StoredProcedure;
                adapter.UpdateCommand = sql_com;
                adapter.UpdateCommand.Parameters.AddWithValue("@OrderID", OrderID);
                adapter.UpdateCommand.Parameters.AddWithValue("@ProductID", ProductID);
                adapter.UpdateCommand.Parameters.AddWithValue("@OrderQty", OrderQty);
                adapter.UpdateCommand.Parameters.AddWithValue("@OrderTime", OrderTime);

                con.Open();
                int res = adapter.UpdateCommand.ExecuteNonQuery();
                con.Close();

                return res;
            }
        }

    }
    
}
