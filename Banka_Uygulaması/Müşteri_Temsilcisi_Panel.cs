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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SpeechLib;
namespace Banka_Uygulaması
{

    public partial class Müşteri_Temsilcisi_Panel : Form
    {
        //Bağlantı sınıfı
        Bağlantı_Sınıfı bağlanti = new Bağlantı_Sınıfı();
        public Müşteri_Temsilcisi_Panel()
        {
            InitializeComponent();
        }
        public string tc, şifre;
        private void Müşteri_Temsilcisi_Panel_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            lblşifre.Text = şifre;
            Listeleme();

        }
        private void TanımlamaMetot()
        {
            }

        private void Listeleme()
        {
            SqlCommand cmd = new SqlCommand("SELECT*FROM Müşteri_VIEW ", bağlanti.baglanti());
            try
            {
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

        private void btngeri_Click(object sender, EventArgs e)
        {
            Müşteri_Temsilcisi_Giriş müşteri_Temsilcisi_Giriş = new Müşteri_Temsilcisi_Giriş();
            müşteri_Temsilcisi_Giriş.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Listeleme();
            DataGridViewMetot();
        }

        private void DataGridViewMetot()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtiban.Text) && txtiban.Text.Length == 24 &&
                        !string.IsNullOrEmpty(txtad.Text) && 
                        !string.IsNullOrEmpty(txtsoyad.Text) &&  
                    !string.IsNullOrEmpty(txtcinsiyet.Text) && txtcinsiyet.Text.Length==5 &&
                    !string.IsNullOrEmpty(txttc.Text) && !string.IsNullOrEmpty(txtbakiye.Text) && txttc.Text.Length == 11 && !string.IsNullOrEmpty(txtmüşterişifre.Text))
                {
                    SqlCommand sqlCommand = new SqlCommand("Müşteri_Ekleme",bağlanti.baglanti());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    decimal miktar = Convert.ToDecimal(txtbakiye.Text);
                    sqlCommand.Parameters.AddWithValue("@P1",miktar);
                    sqlCommand.Parameters.AddWithValue("@P2", txtiban.Text);
                    sqlCommand.Parameters.AddWithValue("@P3", txtad.Text);
                    sqlCommand.Parameters.AddWithValue("@P4", txtsoyad.Text);
                    sqlCommand.Parameters.AddWithValue("@P5", txttc.Text);
                    sqlCommand.Parameters.AddWithValue("@P6", txtmüşterişifre.Text);
                    sqlCommand.Parameters.AddWithValue("@P7", txtcinsiyet.Text);
                    sqlCommand.ExecuteNonQuery();
                  DialogResult Result = MessageBox.Show("Değer Eklendi", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Result == DialogResult.OK)
                    {
                        SpVoice sp = new SpVoice();
                        sp.Speak(lbleklendi.Text);
                    }
                        
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally { bağlanti.baglanti().Close(); Listeleme(); }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txttc.Text) && txttc.Text.Length == 11)
                {
                    SqlCommand sqlCommand = new SqlCommand("Kişi_Silme", bağlanti.baglanti());
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@P1", txttc.Text);
                    sqlCommand.ExecuteNonQuery();
                    DialogResult RResult = MessageBox.Show("Değer Silindi", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (RResult == DialogResult.OK)
                    {
                        SpVoice sp = new SpVoice();
                        sp.Speak(lblSilme.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { bağlanti.baglanti().Close(); Listeleme(); }
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                    if (!string.IsNullOrEmpty(txtiban.Text) && txtiban.Text.Length == 24 &&
                            !string.IsNullOrEmpty(txtad.Text) &&
                            !string.IsNullOrEmpty(txtsoyad.Text) &&
                        !string.IsNullOrEmpty(txtcinsiyet.Text) && txtcinsiyet.Text.Length == 5 &&
                        !string.IsNullOrEmpty(txttc.Text) && txttc.Text.Length == 11 && !string.IsNullOrEmpty(txtbakiye.Text) && !string.IsNullOrEmpty(txtmüşterişifre.Text) && !string.IsNullOrEmpty(txtid.Text))
                    {
                    decimal miktar = Convert.ToDecimal(txtbakiye.Text);
                        SqlCommand sqlCommand = new SqlCommand("Kişi_Güncelle", bağlanti.baglanti());
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@P1", miktar);
                        sqlCommand.Parameters.AddWithValue("@P2", txtiban.Text);
                        sqlCommand.Parameters.AddWithValue("@P3", txtad.Text);
                        sqlCommand.Parameters.AddWithValue("@P4", txtsoyad.Text);
                        sqlCommand.Parameters.AddWithValue("@P5", txttc.Text);
                        sqlCommand.Parameters.AddWithValue("@P6", txtmüşterişifre.Text);
                        sqlCommand.Parameters.AddWithValue("@P7", txtcinsiyet.Text);
                        sqlCommand.Parameters.AddWithValue("@P8", txtid.Text);
                        sqlCommand.ExecuteNonQuery();
                    DialogResult result = MessageBox.Show("Değer Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        SpVoice sp = new SpVoice();
                        sp.Speak(lblgüncelleme.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { bağlanti.baglanti().Close(); Listeleme(); }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtiban.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();     
            txtbakiye.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtcinsiyet.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtmüşterişifre.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txttc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void btnaç_Click(object sender, EventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT*FROM Müşteri_VIEW WHERE MüşteriID=@P1", bağlanti.baglanti());
            try
            {
                cmd.Parameters.AddWithValue("@P1",txtid.Text);
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
    }

    //private void button2_Click(object sender, EventArgs e)
    //{

    //}
}

