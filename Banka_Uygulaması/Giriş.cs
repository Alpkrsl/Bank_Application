using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Uygulaması
{
    public partial class Giriş : Form
    {

        Bağlantı_Sınıfı bağ = new Bağlantı_Sınıfı();
        public Giriş()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Müşteri_Temsilcisi_Giriş gir = new Müşteri_Temsilcisi_Giriş();
            gir.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanıcı_Giriş girr = new Kullanıcı_Giriş();
            girr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
