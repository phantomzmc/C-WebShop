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
    public class UserList : IDictionary<int,UserList.User>
    {
        public Dictionary<int, UserList.User> userlist = new Dictionary<int, UserList.User>();
        public User this[int key] {
            get
            {
                return (User)userlist[key];
            }
            set
            {
                userlist[key] = value;
            }
        }

        public ICollection<int> Keys => userlist.Keys.OfType<int>().ToList();

        public ICollection<User> Values => userlist.Values.OfType<User>().ToList();

        public int Count => userlist.Count;

        public bool IsReadOnly { get; }

        public void Add(int key, User value)
        {
            userlist.Add(key, value);
        }

        public void Add(KeyValuePair<int, User> item)
        {
            userlist.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            userlist.Clear();
        }

        public bool Contains(KeyValuePair<int, User> item)
        {
            return userlist.Contains(item);
        }

        public bool ContainsKey(int key)
        {
            return userlist.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<int, User>[] array, int arrayIndex)
        {
            
        }

        public IEnumerator<KeyValuePair<int, User>> GetEnumerator()
        {
            return userlist.GetEnumerator();
        }

        public bool Remove(int key)
        {
            return userlist.Remove(key);
        }

        public bool Remove(KeyValuePair<int, User> item)
        {
            return userlist.Remove(item.Key);
        }

        public bool TryGetValue(int key, out User value)
        {
            return userlist.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return userlist.GetEnumerator();
        }

        public class User : InterfaceUser
        {
            SqlConnection con = new SqlConnection(Properties.Resources.ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            public int UserID { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Email { get; set; }
            public string Tel { get; set; }
            public string Username { get; set; }
            public string Gender { get; set; }
            public DateTime BirthDay { get; set; }
            public string NumAddress { get; set; }
            public string Tambun { get; set; }
            public string Amphoe { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public string Postnumber { get; set; }

            public User()
            {

            }
            public User(
                string firstname,
                string lastname,
                string email,
                string tel,
                string username,
                string gender,
                DateTime birthday,
                string numaddress,
                string tambon,
                string amphoe,
                string city,
                string country,
                string postnum)
            {
                Firstname = firstname;
                Lastname = lastname;
                Email = email;
                Tel = tel;
                Username = username;
                Gender = gender;
                BirthDay = birthday;
                NumAddress = numaddress;
                Tambun = tambon;
                Amphoe = amphoe;
                City = city;
                Country = country;
                Postnumber = postnum;
            }

            DataTable InterfaceUser.getUser()
            {
                adapter.SelectCommand = new SqlCommand("uspGetUser", con);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                con.Open();
                adapter.Fill(dt);
                con.Close();

                return (dt);
            }

            int InterfaceUser.addUser()
            {
                adapter.InsertCommand = new SqlCommand("uspAddUser", con);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.AddWithValue("@FirstName", Firstname);
                adapter.InsertCommand.Parameters.AddWithValue("@LastName", Lastname);
                adapter.InsertCommand.Parameters.AddWithValue("@Email", Email);
                adapter.InsertCommand.Parameters.AddWithValue("@Tel", Tel);
                adapter.InsertCommand.Parameters.AddWithValue("@Username", Username);
                adapter.InsertCommand.Parameters.AddWithValue("@Gender", Gender);
                adapter.InsertCommand.Parameters.AddWithValue("@BrithDay", DateTime.Now);
                adapter.InsertCommand.Parameters.AddWithValue("@NumAddress", NumAddress);
                adapter.InsertCommand.Parameters.AddWithValue("@Tumbun", Tambun);
                adapter.InsertCommand.Parameters.AddWithValue("@Amphoe", Amphoe);
                adapter.InsertCommand.Parameters.AddWithValue("@City", City);
                adapter.InsertCommand.Parameters.AddWithValue("@Country", Country);
                adapter.InsertCommand.Parameters.AddWithValue("@PostNumber", Postnumber);

                con.Open();
                int res = adapter.InsertCommand.ExecuteNonQuery();
                con.Close();

                return res;
            }

            int InterfaceUser.editUser()
            {
                throw new NotImplementedException();
            }
        }
    }
    
}
