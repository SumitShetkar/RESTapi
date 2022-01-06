using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Cricketer.Models
{
    public class CricketerDAOImpl : CricketerDAO
    {
        private static CricketerDAOImpl impl = null;
        static List<Cricketer> list = new List<Cricketer>();
        static SqlConnection connection;

        private CricketerDAOImpl()
        {

        }

        public static CricketerDAOImpl GetCricketerDAOImplInstance()
        {
            if(impl == null)
                impl = new CricketerDAOImpl();

            connection = DBConnection.GetSqlConnection();
            connection.Open();
            return impl;
        }

        public void AddCricketer(Cricketer cricketer)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "insert into cricketers Values(" + cricketer.ID + ",'" + cricketer.Name + "'," + cricketer.JerseyNo + ",'" + cricketer.DOB + "'," + cricketer.Age + ",'" + cricketer.Country + "','" + cricketer.Role + "')";
            command.ExecuteNonQuery();

        }

        public void DeleteCricketer(int id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "delete from cricketers where id = " + id + " ";
            command.ExecuteNonQuery();
        }

        public List<Cricketer> GetAllCricketers()
        {
            list.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from cricketers";
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                int ID = Int32.Parse(read[0].ToString());
                string name = read[1].ToString();
                int jerseyNo = Int32.Parse(read[2].ToString());
                DateTime dob = DateTime.Parse(read[3].ToString());
                int age = Int32.Parse(read[4].ToString());
                string country = read[5].ToString();
                string role = read["role"].ToString();
              

                list.Add(new Cricketer(ID, name, jerseyNo, dob,age,country,role));

            }

            read.Close();
            return list;
        }

        public Cricketer GetCricketer(int id)
        {
            Cricketer cricketer = null;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select*from cricketers where id=" + id + "";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ID = Int32.Parse(reader[0].ToString());
                string name = reader[1].ToString();
                int jerseyNo = Int32.Parse(reader[2].ToString());
                DateTime dob = DateTime.Parse(reader[3].ToString());
                int age = Int32.Parse(reader[4].ToString());
                string country = reader[5].ToString();
                string role = reader[6].ToString();
                cricketer = new Cricketer(ID, name, jerseyNo, dob, age, country, role);
            }
            reader.Close();
            return cricketer;
        }

        public void UpdateCricketer(Cricketer cricketer)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "update cricketers set name = '" + cricketer.Name + "', jerseyNo = " + cricketer.JerseyNo + ",dob = '" + cricketer.DOB + "',age = " + cricketer.Age + ",country = '" + cricketer.Country + "',Role = '" + cricketer.Role + "' where id = " + cricketer.ID + " ";
            command.ExecuteNonQuery();
        }
    }
}