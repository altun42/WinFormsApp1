using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql_connect = new SqlConnection();
            SqlCommand sql_command = new SqlCommand();
            string connetionString = @"server=(localdb)\MSSQLLocalDB;Trusted_Connection=yes;database=PersonelÝnformation;";

            SqlDataAdapter sql_ada = new SqlDataAdapter();
            DataTable dt = new DataTable();

            sql_connect.ConnectionString = connetionString;
            sql_command.Connection = sql_connect;
            sql_command.CommandText = "SELECT * FROM personeller";

            sql_ada.SelectCommand = sql_command;
            sql_ada.Fill(dt);

            dataGridView1.DataSource = dt;
            Form2 form = new Form2();
            

            //t/*his.dataGridView1.DataMember = "personeller";*/

            //and better put this line before `con.Close();

            //this.dataGridView1.DataSource = dset;
            //this.dataGridView1.DataMember = "tabela";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adayBilgileribtn_Click(object sender, EventArgs e)
        {
            KategoriEkraný kategoriEkraný = new KategoriEkraný();
            kategoriEkraný.Show();
            this.Close();
        }
    }
}