using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ÜyeEkrani : Form
    {
        public ÜyeEkrani()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıdınız Başarılı Bir Şekilde Oluşturuldu","Sistem Mesajı", MessageBoxButtons.OK);
            
            this.Close();
        }
    }
}
