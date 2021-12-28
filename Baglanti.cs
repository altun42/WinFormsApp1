using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Baglanti
    {
        public List<Personel> PersonelGetir()
        {
            List<Personel> personels = new List<Personel>();
            SqlConnection sql_connect = new SqlConnection();
            SqlCommand sql_command = new SqlCommand();
           
            string connetionString = @"server=(localdb)\MSSQLLocalDB;Trusted_Connection=yes;database=Personelİnformation;";

           
            sql_connect.ConnectionString = connetionString;
             sql_connect.Open();
            sql_command.Connection = sql_connect;
            sql_command.CommandText = "SELECT * FROM PersonelAdayları";
            
            SqlDataReader reader = sql_command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    Personel personel = new Personel();
                    personel.Id = Convert.ToInt32(reader["Id"].ToString());
                    personel.Name = reader["Name"].ToString();
                    personel.LastName = reader["LastName"].ToString();
                    personel.Age = Convert.ToInt32(reader["Age"].ToString());
                    personel.SalaryExpectation = Convert.ToInt32(reader["SalaryExpectation"]);
                    personel.Pozition = reader["Pozition"].ToString();
                    personels.Add(personel);
                }
                catch (Exception ex)
                {

                   
                }
            }
            
            sql_connect.Close();



            return personels;


            
           
        }
    }
}
