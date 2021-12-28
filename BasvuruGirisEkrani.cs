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
    public partial class BasvuruGirisEkrani : Form
    {
        public BasvuruGirisEkrani()
        {
            InitializeComponent();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            BasvuruBilgileri basvuruBilgileri = new BasvuruBilgileri();
            basvuruBilgileri.Show();
            this.Close();
            
        }
    }
}
