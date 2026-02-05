namespace EfeKutuphane
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtKitapAd = new TextBox();
            Kitap = new TabControl();
            tabKitap = new TabPage();
            txtArama = new TextBox();
            lblAra = new Label();
            txtKitap = new TextBox();
            btnGuncelle = new Button();
            cmbKategori = new ComboBox();
            btnSil = new Button();
            btnKitapEkle = new Button();
            txtYazar = new TextBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            tabOdunc = new TabPage();
            label5 = new Label();
            label4 = new Label();
            btnIadeEt = new Button();
            dgvAktifOduncler = new DataGridView();
            btnOduncVer = new Button();
            cmbKitapSec = new ComboBox();
            cmbUyeSec = new ComboBox();
            pictureBox2 = new PictureBox();
            tabKayit = new TabPage();
            btnUyeSil = new Button();
            dgvUyeler = new DataGridView();
            btnUyeEkle = new Button();
            txtUyeTel = new TextBox();
            txtUyeSoyad = new TextBox();
            txtUyeAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            tabAyarlar = new TabPage();
            btnTalepReddet = new Button();
            btnTalepleriGetir = new Button();
            btnAylikRapor = new Button();
            btnKategoriRapor = new Button();
            btnEnCokOkuyanlar = new Button();
            btnTalepOnayla = new Button();
            dgvRaporlar = new DataGridView();
            btnGecikenKitaplar = new Button();
            btnEnCokOkunanlar = new Button();
            pictureBox4 = new PictureBox();
            Kitap.SuspendLayout();
            tabKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabOdunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAktifOduncler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabAyarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRaporlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txtKitapAd
            // 
            txtKitapAd.Location = new Point(550, 20);
            txtKitapAd.Name = "txtKitapAd";
            txtKitapAd.Size = new Size(125, 27);
            txtKitapAd.TabIndex = 2;
            // 
            // Kitap
            // 
            Kitap.Controls.Add(tabKitap);
            Kitap.Controls.Add(tabOdunc);
            Kitap.Controls.Add(tabKayit);
            Kitap.Controls.Add(tabAyarlar);
            Kitap.Dock = DockStyle.Top;
            Kitap.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            Kitap.Location = new Point(0, 0);
            Kitap.Name = "Kitap";
            Kitap.SelectedIndex = 0;
            Kitap.Size = new Size(818, 456);
            Kitap.TabIndex = 6;
            // 
            // tabKitap
            // 
            tabKitap.BackColor = Color.Transparent;
            tabKitap.BackgroundImage = (Image)resources.GetObject("tabKitap.BackgroundImage");
            tabKitap.BackgroundImageLayout = ImageLayout.Stretch;
            tabKitap.Controls.Add(txtArama);
            tabKitap.Controls.Add(lblAra);
            tabKitap.Controls.Add(txtKitap);
            tabKitap.Controls.Add(btnGuncelle);
            tabKitap.Controls.Add(cmbKategori);
            tabKitap.Controls.Add(btnSil);
            tabKitap.Controls.Add(btnKitapEkle);
            tabKitap.Controls.Add(txtYazar);
            tabKitap.Controls.Add(dataGridView1);
            tabKitap.Controls.Add(pictureBox1);
            tabKitap.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tabKitap.Location = new Point(4, 29);
            tabKitap.Name = "tabKitap";
            tabKitap.Padding = new Padding(3);
            tabKitap.Size = new Size(810, 423);
            tabKitap.TabIndex = 0;
            tabKitap.Text = "Kitap İşlemleri";
            // 
            // txtArama
            // 
            txtArama.BorderStyle = BorderStyle.None;
            txtArama.Location = new Point(76, 45);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(136, 25);
            txtArama.TabIndex = 14;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // lblAra
            // 
            lblAra.AutoSize = true;
            lblAra.BackColor = Color.Beige;
            lblAra.Location = new Point(29, 51);
            lblAra.Name = "lblAra";
            lblAra.Size = new Size(41, 19);
            lblAra.TabIndex = 13;
            lblAra.Text = "Ara:";
            // 
            // txtKitap
            // 
            txtKitap.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            txtKitap.Location = new Point(509, 188);
            txtKitap.MinimumSize = new Size(0, 30);
            txtKitap.Name = "txtKitap";
            txtKitap.Size = new Size(151, 30);
            txtKitap.TabIndex = 12;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Sienna;
            btnGuncelle.FlatStyle = FlatStyle.Popup;
            btnGuncelle.Location = new Point(682, 265);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(102, 29);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(509, 110);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(151, 33);
            cmbKategori.TabIndex = 10;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.Location = new Point(682, 180);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(102, 43);
            btnSil.TabIndex = 9;
            btnSil.Text = "Kitap Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.BackColor = Color.Lime;
            btnKitapEkle.FlatStyle = FlatStyle.Popup;
            btnKitapEkle.Location = new Point(682, 101);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(102, 43);
            btnKitapEkle.TabIndex = 8;
            btnKitapEkle.Text = "Kitap Ekle";
            btnKitapEkle.UseVisualStyleBackColor = false;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // txtYazar
            // 
            txtYazar.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            txtYazar.Location = new Point(509, 264);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(151, 30);
            txtYazar.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.Beige;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.HighlightText;
            dataGridView1.Location = new Point(29, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(474, 284);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(645, 264);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 198);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // tabOdunc
            // 
            tabOdunc.BackgroundImage = (Image)resources.GetObject("tabOdunc.BackgroundImage");
            tabOdunc.BackgroundImageLayout = ImageLayout.Stretch;
            tabOdunc.Controls.Add(label5);
            tabOdunc.Controls.Add(label4);
            tabOdunc.Controls.Add(btnIadeEt);
            tabOdunc.Controls.Add(dgvAktifOduncler);
            tabOdunc.Controls.Add(btnOduncVer);
            tabOdunc.Controls.Add(cmbKitapSec);
            tabOdunc.Controls.Add(cmbUyeSec);
            tabOdunc.Controls.Add(pictureBox2);
            tabOdunc.Location = new Point(4, 29);
            tabOdunc.Name = "tabOdunc";
            tabOdunc.Padding = new Padding(3);
            tabOdunc.Size = new Size(810, 423);
            tabOdunc.TabIndex = 1;
            tabOdunc.Text = "Ödünç İşlemleri";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkGoldenrod;
            label5.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(76, 48);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 7;
            label5.Text = "Kitap Seç";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGoldenrod;
            label4.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(555, 49);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 6;
            label4.Text = "Üye Seç";
            // 
            // btnIadeEt
            // 
            btnIadeEt.BackColor = Color.DarkGreen;
            btnIadeEt.FlatStyle = FlatStyle.Popup;
            btnIadeEt.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnIadeEt.ForeColor = Color.PaleGoldenrod;
            btnIadeEt.Location = new Point(347, 92);
            btnIadeEt.Name = "btnIadeEt";
            btnIadeEt.Size = new Size(123, 43);
            btnIadeEt.TabIndex = 4;
            btnIadeEt.Text = "İade Al";
            btnIadeEt.UseVisualStyleBackColor = false;
            btnIadeEt.Click += btnIadeEt_Click;
            // 
            // dgvAktifOduncler
            // 
            dgvAktifOduncler.AllowUserToAddRows = false;
            dgvAktifOduncler.BackgroundColor = Color.DarkGreen;
            dgvAktifOduncler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAktifOduncler.Location = new Point(201, 167);
            dgvAktifOduncler.Name = "dgvAktifOduncler";
            dgvAktifOduncler.RowHeadersVisible = false;
            dgvAktifOduncler.RowHeadersWidth = 51;
            dgvAktifOduncler.Size = new Size(425, 188);
            dgvAktifOduncler.TabIndex = 3;
            // 
            // btnOduncVer
            // 
            btnOduncVer.BackColor = Color.DarkGoldenrod;
            btnOduncVer.FlatStyle = FlatStyle.Popup;
            btnOduncVer.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnOduncVer.Location = new Point(347, 22);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(123, 44);
            btnOduncVer.TabIndex = 2;
            btnOduncVer.Text = "Ödünç Ver";
            btnOduncVer.UseVisualStyleBackColor = false;
            btnOduncVer.Click += btnOduncVer_Click;
            // 
            // cmbKitapSec
            // 
            cmbKitapSec.FormattingEnabled = true;
            cmbKitapSec.Location = new Point(76, 72);
            cmbKitapSec.Name = "cmbKitapSec";
            cmbKitapSec.Size = new Size(191, 28);
            cmbKitapSec.TabIndex = 1;
            // 
            // cmbUyeSec
            // 
            cmbUyeSec.FormattingEnabled = true;
            cmbUyeSec.Location = new Point(555, 73);
            cmbUyeSec.Name = "cmbUyeSec";
            cmbUyeSec.Size = new Size(190, 28);
            cmbUyeSec.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-47, 267);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(205, 198);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // tabKayit
            // 
            tabKayit.BackColor = Color.Transparent;
            tabKayit.BackgroundImage = (Image)resources.GetObject("tabKayit.BackgroundImage");
            tabKayit.BackgroundImageLayout = ImageLayout.Stretch;
            tabKayit.Controls.Add(btnUyeSil);
            tabKayit.Controls.Add(dgvUyeler);
            tabKayit.Controls.Add(btnUyeEkle);
            tabKayit.Controls.Add(txtUyeTel);
            tabKayit.Controls.Add(txtUyeSoyad);
            tabKayit.Controls.Add(txtUyeAd);
            tabKayit.Controls.Add(label3);
            tabKayit.Controls.Add(label2);
            tabKayit.Controls.Add(label1);
            tabKayit.Controls.Add(pictureBox3);
            tabKayit.Location = new Point(4, 29);
            tabKayit.Name = "tabKayit";
            tabKayit.Padding = new Padding(3);
            tabKayit.Size = new Size(810, 423);
            tabKayit.TabIndex = 2;
            tabKayit.Text = "Kayıt ";
            // 
            // btnUyeSil
            // 
            btnUyeSil.BackColor = Color.Black;
            btnUyeSil.FlatStyle = FlatStyle.Flat;
            btnUyeSil.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUyeSil.ForeColor = Color.LightGoldenrodYellow;
            btnUyeSil.Location = new Point(519, 256);
            btnUyeSil.Name = "btnUyeSil";
            btnUyeSil.Size = new Size(152, 89);
            btnUyeSil.TabIndex = 8;
            btnUyeSil.Text = "Üye Sil";
            btnUyeSil.UseVisualStyleBackColor = false;
            btnUyeSil.Click += btnUyeSil_Click;
            // 
            // dgvUyeler
            // 
            dgvUyeler.AllowUserToAddRows = false;
            dgvUyeler.AllowUserToDeleteRows = false;
            dgvUyeler.BackgroundColor = Color.Black;
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.GridColor = SystemColors.ControlLightLight;
            dgvUyeler.Location = new Point(75, 146);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.RowHeadersVisible = false;
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.Size = new Size(406, 199);
            dgvUyeler.TabIndex = 7;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.BackColor = Color.SeaGreen;
            btnUyeEkle.FlatStyle = FlatStyle.Flat;
            btnUyeEkle.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUyeEkle.ForeColor = Color.PaleGoldenrod;
            btnUyeEkle.Location = new Point(519, 146);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(152, 89);
            btnUyeEkle.TabIndex = 6;
            btnUyeEkle.Text = "Üye Ekle";
            btnUyeEkle.UseVisualStyleBackColor = false;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // txtUyeTel
            // 
            txtUyeTel.BackColor = Color.Black;
            txtUyeTel.BorderStyle = BorderStyle.FixedSingle;
            txtUyeTel.ForeColor = Color.PaleGoldenrod;
            txtUyeTel.Location = new Point(498, 78);
            txtUyeTel.Name = "txtUyeTel";
            txtUyeTel.Size = new Size(198, 27);
            txtUyeTel.TabIndex = 5;
            // 
            // txtUyeSoyad
            // 
            txtUyeSoyad.BackColor = Color.Black;
            txtUyeSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtUyeSoyad.ForeColor = Color.PaleGoldenrod;
            txtUyeSoyad.Location = new Point(267, 78);
            txtUyeSoyad.Name = "txtUyeSoyad";
            txtUyeSoyad.Size = new Size(159, 27);
            txtUyeSoyad.TabIndex = 4;
            // 
            // txtUyeAd
            // 
            txtUyeAd.BackColor = Color.Black;
            txtUyeAd.BorderStyle = BorderStyle.FixedSingle;
            txtUyeAd.ForeColor = Color.PaleGoldenrod;
            txtUyeAd.Location = new Point(75, 78);
            txtUyeAd.Name = "txtUyeAd";
            txtUyeAd.Size = new Size(149, 27);
            txtUyeAd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.PaleGoldenrod;
            label3.Location = new Point(506, 42);
            label3.Name = "label3";
            label3.Size = new Size(184, 26);
            label3.TabIndex = 2;
            label3.Text = "Telefon Numarası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.PaleGoldenrod;
            label2.Location = new Point(309, 42);
            label2.Name = "label2";
            label2.Size = new Size(71, 26);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.PaleGoldenrod;
            label1.Location = new Point(125, 42);
            label1.Name = "label1";
            label1.Size = new Size(39, 26);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(641, 256);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(218, 209);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // tabAyarlar
            // 
            tabAyarlar.BackgroundImage = (Image)resources.GetObject("tabAyarlar.BackgroundImage");
            tabAyarlar.BackgroundImageLayout = ImageLayout.Stretch;
            tabAyarlar.Controls.Add(btnTalepReddet);
            tabAyarlar.Controls.Add(btnTalepleriGetir);
            tabAyarlar.Controls.Add(btnAylikRapor);
            tabAyarlar.Controls.Add(btnKategoriRapor);
            tabAyarlar.Controls.Add(btnEnCokOkuyanlar);
            tabAyarlar.Controls.Add(btnTalepOnayla);
            tabAyarlar.Controls.Add(dgvRaporlar);
            tabAyarlar.Controls.Add(btnGecikenKitaplar);
            tabAyarlar.Controls.Add(btnEnCokOkunanlar);
            tabAyarlar.Controls.Add(pictureBox4);
            tabAyarlar.Location = new Point(4, 29);
            tabAyarlar.Name = "tabAyarlar";
            tabAyarlar.Padding = new Padding(3);
            tabAyarlar.Size = new Size(810, 423);
            tabAyarlar.TabIndex = 3;
            tabAyarlar.Text = "Raporlar";
            tabAyarlar.UseVisualStyleBackColor = true;
            // 
            // btnTalepReddet
            // 
            btnTalepReddet.BackColor = Color.RosyBrown;
            btnTalepReddet.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnTalepReddet.Location = new Point(364, 355);
            btnTalepReddet.Name = "btnTalepReddet";
            btnTalepReddet.Size = new Size(149, 47);
            btnTalepReddet.TabIndex = 9;
            btnTalepReddet.Text = "Talebi Reddet";
            btnTalepReddet.UseVisualStyleBackColor = false;
            btnTalepReddet.Click += btnTalepReddet_Click;
            // 
            // btnTalepleriGetir
            // 
            btnTalepleriGetir.BackColor = Color.LavenderBlush;
            btnTalepleriGetir.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnTalepleriGetir.Location = new Point(534, 340);
            btnTalepleriGetir.Name = "btnTalepleriGetir";
            btnTalepleriGetir.Size = new Size(89, 62);
            btnTalepleriGetir.TabIndex = 7;
            btnTalepleriGetir.Text = "Talepleri Getir";
            btnTalepleriGetir.UseVisualStyleBackColor = false;
            btnTalepleriGetir.Click += btnTalepleriGetir_Click;
            // 
            // btnAylikRapor
            // 
            btnAylikRapor.BackColor = Color.LavenderBlush;
            btnAylikRapor.FlatStyle = FlatStyle.Popup;
            btnAylikRapor.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAylikRapor.Location = new Point(659, 30);
            btnAylikRapor.Name = "btnAylikRapor";
            btnAylikRapor.Size = new Size(132, 64);
            btnAylikRapor.TabIndex = 6;
            btnAylikRapor.Text = "Aylık Ödünç İstatistikleri";
            btnAylikRapor.UseVisualStyleBackColor = false;
            btnAylikRapor.Click += btnAylikRapor_Click;
            // 
            // btnKategoriRapor
            // 
            btnKategoriRapor.BackColor = Color.LavenderBlush;
            btnKategoriRapor.FlatStyle = FlatStyle.Popup;
            btnKategoriRapor.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKategoriRapor.Location = new Point(343, 29);
            btnKategoriRapor.Name = "btnKategoriRapor";
            btnKategoriRapor.Size = new Size(138, 66);
            btnKategoriRapor.TabIndex = 5;
            btnKategoriRapor.Text = "Kategori İstatistikleri";
            btnKategoriRapor.UseVisualStyleBackColor = false;
            btnKategoriRapor.Click += btnKategoriRapor_Click;
            // 
            // btnEnCokOkuyanlar
            // 
            btnEnCokOkuyanlar.BackColor = Color.LavenderBlush;
            btnEnCokOkuyanlar.FlatStyle = FlatStyle.Popup;
            btnEnCokOkuyanlar.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEnCokOkuyanlar.Location = new Point(500, 29);
            btnEnCokOkuyanlar.Name = "btnEnCokOkuyanlar";
            btnEnCokOkuyanlar.Size = new Size(139, 66);
            btnEnCokOkuyanlar.TabIndex = 4;
            btnEnCokOkuyanlar.Text = "En Çok Okuyan Üyeler";
            btnEnCokOkuyanlar.UseVisualStyleBackColor = false;
            btnEnCokOkuyanlar.Click += btnEnCokOkuyanlar_Click;
            // 
            // btnTalepOnayla
            // 
            btnTalepOnayla.BackColor = Color.LightCyan;
            btnTalepOnayla.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnTalepOnayla.Location = new Point(209, 355);
            btnTalepOnayla.Name = "btnTalepOnayla";
            btnTalepOnayla.Size = new Size(149, 47);
            btnTalepOnayla.TabIndex = 3;
            btnTalepOnayla.Text = "Talebi Onayla";
            btnTalepOnayla.UseVisualStyleBackColor = false;
            btnTalepOnayla.Click += btnTalepOnayla_Click;
            // 
            // dgvRaporlar
            // 
            dgvRaporlar.AllowUserToAddRows = false;
            dgvRaporlar.BackgroundColor = Color.LavenderBlush;
            dgvRaporlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRaporlar.Location = new Point(209, 110);
            dgvRaporlar.Name = "dgvRaporlar";
            dgvRaporlar.ReadOnly = true;
            dgvRaporlar.RowHeadersVisible = false;
            dgvRaporlar.RowHeadersWidth = 51;
            dgvRaporlar.Size = new Size(414, 217);
            dgvRaporlar.TabIndex = 2;
            // 
            // btnGecikenKitaplar
            // 
            btnGecikenKitaplar.BackColor = Color.LavenderBlush;
            btnGecikenKitaplar.FlatStyle = FlatStyle.Popup;
            btnGecikenKitaplar.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGecikenKitaplar.Location = new Point(24, 28);
            btnGecikenKitaplar.Name = "btnGecikenKitaplar";
            btnGecikenKitaplar.Size = new Size(132, 66);
            btnGecikenKitaplar.TabIndex = 1;
            btnGecikenKitaplar.Text = "Geciken Kitaplar";
            btnGecikenKitaplar.UseVisualStyleBackColor = false;
            btnGecikenKitaplar.Click += btnGecikenKitaplar_Click;
            // 
            // btnEnCokOkunanlar
            // 
            btnEnCokOkunanlar.BackColor = Color.LavenderBlush;
            btnEnCokOkunanlar.FlatStyle = FlatStyle.Popup;
            btnEnCokOkunanlar.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEnCokOkunanlar.Location = new Point(184, 29);
            btnEnCokOkunanlar.Name = "btnEnCokOkunanlar";
            btnEnCokOkunanlar.Size = new Size(139, 66);
            btnEnCokOkunanlar.TabIndex = 0;
            btnEnCokOkunanlar.Text = "En Çok Okunan Kitaplar";
            btnEnCokOkunanlar.UseVisualStyleBackColor = false;
            btnEnCokOkunanlar.Click += btnEnCokOkunanlar_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(-44, 270);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(210, 189);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(818, 450);
            Controls.Add(Kitap);
            Controls.Add(txtKitapAd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Kütüphane";
            Load += Form1_Load;
            Kitap.ResumeLayout(false);
            tabKitap.ResumeLayout(false);
            tabKitap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabOdunc.ResumeLayout(false);
            tabOdunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAktifOduncler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabKayit.ResumeLayout(false);
            tabKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabAyarlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRaporlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtKitapAd;
        private DataGridViewTextBoxColumn kitapadsutun;
        private DataGridViewTextBoxColumn yazaradsutun;
        private TabControl Kitap;
        private TabPage tabKitap;
        private TabPage tabOdunc;
        private TabPage tabKayit;
        private TabPage tabAyarlar;
        private ComboBox cmbKategori;
        private Button btnKitapEkle;
        private TextBox txtYazar;
        private DataGridView dataGridView1;
        private DataGridView dgvUyeler;
        private Button btnUyeEkle;
        private TextBox txtUyeTel;
        private TextBox txtUyeSoyad;
        private TextBox txtUyeAd;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnOduncVer;
        private ComboBox cmbKitapSec;
        private ComboBox cmbUyeSec;
        private Button btnGuncelle;
        private TextBox txtKitap;
        public Button btnUyeSil;
        public Button btnSil;
        private DataGridView dgvAktifOduncler;
        private DataGridView dgvRaporlar;
        private Button btnGecikenKitaplar;
        private Button btnEnCokOkunanlar;
        private Button btnIadeEt;
        private Button btnTalepOnayla;
        private Button btnEnCokOkuyanlar;
        private Button btnAylikRapor;
        private Button btnKategoriRapor;
        private Button btnTalepleriGetir;
        private Label lblAra;
        private TextBox txtArama;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label5;
        private Button btnTalepReddet;
    }
}
