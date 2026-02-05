using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Data;
using EfeKutuphane.DAL;
using EfeKutuphane.Services;

namespace EfeKutuphane
{
    public partial class UyePanel : Form
    {
        int girisYapanID;
        static bool bildirimGosterildi = false;
        public UyePanel(int id)
        {
            InitializeComponent();
            this.girisYapanID = id;
        }
        private void UyePanel_Load(object sender, EventArgs e)
        {
            KullaniciAdiniGetir();
            VerileriYenile();
            BildirimleriKontrolEt();

        }

        private void btnTalepEt_Click(object sender, EventArgs e)
        {
            if (dgvKitapIste.CurrentRow != null)
            {
                int kitapId = Convert.ToInt32(dgvKitapIste.CurrentRow.Cells["id"].Value);
                string kitapAd = dgvKitapIste.CurrentRow.Cells["kitap_ad"].Value.ToString();

                try
                {
                    EfeKutuphane.Services.TalepService tService = new EfeKutuphane.Services.TalepService();
                    tService.YeniTalep(girisYapanID, kitapId);

                    MessageBox.Show($"'{kitapAd}' için talep oluşturuldu. Personel onayından sonra kitaplarım sekmesine düşecektir.");

                    VerileriYenile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Talep oluşturulamadı. Hata: " + ex.Message);
                }
            }
        }

        public void KullaniciAdiniGetir()
        {
            using (MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430069;User ID=26_132430069;Password=İnif123."))
            {
                baglan.Open();

                string sorgu = "SELECT ad, soyad FROM uyeler WHERE id = @id";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@id", girisYapanID);
                MySqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    label1.Text = "Hoş Geldin " + dr["ad"].ToString() + " " + dr["soyad"].ToString();
                }
            }
        }
        public void VerileriYenile()
        {
            OduncDAL oDal = new OduncDAL();
            KitapDAL kDal = new KitapDAL();

            dgvKitaplarim.DataSource = oDal.UyeKitaplariniGetir(girisYapanID);
            VeriYoluStiliniDuzenle(dgvKitaplarim);

            dgvKitapIste.DataSource = kDal.OduncIcinKitapGetir();
            VeriYoluStiliniDuzenle(dgvKitapIste);

            if (dgvKitapIste.Columns.Contains("id")) dgvKitapIste.Columns["id"].Visible = false;
        }

        private void VeriYoluStiliniDuzenle(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].Visible = false;
            }
            string[] gizlenecekler = { "id", "kullanici_id", "kitap_id", "durum" };
            foreach (string kolon in gizlenecekler)
            {
                if (dgv.Columns.Contains(kolon)) dgv.Columns[kolon].Visible = false;
            }
            dgv.BackgroundColor = Color.FromArgb(60, 60, 65);
            dgv.BorderStyle = BorderStyle.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            dgv.DefaultCellStyle.BackColor = Color.FromArgb(70, 70, 75);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DimGray;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(65, 65, 70);

            if (dgv.Columns.Contains("kitap_ad"))
                dgv.Columns["kitap_ad"].HeaderText = "Kitap";

            if (dgv.Columns.Contains("emanet_tarih"))
                dgv.Columns["emanet_tarih"].HeaderText = "Veriliş Tarihi";

            if (dgv.Name == "dgvKitaplarim")
            {
                dgv.Enabled = false;
            }

            if (dgv.Columns.Contains("yazar")) dgv.Columns["yazar"].HeaderText = "Yazar";

        }
        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            if (dgvKitapIste.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = string.Format("kitap_ad LIKE '%{0}%' OR yazar LIKE '%{0}%'", txtKitapAra.Text);
            }
        }
        private void BildirimleriKontrolEt()
        {
            try
            {
                TalepService ts = new TalepService();
                DataTable dt = ts.UyeBildirimleriniCek(girisYapanID);

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow satir in dt.Rows)
                    {
                        int talepId = Convert.ToInt32(satir["id"]);
                        string kitapAd = satir["kitap_ad"].ToString();
                        string durum = satir["durum"].ToString();
                        string retNedeni = satir["ret_nedeni"] != DBNull.Value ? satir["ret_nedeni"].ToString() : "";

                        if (durum == "Onaylandı")
                        {
                            MessageBox.Show($"Müjde! '{kitapAd}' talebin onaylandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (durum == "Reddedildi")
                        {
                            MessageBox.Show($"'{kitapAd}' talebin reddedildi.\nSebep: {retNedeni}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
                        {
                            baglan.Open();
                            string sorguGuncelle = "UPDATE kitaptalepleri SET is_read = 1 WHERE id = @tid";
                            MySqlCommand cmd = new MySqlCommand(sorguGuncelle, baglan);
                            cmd.Parameters.AddWithValue("@tid", talepId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
