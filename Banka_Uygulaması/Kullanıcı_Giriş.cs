using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Uygulaması
{
    public partial class Kullanıcı_Giriş : Form
    {
        //Bağlantı sınıfı
        //Bağlantı_Sınıfı bağlanti = new Bağlantı_Sınıfı();
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-HMITB4AP;Initial Catalog=Banka_Uygulaması;Integrated Security=True;");
        public Kullanıcı_Giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giriş gir = new Giriş();
            gir.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Şİfre_Unutma unut = new Şİfre_Unutma();
            unut.kullanıcıdeğiş = label6.Text;
            unut.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtşifre.UseSystemPasswordChar == true)
            {
                txtşifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtşifre.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {

                SqlCommand sqlCommand = new SqlCommand("Müşteri_Giriş", baglanti);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (!string.IsNullOrEmpty(txttc.Text)
                    && !string.IsNullOrEmpty(txtşifre.Text)) {                    
                    sqlCommand.Parameters.AddWithValue("@P1", txttc.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", txtşifre.Text);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.Read()){
                        Kullanıcı_Ana_Sayfa ana_Sayfa = new Kullanıcı_Ana_Sayfa();
                        ana_Sayfa.tc = txttc.Text;
                        ana_Sayfa.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void Kullanıcı_Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}
