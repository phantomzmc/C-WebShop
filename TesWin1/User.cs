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
    }
}
