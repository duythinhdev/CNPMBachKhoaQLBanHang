using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace Project
{
    class clsqlbanhang
    {

        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3308;
            string database = "sneaker";
            string username = "root";
            string password = "";

            return GetDBConnection(host, port, database, username, password);
        }

        public static MySqlConnection
         GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);
            if(conn.State == ConnectionState.Closed)
                conn.Open();
            return conn;

        }

        public DataSet LoadData(string sql)
        {
            MySqlCommand cmd = GetDBConnection().CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            return ds;
        }
            
        public int UpdateData(string sql)
        {
            MySqlCommand cmd = GetDBConnection().CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            return cmd.ExecuteNonQuery();
        }

    }
}
