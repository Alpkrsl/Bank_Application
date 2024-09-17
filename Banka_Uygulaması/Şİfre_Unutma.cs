using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Uygulaması
{
    public partial class Şİfre_Unutma : Form
    {
        //Bağlantı sınıfı
        Bağlantı_Sınıfı bağlanti = new Bağlantı_Sınıfı();
        public Şİfre_Unutma()
        {
            InitializeComponent();
        }
        public string kullanıcıdeğiş, müşteriTdeğiş;

        private void Şİfre_Unutma_Load(object sender, EventArgs e)
        {
            VeriYükle();
        }

        private void VeriYükle()
        {
            Kullanıcı_Geçiş.Text = kullanıcıdeğiş;
            MüşteriTemsilcisiGeçiş.Text = müşteriTdeğiş;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) &&  textBox1.Text.Length==11  &&
                    !string.IsNullOrEmpty(textBox2.Text))
                {
                    SqlCommand sqlCommand = new SqlCommand("Sifre_Düzenleme", bağlanti.baglanti());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@P1", textBox1.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", textBox2.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Değer Başarıyla Eklendi", "Düzenleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { bağlanti.baglanti().Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MüşteriTemsilcisiGeçiş.Text == "değişş")
            {
                Müşteri_Temsilcisi_Giriş girişş = new Müşteri_Temsilcisi_Giriş();
                girişş.Show();
                this.Hide();
            }
            if (Kullanıcı_Geçiş.Text=="Değiş")
            {
                Kullanıcı_Giriş giriş = new Kullanıcı_Giriş();
                giriş.Show();
                this.Hide();
            }
        }
    }
}
