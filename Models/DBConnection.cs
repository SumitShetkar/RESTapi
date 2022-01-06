using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Cricketer.Models
{
    public class DBConnection
    {
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SumitS9\Documents\MyDB.mdf;Integrated Security=True;Connect Timeout=30";
            return connection;

        }
    }
}