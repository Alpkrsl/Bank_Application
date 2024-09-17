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
    public partial class Kullanıcı_Ana_Sayfa : Form
    {
        //Bağlantı sınıfı
        Bağlantı_Sınıfı bağlanti = new Bağlantı_Sınıfı();
        public Kullanıcı_Ana_Sayfa()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kullanıcı_Hesap_Geçmişi kullanıcı_Hesap_Geçmişi = new Kullanıcı_Hesap_Geçmişi();
            kullanıcı_Hesap_Geçmişi.tcc = lbltc.Text;
            kullanıcı_Hesap_Geçmişi.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanıcı_Iban_Para_Gönderme _Para_Gönderme = new Kullanıcı_Iban_Para_Gönderme();
            _Para_Gönderme.tc = lbltc.Text;
            _Para_Gönderme.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kullanıcı_Giriş kullanıcı_Giriş = new Kullanıcı_Giriş();
            kullanıcı_Giriş.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Enabled = true;
            dataGridView1.ReadOnly= true;


        }
        public string tc;

        public object DataGridviewmetot { get; private set; }

        private void Kullanıcı_Ana_Sayfa_Load(object sender, EventArgs e)
        {
            veriYükle();
            IbanListeleme();
            MüşteriBakiye();
            DataGridviewMetot();
        }

        private void DataGridviewMetot()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //VeriYükleme
        private void veriYükle()
        {
            lbltc.Text = tc;
        }

        //Müşteri İban
        private void IbanListeleme()
        {
            SqlCommand cmd = new SqlCommand("SELECT Iban FROM Müşteri_VIEW WHERE MüşteriTc=@P2", bağlanti.baglanti());
            try
            {
                cmd.Parameters.AddWithValue("@P2", lbltc.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { bağlanti.baglanti().Close(); }
        }
        //Müşteri Bakiye
        private void MüşteriBakiye()
        {
            SqlCommand cmd = new SqlCommand("SELECT Bakiye FROM Müşteri_VIEW WHERE MüşteriTc=@P2", bağlanti.baglanti());
            try
            {
                cmd.Parameters.AddWithValue("@P2", lbltc.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { bağlanti.baglanti().Close(); }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Enabled = true;
            dataGridView2.ReadOnly = true;


        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_Enter(object sender, EventArgs e)
        {


        }

        private void btnhesapsil_Click(object sender, EventArgs e)
        {
            try
            {
              DialogResult result=  MessageBox.Show("Hesabınız Silinecektir Bunu Kabul Ediyormusunuz","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                if (result==DialogResult.Yes) {
                    SqlCommand sqlCommand = new SqlCommand("Kişi_Silme", bağlanti.baglanti());
                    sqlCommand.CommandType= CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@P1",lbltc.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Hesabınız Silindi","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Kullanıcı_Giriş kullanıcı_Giriş = new Kullanıcı_Giriş();
                    kullanıcı_Giriş.Show();
                    this.Close();
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally { bağlanti.baglanti().Close(); }
        }
    }
}
