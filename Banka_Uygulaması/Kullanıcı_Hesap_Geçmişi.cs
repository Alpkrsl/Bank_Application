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
    public partial class Kullanıcı_Hesap_Geçmişi : Form
    {
        //Bağlantı sınıfı
        Bağlantı_Sınıfı bağlanti = new Bağlantı_Sınıfı();
        public Kullanıcı_Hesap_Geçmişi()
        {
            InitializeComponent();
        }
        public string tcc;
        private void Kullanıcı_Hesap_Geçmişi_Load(object sender, EventArgs e)
        {
            label1.Text = tcc;
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanıcı_Ana_Sayfa kullanıcı_Ana_Sayfa = new Kullanıcı_Ana_Sayfa();
            kullanıcı_Ana_Sayfa.tc = label1.Text;
            kullanıcı_Ana_Sayfa.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT*FROM Para_Gönderme_Kayıt_Vıew", bağlanti.baglanti());
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
             MessageBox.Show(ex.Message);
            }
            finally { bağlanti.baglanti().Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT*FROM Para_Gönderme_Kayıt_Vıew WHERE ID=@P1", bağlanti.baglanti());
                sqlCommand.Parameters.AddWithValue("@P1",textBox1.Text);
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { bağlanti.baglanti().Close(); }
        }
    }
}
