using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TesWin1
{
    class User
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

        public DataTable getUser()
        {
            adapter.SelectCommand = new SqlCommand("uspGetUser", con);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();

            return (dt);
        }
        public int addUser()
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
    }
}
