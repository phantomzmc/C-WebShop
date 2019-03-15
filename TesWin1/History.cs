using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesWin1
{
    public class HistoryList : IDictionary<int, HistoryList.History>
    {
        public Dictionary<int, HistoryList.History> historylist = new Dictionary<int, History>();
        SqlConnection con = new SqlConnection(Properties.Resources.ConnectionString);
        SqlDataAdapter adapter = new SqlDataAdapter();


        #region Implement
        public History this[int key]
        {
            get
            {
                return (History)historylist[key];
            }
            set
            {
                historylist[key] = value;
            }
        }

        public ICollection<int> Keys => this.historylist.Keys.OfType<int>().ToList();

        public ICollection<History> Values => this.historylist.Values.OfType<History>().ToList();

        public int Count => this.historylist.Count;

        public bool IsReadOnly { get; }

        public void Add(int key, History value)
        {
            this.historylist.Add(key, value);
        }

        public void Add(KeyValuePair<int, History> item)
        {
            this.historylist.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            this.historylist.Clear();
        }

        public bool Contains(KeyValuePair<int, History> item)
        {
            return this.historylist.Contains(item);
        }

        public bool ContainsKey(int key)
        {
            return this.historylist.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<int, History>[] array, int arrayIndex)
        {
            
        }

        public IEnumerator<KeyValuePair<int, History>> GetEnumerator()
        {
            return this.historylist.GetEnumerator();
        }

        public bool Remove(int key)
        {
            return this.historylist.Remove(key);
        }

        public bool Remove(KeyValuePair<int, History> item)
        {
            return this.historylist.Remove(item.Key);
        }

        public bool TryGetValue(int key, out History value)
        {
            return this.historylist.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.historylist.GetEnumerator();
        }
        #endregion

        public void selectHistory()
        {
            try
            {
                adapter.SelectCommand = new SqlCommand("uspGetHistory", con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                con.Open();
                adapter.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    History history = new History()
                    {
                        FirstName = item["FirstName"].ToString(),
                        LastName = item["LastName"].ToString(),
                        OrderID = int.Parse(item["OrderID"].ToString()),
                        Email = item["Email"].ToString()
                    };
                    this.historylist.Add(history.OrderID, history);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        public class History
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Tel { get; set; }
            public int InvoiceID { get; set; }
            public string PromotionName { get; set; }
            public int OrderID { get; set; }
            public History() { }
        }
    }


}
