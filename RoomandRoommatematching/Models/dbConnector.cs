
using System;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for MSSQLConnector
/// </summary>
namespace RoomAndRoomMate.Models
{
    public class dbConnector
    {
        private SqlConnection _SiteConnection = null;

        public SqlConnection Connection
        {
            get
            {
                if (_SiteConnection == null)
                {
                    String connString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=roomandroommate;User ID=roommate;Password=roommate@12345;Connect Timeout=30;";
                    _SiteConnection = new SqlConnection();
                    _SiteConnection.ConnectionString = connString;
                }

                return _SiteConnection;
            }
        }

        public DataSet ExecuteDataSet(string queryString, SqlConnection conn)
        {
            SqlCommand command = new SqlCommand(queryString, conn);
            command.CommandTimeout = 120;
            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            ad.Dispose();
            return ds;
        }

        public DataSet ExecuteDataSet(SqlCommand command, SqlConnection conn)
        {
            command.Connection = conn;
            command.CommandTimeout = 120;
            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            ad.Dispose();
            return ds;
        }

        public string ExecuteScalar_Base(SqlCommand command, SqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            command.Connection = conn;
            string s = command.ExecuteScalar().ToString();
            conn.Close();
            return s;
        }

        public string ExecuteScalar_Base(string queryString, SqlConnection conn)
        {
            
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand(queryString, conn);
            string s = command.ExecuteScalar().ToString();
            conn.Close();
            return s;
        }

        public string ExecuteNonQuery(string queryString, SqlConnection conn)
        {
            SqlCommand command = new SqlCommand(queryString, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string s = "1";
            conn.Close();
            return s;
        }

        public string ExecuteNonQuery(SqlCommand command, SqlConnection conn)
        {
            command.Connection = conn;
            command.CommandTimeout = 120;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string s = command.ExecuteNonQuery().ToString();
            conn.Close();

            return s;
        }
    }
}