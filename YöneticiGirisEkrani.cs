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
    public partial class YöneticiGirisEkrani : Form
    {
        public YöneticiGirisEkrani()
        {
            InitializeComponent();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            KategoriEkranı kategoriEkranı = new KategoriEkranı();
            kategoriEkranı.Show();
            this.Close();
        }
    }
}
