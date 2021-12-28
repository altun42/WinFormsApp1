using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class BasvuruBilgileri : Form
    {
        public BasvuruBilgileri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Personel personel;
            Baglanti baglanti = new Baglanti();




            SqlConnection sql_connect = new SqlConnection();
            SqlCommand sql_command = new SqlCommand();

            string connetionString = @"server=(localdb)\MSSQLLocalDB;Trusted_Connection=yes;database=Personelİnformation;";



            sql_connect.ConnectionString = connetionString;
            sql_connect.Open();
            sql_command.Connection = sql_connect;
            sql_command.CommandText = "INSERT INTO PersonelAdayları(Name,LastName,Age,SalaryExpectation,Pozition) VALUES (@Name,@LastName,@Age,@SalaryExpectation,@Pozition)";

            sql_command.Parameters.AddWithValue("@Name", nametxt.Text);
            sql_command.Parameters.AddWithValue("@LastName", lastnametxt.Text);
            sql_command.Parameters.AddWithValue("@Age", Convert.ToInt32(agetxt.Text));
            sql_command.Parameters.AddWithValue("@SalaryExpectation",Convert.ToInt32(wagetxt.Text));
            sql_command.Parameters.AddWithValue("@Pozition", pozitiontxt.Text);
            

            
            sql_command.ExecuteNonQuery();


            sql_connect.Close();
            MessageBox.Show("Başvurunuz Şirkete Gönderilmiştir","Sistem Mesajı", MessageBoxButtons.OK);
            this.Close();
            
        }
    }
}
