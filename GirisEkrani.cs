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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void basvurubtn_Click(object sender, EventArgs e)
        {
            BasvuruGirisEkrani basvuruGirisEkrani = new BasvuruGirisEkrani();
            basvuruGirisEkrani.Show();

        }

        private void yöneticibtn_Click(object sender, EventArgs e)
        {
            YöneticiGirisEkrani yöneticiGirisEkrani = new YöneticiGirisEkrani();
            yöneticiGirisEkrani.Show();
        }

        private void üyebtn_Click(object sender, EventArgs e)
        {
            ÜyeEkrani üyeEkrani = new ÜyeEkrani();
            üyeEkrani.Show();
        }
    }
}
