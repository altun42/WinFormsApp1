using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Ekle
    {
        public void ekle()
        {

            List<Personel> personels = new List<Personel>();
            SqlConnection sql_connect = new SqlConnection();
            SqlCommand sql_command = new SqlCommand();
            string connetionString = @"server=(localdb)\MSSQLLocalDB;Trusted_Connection=yes;database=AdayPersonelİnformation;";


            sql_connect.ConnectionString = connetionString;
            sql_command.Connection = sql_connect;
            sql_command.CommandText = "INSERT INTO Personeller(Name,LastName,Age,Wage,Pozition)";
            sql_connect.Open();
        }
    }
}
