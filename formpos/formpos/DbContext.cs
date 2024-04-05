using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace formpos
{
    class DbContext
    {
        SqlConnection con = new SqlConnection(@"Data Source=IRYSIK\SQLEXPRESS;Initial Catalog=GeoDb;Integrated Security=True");

        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
