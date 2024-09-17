using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Banka_Uygulaması
{

    // Bağlantıyı aç

    // Bağlantıyı kullanarak veri sorgulama veya diğer işlemler yapabilirsiniz

    public partial class Kullanıcı_Iban_Para_Gönderme : Form
    {

        //Bağlantı sınıfı
        Bağlantı_Sınıfı bağlanti = new Bağlantı_Sınıfı();

        public Kullanıcı_Iban_Para_Gönderme()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
        public string tc;
        //İban Yollama Load
        private void Kullanıcı_Iban_Para_Gönderme_Load(object sender, EventArgs e)
        {
            label6.Text = tc;
            label5.Text = label6.Text;
            KişilerListeleme();
            TanımlıAlıcıListeleme();
            IbanListeleme();
            MüşteriBakiye();
            DataGridviewMetot();
            //VeriGöster();
        }

       //public void VeriGöster()
       // {
       //     int miktar = decimal.Parse(txtgönderilecekmiktar.Text);
       //     int bakiye = int.Parse(lblbakiye.Text);
       // }

        //Müşteri Bakiye
        private void MüşteriBakiye()
        {
            SqlCommand cmd = new SqlCommand("SELECT Bakiye FROM Müşteri_VIEW WHERE MüşteriTc=@P2", bağlanti.baglanti());
            try
            {
                cmd.Parameters.AddWithValue("@P2", label5.Text);
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

        //Müşteri İban
        private void IbanListeleme()
        {
            SqlCommand cmd = new SqlCommand("SELECT Iban FROM Müşteri_VIEW WHERE MüşteriTc=@P2", bağlanti.baglanti());
            try
            {
                cmd.Parameters.AddWithValue("@P2", label6.Text);
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

        //Kişiler Listeleme
        private void KişilerListeleme()
        {
            SqlCommand cmd = new SqlCommand("SELECT Iban,MüşteriAd,MüşteriSoyad FROM Müşteri_VIEW ", bağlanti.baglanti());
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
                dataGridView4.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { bağlanti.baglanti().Close(); }
        }

        //Tanımlı Alıcı Listeleme
        private void TanımlıAlıcıListeleme()
        {
            SqlCommand cmd = new SqlCommand("SELECT Iban,MüşteriAd,MüşteriSoyad FROM Müşteri_Yedek_VIEW WHERE MüşteriTc=@P2", bağlanti.baglanti());
            try
            {
                cmd.Parameters.AddWithValue("@P2", label5.Text);
                DataTable dt=new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
                dataGridView3.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { bağlanti.baglanti().Close(); }
        }

        //Tanımlı Alıcı Ekleme
        private void TanımlıAlıcıEkleme()
        {
            SqlCommand sqlCommand = new SqlCommand("Müşteri_Yedek_Prosedürü", bağlanti.baglanti());
            sqlCommand.CommandType=CommandType.StoredProcedure;
            try
            {
                sqlCommand.Parameters.AddWithValue("@P1",txtKişiiban.Text);
                sqlCommand.Parameters.AddWithValue("@P2", txtkişiad.Text);
                sqlCommand.Parameters.AddWithValue("@P3", txtKişisoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P4", label5.Text);
                sqlCommand.BeginExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                bağlanti.baglanti().Close();
                TanımlıAlıcıListeleme();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                if (!string.IsNullOrEmpty(txtKişiiban.Text) &&
        !string.IsNullOrEmpty(txtkişiad.Text) &&
        !string.IsNullOrEmpty(txtKişisoyad.Text))
                {
                    TanımlıAlıcıEkleme();
                }

            }
        catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Kullanıcı_Ana_Sayfa kullanıcı_Ana_Sayfa = new Kullanıcı_Ana_Sayfa();
            kullanıcı_Ana_Sayfa.tc = label6.Text;
            kullanıcı_Ana_Sayfa.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void DataGridviewMetot()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Enabled = true;
            dataGridView1.ReadOnly = true;
            dataGridView2.Enabled = true;
            dataGridView2.ReadOnly = true;
            dataGridView3.Enabled = true;
            //dataGridView3.ReadOnly = true;
            dataGridView4.Enabled = true;
            //dataGridView4.ReadOnly = true;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lbliban.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            int secilenn = dataGridView2.SelectedCells[0].RowIndex;
            lblbakiye.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(txtKişiiban.Text) && txtKişiiban.Text !=lbliban.Text &&
                    !string.IsNullOrEmpty(txtkişiad.Text) &&
                    !string.IsNullOrEmpty(txtKişisoyad.Text) &&
                    !string.IsNullOrEmpty(txtgönderilecekmiktar.Text))
                {
                  
                        SqlCommand cmd = new SqlCommand("Para_Göndermee", bağlanti.baglanti());
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@P1", txtgönderilecekmiktar.Text);
                        cmd.Parameters.AddWithValue("@P2", lbliban.Text);
                        cmd.Parameters.AddWithValue("@P3", txtKişiiban.Text);
                     cmd.Parameters.AddWithValue("@P4",txtkişiad.Text);
                     cmd.Parameters.AddWithValue("@P5",txtKişisoyad.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla Gönderildi");
                    
                }
                else
                {
                    MessageBox.Show("Bütün değerleri giriniz yada iban seçilemez");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { bağlanti.baglanti().Close(); }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                int secilen = dataGridView4.SelectedCells[0].RowIndex;
                txtkişiad.Text = dataGridView4.Rows[secilen].Cells[1].Value.ToString();
                txtKişisoyad.Text = dataGridView4.Rows[secilen].Cells[2].Value.ToString();
                txtKişiiban.Text = dataGridView4.Rows[secilen].Cells[0].Value.ToString();
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                int secilen = dataGridView3.SelectedCells[0].RowIndex;
                txtkişiad.Text = dataGridView3.Rows[secilen].Cells[1].Value.ToString();
                txtKişisoyad.Text = dataGridView3.Rows[secilen].Cells[2].Value.ToString();
                txtKişiiban.Text = dataGridView3.Rows[secilen].Cells[0].Value.ToString();          
        }
    }
}
