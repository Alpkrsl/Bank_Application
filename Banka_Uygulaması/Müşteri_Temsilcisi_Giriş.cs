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

namespace Banka_Uygulaması
{
    public partial class Müşteri_Temsilcisi_Giriş : Form
    {
        //Bağlantı sınıfı
        Bağlantı_Sınıfı bağlanti = new Bağlantı_Sınıfı();
        public Müşteri_Temsilcisi_Giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giriş gir = new Giriş();
            gir.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Şİfre_Unutma unut = new Şİfre_Unutma();
            unut.müşteriTdeğiş = label5.Text;
            unut.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text.Length ==11 &&
                    !string.IsNullOrEmpty(textBox2.Text))
                {
                    SqlCommand sqlCommand = new SqlCommand("MüşteriT_Giriş", bağlanti.baglanti());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@P1",textBox1.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", textBox2.Text);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        Müşteri_Temsilcisi_Panel müşteri_Temsilcisi_Panel = new Müşteri_Temsilcisi_Panel();
                        müşteri_Temsilcisi_Panel.tc = textBox1.Text;
                        müşteri_Temsilcisi_Panel.şifre= textBox2.Text;
                        müşteri_Temsilcisi_Panel.Show();
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { bağlanti.baglanti().Close(); }
        }

        private void Müşteri_Temsilcisi_Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}
