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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void görüntülebtn_Click(object sender, EventArgs e)
        {
            SqlConnection sql_connect = new SqlConnection();
            SqlCommand sql_command = new SqlCommand();
            string connetionString = @"server=(localdb)\MSSQLLocalDB;Trusted_Connection=yes;database=Personelİnformation;";

            SqlDataAdapter sql_ada = new SqlDataAdapter();
            DataTable dt = new DataTable();

            sql_connect.ConnectionString = connetionString;
            sql_command.Connection = sql_connect;
            sql_command.CommandText = "SELECT * FROM PersonelAdayları";

            sql_ada.SelectCommand = sql_command;
            sql_ada.Fill(dt);

            dataGridView1.DataSource = dt;

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }
        

      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            sql_command.CommandText = "INSERT INTO Personeller(Name,LastName,Age,Wage,Pozition) SELECT @Name,LastName,Age,SalaryExpectation,Pozition From PersonelAdayları Where Name = @Name and LastName = @LastName";
            
            sql_command.Parameters.AddWithValue("@Name", textBox2.Text);
            sql_command.Parameters.AddWithValue("@LastName", textBox3.Text);

            sql_command.ExecuteNonQuery();


            sql_connect.Close();








        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personel personel;
            Baglanti baglanti = new Baglanti();




            SqlConnection sql_connect = new SqlConnection();
            SqlCommand sql_command = new SqlCommand();

            string connetionString = @"server=(localdb)\MSSQLLocalDB;Trusted_Connection=yes;database=Personelİnformation;";



            sql_connect.ConnectionString = connetionString;
            sql_connect.Open();
            sql_command.Connection = sql_connect;
            sql_command.CommandText = "DELETE PersonelAdayları Where Name = @Name and LastName = @LastName";

            sql_command.Parameters.AddWithValue("@Name", textBox2.Text);
            sql_command.Parameters.AddWithValue("@LastName", textBox3.Text);
            SqlDataAdapter sql_ada = new SqlDataAdapter();
            DataTable dt = new DataTable();

           
           
           

            sql_ada.SelectCommand = sql_command;
            sql_ada.Fill(dt);

            dataGridView1.DataSource = dt;

            sql_command.ExecuteNonQuery();


            sql_connect.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            KategoriEkranı kategoriEkranı = new KategoriEkranı();
            kategoriEkranı.Show();
            this.Close();
        }
    }
}
