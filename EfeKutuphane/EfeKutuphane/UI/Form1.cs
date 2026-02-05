//using MySql.Data.MySqlClient;
using System.Data;
using EfeKutuphane.DAL;
using EfeKutuphane.Domain;
using EfeKutuphane.Services;
using MySqlConnector;


    namespace EfeKutuphane
{
    public partial class Form1 : Form
    {
        public string girisYapanRol;
        int secilenKitapId;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430069;User ID=26_132430069; Password=Ýnif123.");

            KategoriDAL katDal = new KategoriDAL();
            cmbKategori.DataSource = katDal.KategorileriGetir();
            cmbKategori.DisplayMember = "kategori_ad";
            cmbKategori.ValueMember = "id";

            UyeDAL uDal = new UyeDAL();

            KitapDAL kDal = new KitapDAL();
            dataGridView1.DataSource = kDal.KitaplariGetir();
            DataTable kitapTablo = kDal.OduncIcinKitapGetir();
            cmbKitapSec.DisplayMember = "kitap_ad";
            cmbKitapSec.ValueMember = "id";
            cmbKitapSec.DataSource = kitapTablo;


            OduncDAL oDal = new OduncDAL();
            dgvAktifOduncler.DataSource = oDal.TumOduncleriGetir();

            dgvUyeler.DataSource = uDal.UyeleriGetir();

            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["kitap_ad"].HeaderText = "Kitap";
            dataGridView1.Columns["yazar"].HeaderText = "Yazar";
            dataGridView1.Columns["kategori_ad"].HeaderText = "Kategori";
            dataGridView1.Columns["durum"].HeaderText = "Durum";
        

        
            dgvAktifOduncler.Columns["kitap_id"].Visible = false;
            dgvAktifOduncler.Columns["No"].Visible = false;
            dgvUyeler.Columns["id"].Visible = false;
            dgvUyeler.Columns["id"].DataPropertyName = "id";
            if (dgvUyeler.Columns.Contains("tam_ad")) dgvUyeler.Columns["tam_ad"].Visible = false;

            txtKitap.PlaceholderText = "Kitap adýný giriniz...";
            txtYazar.PlaceholderText = "Yazar adýný giriniz...";

            // --- dataGridView1 Antika Kütüphane Tasarýmý ---

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.BackgroundColor = Color.FromArgb(45, 25, 15);
            dataGridView1.GridColor = Color.Sienna;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(60, 35, 25);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Beige;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Sienna;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Sienna;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Beige;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Sienna;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Beige;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;

            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Sienna;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(70, 40, 30);


            cmbKitapSec.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbKitapSec.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbUyeSec.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUyeSec.AutoCompleteSource = AutoCompleteSource.ListItems;

            KitaplariListele();
            UyeleriListele();
            OduncleriListele();
            TalepleriListele();
            CombolariDoldur();


            try
            {
                baglanti.Open();

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Sunucu Baðlantý Hatasý: " + ex.Message);
            }

        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKitap.Text) || string.IsNullOrWhiteSpace(txtYazar.Text))
            {
                MessageBox.Show("Lütfen Kitap Adý ve Yazar alanlarýný doldurun!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Kitap yeniKitap = new Kitap
                {
                    Ad = txtKitap.Text.Trim(),
                    Yazar = txtYazar.Text.Trim(),
                    KategoriId = Convert.ToInt32(cmbKategori.SelectedValue)
                };

                KitapService servis = new KitapService();
                servis.Ekle(yeniKitap);

                MessageBox.Show("Kitap baþarýyla eklendi!", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);

                KitaplariListele();

                txtKitap.Clear();
                txtYazar.Clear();
                secilenKitapId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme baþarýsýz: " + ex.Message);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                    string kitapAdi = dataGridView1.CurrentRow.Cells["kitap_ad"].Value.ToString();

                    DialogResult onay = MessageBox.Show($"'{kitapAdi}' isimli kitabý silmek istediðinize emin misiniz?",
                        "Kritik Ýþlem Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (onay == DialogResult.Yes)
                    {
                        KitapService servis = new KitapService();
                        servis.Sil(id);

                        KitaplariListele();
                        txtKitap.Clear();
                        txtYazar.Clear();

                        MessageBox.Show("Kitap baþarýyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme iþlemi sýrasýnda hata oluþtu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden silmek istediðiniz kitabýn üzerine bir kez týklayýn.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                EfeKutuphane.Domain.Uye yeniUye = new EfeKutuphane.Domain.Uye
                {
                    Ad = txtUyeAd.Text,
                    Soyad = txtUyeSoyad.Text,
                    Telefon = txtUyeTel.Text
                };

                EfeKutuphane.Services.UyeService servis = new EfeKutuphane.Services.UyeService();
                servis.Kaydet(yeniUye);

                MessageBox.Show("Üye baþarýyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUyeAd.Clear(); txtUyeSoyad.Clear(); txtUyeTel.Clear();
                UyeleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            if (cmbUyeSec.SelectedValue == null || cmbKitapSec.SelectedValue == null)
            {
                MessageBox.Show("Lütfen listeden geçerli bir üye ve kitap seçin!");
                return;
            }

            int uyeId = Convert.ToInt32(cmbUyeSec.SelectedValue);
            int kitapId = Convert.ToInt32(cmbKitapSec.SelectedValue);

            OduncDAL odal = new OduncDAL();
            bool basariliMi = odal.KitapOduncVer(uyeId, kitapId);

            if (basariliMi)
            {
                MessageBox.Show("Kitap baþarýyla ödünç verildi.");

                KitapDAL kdal = new KitapDAL();

                dataGridView1.DataSource = kdal.KitaplariGetir();
                dgvAktifOduncler.DataSource = odal.TumOduncleriGetir();
                cmbKitapSec.DataSource = kdal.OduncIcinKitapGetir();

                cmbKitapSec.Text = "";
                cmbUyeSec.Text = "";
            }
            else
            {
                MessageBox.Show("HATA: Bu kitap þu an baþka bir üyede!");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dataGridView1.Rows[e.RowIndex];

                txtKitap.Text = satir.Cells["kitap_ad"].Value.ToString();
                txtYazar.Text = satir.Cells["yazar"].Value.ToString();

                secilenKitapId = Convert.ToInt32(satir.Cells["id"].Value);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    Kitap guncellenecekKitap = new Kitap
                    {
                        Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value),
                        Ad = txtKitap.Text,
                        Yazar = txtYazar.Text,
                        KategoriId = Convert.ToInt32(cmbKategori.SelectedValue)
                    };

                    KitapService servis = new KitapService();
                    servis.Guncelle(guncellenecekKitap);

                    MessageBox.Show("Kitap baþarýyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    KitaplariListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme hatasý: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tablodan güncellenecek bir kitap seçin!");
            }
        }
        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow != null)
            {
                try
                {
                    int id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["id"].Value);

                    EfeKutuphane.Services.UyeService servis = new EfeKutuphane.Services.UyeService();
                    servis.Sil(id);

                    MessageBox.Show("Üye silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UyeleriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatasý: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir üye seçin.");
            }
        }

        private void btnEnCokOkunanlar_Click(object sender, EventArgs e)
        {
            KitapService servis = new KitapService();
            dgvRaporlar.DataSource = servis.EnCokOkunanlariGetir();
        }
        private void btnGecikenKitaplar_Click(object sender, EventArgs e)
        {
            KitapService servis = new KitapService();
            dgvRaporlar.DataSource = servis.GecikenleriGetir();
        }
        private void btnIadeEt_Click(object sender, EventArgs e)
        {
            if (dgvAktifOduncler.CurrentRow != null)
            {
                int oduncId = Convert.ToInt32(dgvAktifOduncler.CurrentRow.Cells["No"].Value);
                int kitapId = Convert.ToInt32(dgvAktifOduncler.CurrentRow.Cells["kitap_id"].Value);

                OduncDAL oDal = new OduncDAL();
                if (oDal.KitapIadeAl(oduncId, kitapId))
                {
                    MessageBox.Show("Kitap teslim alýndý, raf durumu güncellendi.");

                    dgvAktifOduncler.DataSource = oDal.TumOduncleriGetir();

                    KitapDAL kDal = new KitapDAL();
                    cmbKitapSec.DataSource = kDal.OduncIcinKitapGetir();
                }
            }
        }
        private void TalepleriListele()
        {
            EfeKutuphane.Services.TalepService tService = new EfeKutuphane.Services.TalepService();
            dgvRaporlar.DataSource = tService.Listele();

            dgvRaporlar.BackgroundColor = Color.LavenderBlush;
            dgvRaporlar.BorderStyle = BorderStyle.None;
            dgvRaporlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRaporlar.RowHeadersVisible = false;
            dgvRaporlar.AllowUserToAddRows = false;
            dgvRaporlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRaporlar.GridColor = Color.MistyRose;

            dgvRaporlar.EnableHeadersVisualStyles = false;
            dgvRaporlar.ColumnHeadersDefaultCellStyle.BackColor = Color.Thistle;
            dgvRaporlar.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkSlateGray;
            dgvRaporlar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvRaporlar.ColumnHeadersHeight = 40;

            dgvRaporlar.DefaultCellStyle.BackColor = Color.White;
            dgvRaporlar.DefaultCellStyle.ForeColor = Color.DarkSlateGray;
            dgvRaporlar.DefaultCellStyle.SelectionBackColor = Color.Plum;
            dgvRaporlar.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvRaporlar.RowTemplate.Height = 35;
            dgvRaporlar.AlternatingRowsDefaultCellStyle.BackColor = Color.LavenderBlush;

            dgvRaporlar.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Thistle;
            dgvRaporlar.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.DarkSlateGray;
            dgvRaporlar.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Plum;


            if (dgvRaporlar.Columns.Contains("Talep No")) dgvRaporlar.Columns["Talep No"].Visible = false;
            if (dgvRaporlar.Columns.Contains("uye_id")) dgvRaporlar.Columns["uye_id"].Visible = false;
            if (dgvRaporlar.Columns.Contains("kitap_id")) dgvRaporlar.Columns["kitap_id"].Visible = false;

            if (dgvRaporlar.Columns.Contains("Üye")) dgvRaporlar.Columns["Üye"].HeaderText = "Ýstekte Bulunan";
            if (dgvRaporlar.Columns.Contains("Ýstenen Kitap")) dgvRaporlar.Columns["Ýstenen Kitap"].HeaderText = "Kitap Adý";
            if (dgvRaporlar.Columns.Contains("Tarih")) dgvRaporlar.Columns["Tarih"].HeaderText = "Talep Zamaný";
        }
        private void btnTalepOnayla_Click(object sender, EventArgs e)
        {
            if (dgvRaporlar.CurrentRow != null)
            {
                try
                {
                    int talepId = Convert.ToInt32(dgvRaporlar.CurrentRow.Cells["Talep No"].Value);
                    int uyeId = Convert.ToInt32(dgvRaporlar.CurrentRow.Cells["uye_id"].Value);
                    int kitapId = Convert.ToInt32(dgvRaporlar.CurrentRow.Cells["kitap_id"].Value);

                    EfeKutuphane.Services.TalepService tService = new EfeKutuphane.Services.TalepService();

                    tService.Onayla(talepId, uyeId, kitapId);

                    MessageBox.Show("Talep onaylandý ve kitap üyeye teslim edildi.");

                    btnTalepleriGetir.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ýþlem hatasý: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir talep seçin.");
            }
        }
        public void UyeleriListele()
        {
            EfeKutuphane.Services.UyeService servis = new EfeKutuphane.Services.UyeService();
            dgvUyeler.DataSource = servis.Listele();

            if (dgvUyeler.Columns.Contains("id"))
                dgvUyeler.Columns["id"].Visible = false;

            dgvUyeler.BackgroundColor = Color.Black;
            dgvUyeler.BorderStyle = BorderStyle.None;
            dgvUyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUyeler.RowHeadersVisible = false;
            dgvUyeler.AllowUserToAddRows = false;
            dgvUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUyeler.GridColor = Color.FromArgb(50, 50, 50);

            dgvUyeler.EnableHeadersVisualStyles = false;
            dgvUyeler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvUyeler.ColumnHeadersDefaultCellStyle.ForeColor = Color.PaleGoldenrod;
            dgvUyeler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvUyeler.ColumnHeadersHeight = 40;

            dgvUyeler.DefaultCellStyle.BackColor = Color.Black;
            dgvUyeler.DefaultCellStyle.ForeColor = Color.PaleGoldenrod;
            dgvUyeler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 0);
            dgvUyeler.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvUyeler.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dgvUyeler.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            dgvUyeler.AlternatingRowsDefaultCellStyle.ForeColor = Color.PaleGoldenrod;
            dgvUyeler.EnableHeadersVisualStyles = false;

            dgvUyeler.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 40, 30);
            dgvUyeler.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.PaleGoldenrod;

            dgvUyeler.RowHeadersDefaultCellStyle.SelectionBackColor = Color.PaleGoldenrod;


            if (dgvUyeler.Columns.Contains("id")) dgvUyeler.Columns["id"].Visible = false;
            if (dgvUyeler.Columns.Contains("ad")) dgvUyeler.Columns["ad"].HeaderText = "Üye Adý";
            if (dgvUyeler.Columns.Contains("soyad")) dgvUyeler.Columns["soyad"].HeaderText = "Soyadý";
            if (dgvUyeler.Columns.Contains("telefon")) dgvUyeler.Columns["telefon"].HeaderText = "Ýletiþim";
            txtKitap.PlaceholderText = "Kitap adýný giriniz...";
            txtYazar.PlaceholderText = "Yazar adýný giriniz...";

            dgvUyeler.ReadOnly = true;
            dgvUyeler.AllowUserToOrderColumns = false;
        }
        public void KitaplariListele()
        {

            try
            {
                EfeKutuphane.Services.KitapService servis = new EfeKutuphane.Services.KitapService();
                DataTable dt = servis.HepsiniGetir();
               
                if (!dt.Columns.Contains("DurumMetin"))
                {
                    dt.Columns.Add("DurumMetin", typeof(string));
                }

                foreach (DataRow row in dt.Rows)
                {
                    string hamDeger = row["durum"].ToString().ToLower();

                    if (hamDeger == "1" || hamDeger == "true")
                    {
                        row["DurumMetin"] = "Var";
                    }
                    else
                    {
                        row["DurumMetin"] = "Yok";
                    }
                }

                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                if (dataGridView1.Columns.Contains("id")) dataGridView1.Columns["id"].Visible = false;
                if (dataGridView1.Columns.Contains("durum")) dataGridView1.Columns["durum"].Visible = false;


                if (dataGridView1.Columns.Contains("kitap_ad"))
                {
                    dataGridView1.Columns["kitap_ad"].HeaderText = "Kitap Adý";
                    dataGridView1.Columns["kitap_ad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                if (dataGridView1.Columns.Contains("yazar"))
                {
                    dataGridView1.Columns["yazar"].HeaderText = "Yazar";
                    dataGridView1.Columns["yazar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                if (dataGridView1.Columns.Contains("kategori_ad"))
                {
                    dataGridView1.Columns["kategori_ad"].HeaderText = "Kategori";
                    dataGridView1.Columns["kategori_ad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }

                if (dataGridView1.Columns.Contains("DurumMetin"))
                {
                    dataGridView1.Columns["DurumMetin"].HeaderText = "Durum";
                    dataGridView1.Columns["DurumMetin"].Width = 72;
                    dataGridView1.Columns["DurumMetin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatasý: " + ex.Message);
            }
        }
        public void OduncleriListele()
        {
            EfeKutuphane.Services.OduncService servis = new EfeKutuphane.Services.OduncService();
            dgvAktifOduncler.DataSource = servis.HepsiniGetir();

            dgvAktifOduncler.DefaultCellStyle.SelectionBackColor = Color.DarkGoldenrod;

            dgvAktifOduncler.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGreen;
            dgvAktifOduncler.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.PaleGoldenrod;

            dgvAktifOduncler.RowHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGoldenrod;
            dgvAktifOduncler.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            dgvAktifOduncler.BackgroundColor = Color.FromArgb(20, 35, 20);
            dgvAktifOduncler.BorderStyle = BorderStyle.None;
            dgvAktifOduncler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAktifOduncler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAktifOduncler.GridColor = Color.DarkGoldenrod;

            dgvAktifOduncler.EnableHeadersVisualStyles = false;
            dgvAktifOduncler.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dgvAktifOduncler.ColumnHeadersDefaultCellStyle.ForeColor = Color.PaleGoldenrod;
            dgvAktifOduncler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvAktifOduncler.ColumnHeadersHeight = 40;
            dgvAktifOduncler.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgvAktifOduncler.DefaultCellStyle.BackColor = Color.FromArgb(25, 45, 25);
            dgvAktifOduncler.DefaultCellStyle.ForeColor = Color.PaleGoldenrod;
            dgvAktifOduncler.DefaultCellStyle.SelectionBackColor = Color.DarkGoldenrod;
            dgvAktifOduncler.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAktifOduncler.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvAktifOduncler.RowTemplate.Height = 35;

            dgvAktifOduncler.DefaultCellStyle.SelectionBackColor = Color.DarkGoldenrod;
            dgvAktifOduncler.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAktifOduncler.RowTemplate.Height = 35;

            dgvAktifOduncler.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(20, 40, 20);

            if (dgvAktifOduncler.Columns.Contains("No")) dgvAktifOduncler.Columns["No"].Visible = false;
            if (dgvAktifOduncler.Columns.Contains("kitap_id")) dgvAktifOduncler.Columns["kitap_id"].Visible = false;
            dgvAktifOduncler.ReadOnly = true;
            dgvAktifOduncler.AllowUserToOrderColumns = false;
            dgvAktifOduncler.StandardTab = true;
            dgvAktifOduncler.EnableHeadersVisualStyles = false;
            dgvAktifOduncler.AllowUserToAddRows = false;
            dgvAktifOduncler.MultiSelect = false;
            dgvAktifOduncler.RowHeadersVisible = false;

        }
        private void btnEnCokOkuyanlar_Click(object sender, EventArgs e)
        {
            try
            {
                EfeKutuphane.Services.UyeService servis = new EfeKutuphane.Services.UyeService();
                dgvRaporlar.DataSource = servis.EnCokOkuyanlarRaporu();

                dgvRaporlar.Columns[0].HeaderText = "Üye Adý";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor hatasý: " + ex.Message);
            }
        }
        private void btnKategoriRapor_Click(object sender, EventArgs e)
        {
            try
            {
                EfeKutuphane.Services.KitapService servis = new EfeKutuphane.Services.KitapService();
                dgvRaporlar.DataSource = servis.KategoriIstatistikRaporu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor hatasý: " + ex.Message);
            }
        }
        private void btnAylikRapor_Click(object sender, EventArgs e)
        {
            try
            {
                EfeKutuphane.Services.OduncService servis = new EfeKutuphane.Services.OduncService();
                dgvRaporlar.DataSource = servis.AylikIstatistikRaporu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor hatasý: " + ex.Message);
            }
        }

        private void btnTalepleriGetir_Click(object sender, EventArgs e)
        {
            EfeKutuphane.Services.TalepService tService = new EfeKutuphane.Services.TalepService();
            dgvRaporlar.DataSource = tService.Listele();

            if (dgvRaporlar.Columns.Contains("uye_id")) dgvRaporlar.Columns["uye_id"].Visible = false;
            if (dgvRaporlar.Columns.Contains("kitap_id")) dgvRaporlar.Columns["kitap_id"].Visible = false;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource is DataTable dt)
                {
                    if (string.IsNullOrWhiteSpace(txtArama.Text))
                    {
                        dt.DefaultView.RowFilter = string.Empty;
                    }
                    else
                    {
                        dt.DefaultView.RowFilter = string.Format("kitap_ad LIKE '%{0}%' OR yazar LIKE '%{0}%'", txtArama.Text.Replace("'", "''"));
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void CombolariDoldur()
        {
            KitapDAL kDal = new KitapDAL();
            UyeDAL uDal = new UyeDAL();

            DataTable dtKitaplar = kDal.OduncIcinKitapGetir();
            cmbKitapSec.DataSource = dtKitaplar;
            cmbKitapSec.DisplayMember = "kitap_ad";
            cmbKitapSec.ValueMember = "id";

            DataTable dtUyeler = uDal.UyeleriGetir();
            cmbUyeSec.DataSource = dtUyeler;
            cmbUyeSec.DisplayMember = "tam_ad";
            cmbUyeSec.ValueMember = "id";
        }

        private void btnTalepReddet_Click(object sender, EventArgs e)
        {
            if (dgvRaporlar.SelectedRows.Count > 0)
            {
                int talepId = Convert.ToInt32(dgvRaporlar.CurrentRow.Cells["Talep No"].Value);
                string neden = Microsoft.VisualBasic.Interaction.InputBox("Reddedilme Sebebi Nedir?", "Talep Reddet", "Kitap þu an bakýmda/kayýp.");

                if (!string.IsNullOrWhiteSpace(neden))
                {
                    TalepService ts = new TalepService();
                    ts.Reddet(talepId, neden);
                    MessageBox.Show("Talep reddedildi.");
                    TalepleriListele(); 
                }
            }
        }
    }
}      


