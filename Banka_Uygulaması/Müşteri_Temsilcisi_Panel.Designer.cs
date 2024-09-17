namespace Banka_Uygulaması
{
    partial class Müşteri_Temsilcisi_Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Müşteri_Temsilcisi_Panel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblşifre = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtiban = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtmüşterişifre = new System.Windows.Forms.TextBox();
            this.txtcinsiyet = new System.Windows.Forms.TextBox();
            this.txtbakiye = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btngetir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            this.lblbakiye = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbleklendi = new System.Windows.Forms.Label();
            this.lblgüncelleme = new System.Windows.Forms.Label();
            this.lblSilme = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(449, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 615);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(515, 586);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.lblşifre);
            this.groupBox2.Controls.Add(this.lbltc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 118);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sekreter Bilgileri";
            // 
            // lblşifre
            // 
            this.lblşifre.AutoSize = true;
            this.lblşifre.Location = new System.Drawing.Point(80, 68);
            this.lblşifre.Name = "lblşifre";
            this.lblşifre.Size = new System.Drawing.Size(133, 25);
            this.lblşifre.TabIndex = 8;
            this.lblşifre.Text = "00000000000";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(80, 26);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(133, 25);
            this.lbltc.TabIndex = 7;
            this.lbltc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tc No:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Teal;
            this.groupBox3.Controls.Add(this.txtsoyad);
            this.groupBox3.Controls.Add(this.txtad);
            this.groupBox3.Controls.Add(this.txtiban);
            this.groupBox3.Controls.Add(this.txttc);
            this.groupBox3.Controls.Add(this.txtmüşterişifre);
            this.groupBox3.Controls.Add(this.txtcinsiyet);
            this.groupBox3.Controls.Add(this.txtbakiye);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btngetir);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.btnlistele);
            this.groupBox3.Controls.Add(this.btngüncelle);
            this.groupBox3.Controls.Add(this.btnsil);
            this.groupBox3.Controls.Add(this.btnekle);
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 517);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri Değerleri";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(176, 119);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(249, 30);
            this.txtsoyad.TabIndex = 23;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(144, 76);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(281, 30);
            this.txtad.TabIndex = 22;
            // 
            // txtiban
            // 
            this.txtiban.Location = new System.Drawing.Point(85, 29);
            this.txtiban.MaxLength = 24;
            this.txtiban.Name = "txtiban";
            this.txtiban.Size = new System.Drawing.Size(340, 30);
            this.txtiban.TabIndex = 21;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(141, 169);
            this.txttc.MaxLength = 11;
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(284, 30);
            this.txttc.TabIndex = 20;
            // 
            // txtmüşterişifre
            // 
            this.txtmüşterişifre.Location = new System.Drawing.Point(159, 213);
            this.txtmüşterişifre.Name = "txtmüşterişifre";
            this.txtmüşterişifre.Size = new System.Drawing.Size(266, 30);
            this.txtmüşterişifre.TabIndex = 19;
            // 
            // txtcinsiyet
            // 
            this.txtcinsiyet.Location = new System.Drawing.Point(188, 265);
            this.txtcinsiyet.Name = "txtcinsiyet";
            this.txtcinsiyet.Size = new System.Drawing.Size(237, 30);
            this.txtcinsiyet.TabIndex = 18;
            // 
            // txtbakiye
            // 
            this.txtbakiye.Location = new System.Drawing.Point(99, 312);
            this.txtbakiye.Name = "txtbakiye";
            this.txtbakiye.Size = new System.Drawing.Size(326, 30);
            this.txtbakiye.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Bakiye:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Müşteri Soyad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Müşteri Ad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Müşteri Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Müşteri Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Müşteri Tc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "İban:";
            // 
            // btngetir
            // 
            this.btngetir.BackColor = System.Drawing.Color.Teal;
            this.btngetir.Location = new System.Drawing.Point(257, 368);
            this.btngetir.Name = "btngetir";
            this.btngetir.Size = new System.Drawing.Size(168, 41);
            this.btngetir.TabIndex = 10;
            this.btngetir.Text = "Getir";
            this.btngetir.UseVisualStyleBackColor = false;
            this.btngetir.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID No:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(127, 373);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 30);
            this.txtid.TabIndex = 4;
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.CadetBlue;
            this.btnlistele.Location = new System.Drawing.Point(257, 467);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(168, 41);
            this.btnlistele.TabIndex = 3;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.button5_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btngüncelle.Location = new System.Drawing.Point(59, 467);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(168, 41);
            this.btngüncelle.TabIndex = 2;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsil.Location = new System.Drawing.Point(257, 420);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(168, 41);
            this.btnsil.TabIndex = 1;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Teal;
            this.btnekle.Location = new System.Drawing.Point(59, 420);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(168, 41);
            this.btnekle.TabIndex = 0;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(173, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.Red;
            this.btngeri.Location = new System.Drawing.Point(0, 3);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(89, 35);
            this.btngeri.TabIndex = 4;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // lblbakiye
            // 
            this.lblbakiye.AutoSize = true;
            this.lblbakiye.Location = new System.Drawing.Point(481, 42);
            this.lblbakiye.Name = "lblbakiye";
            this.lblbakiye.Size = new System.Drawing.Size(75, 25);
            this.lblbakiye.TabIndex = 1;
            this.lblbakiye.Text = "label13";
            this.lblbakiye.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(255, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbleklendi
            // 
            this.lbleklendi.AutoSize = true;
            this.lbleklendi.Location = new System.Drawing.Point(726, 3);
            this.lbleklendi.Name = "lbleklendi";
            this.lbleklendi.Size = new System.Drawing.Size(230, 25);
            this.lbleklendi.TabIndex = 8;
            this.lbleklendi.Text = "value added successfully";
            this.lbleklendi.Visible = false;
            // 
            // lblgüncelleme
            // 
            this.lblgüncelleme.AutoSize = true;
            this.lblgüncelleme.Location = new System.Drawing.Point(586, 42);
            this.lblgüncelleme.Name = "lblgüncelleme";
            this.lblgüncelleme.Size = new System.Drawing.Size(246, 25);
            this.lblgüncelleme.TabIndex = 9;
            this.lblgüncelleme.Text = "value updated successfully";
            this.lblgüncelleme.Visible = false;
            // 
            // lblSilme
            // 
            this.lblSilme.AutoSize = true;
            this.lblSilme.Location = new System.Drawing.Point(481, 3);
            this.lblSilme.Name = "lblSilme";
            this.lblSilme.Size = new System.Drawing.Size(239, 25);
            this.lblSilme.TabIndex = 10;
            this.lblSilme.Text = "value deleted successfully";
            this.lblSilme.Visible = false;
            // 
            // Müşteri_Temsilcisi_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(982, 689);
            this.Controls.Add(this.lblSilme);
            this.Controls.Add(this.lblgüncelleme);
            this.Controls.Add(this.lbleklendi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblbakiye);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Müşteri_Temsilcisi_Panel";
            this.Text = "Müşteri_Temsilcisi_Panel";
            this.Load += new System.EventHandler(this.Müşteri_Temsilcisi_Panel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label lblşifre;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngetir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtiban;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtmüşterişifre;
        private System.Windows.Forms.TextBox txtcinsiyet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label lblbakiye;
        private System.Windows.Forms.TextBox txtbakiye;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbleklendi;
        private System.Windows.Forms.Label lblgüncelleme;
        private System.Windows.Forms.Label lblSilme;
    }
}