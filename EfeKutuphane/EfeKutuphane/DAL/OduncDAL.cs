using System;
using System.Data;
using MySqlConnector;
using EfeKutuphane.Domain;

namespace EfeKutuphane.DAL
{
    public class OduncDAL
    {
        private string yol = Baglanti.Yol;

        public DataTable TumOduncleriGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                string sorgu = @"SELECT o.id AS 'No', o.kitap_id, k.kitap_ad AS 'Kitap', 
                                 CONCAT(uy.ad, ' ', uy.soyad) AS 'Üye Adı', o.emanet_tarih AS 'Tarih' 
                                 FROM kitapodunc o 
                                 LEFT JOIN kitaplistesi k ON o.kitap_id = k.id 
                                 LEFT JOIN uyeler uy ON o.kullanici_id = uy.id 
                                 WHERE o.teslim_tarih IS NULL";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.Fill(dt);
            }
            return dt;
        }

        public bool KitapOduncVer(int uyeId, int kitapId)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                baglan.Open();

                string kontrolSorgu = "SELECT durum FROM kitaplistesi WHERE id = @kitapId";
                MySqlCommand kontrolKomut = new MySqlCommand(kontrolSorgu, baglan);
                kontrolKomut.Parameters.AddWithValue("@kitapId", kitapId);

                object sonuc = kontrolKomut.ExecuteScalar();
                int durum = sonuc != null ? Convert.ToInt32(sonuc) : 0;

                if (durum == 0) return false; 

                string oduncSorgu = "INSERT INTO kitapodunc (kullanici_id, kitap_id, emanet_tarih) VALUES (@uye, @kitap, @tarih)";
                MySqlCommand oduncKomut = new MySqlCommand(oduncSorgu, baglan);
                oduncKomut.Parameters.AddWithValue("@uye", uyeId);
                oduncKomut.Parameters.AddWithValue("@kitap", kitapId);
                oduncKomut.Parameters.AddWithValue("@tarih", DateTime.Now);
                oduncKomut.ExecuteNonQuery();

                string guncelleSorgu = "UPDATE kitaplistesi SET durum = 0 WHERE id = @kitapId";
                MySqlCommand guncelleKomut = new MySqlCommand(guncelleSorgu, baglan);
                guncelleKomut.Parameters.AddWithValue("@kitapId", kitapId);
                guncelleKomut.ExecuteNonQuery();

                return true;
            }
        }
        public bool KitapIadeAl(int oduncId, int kitapId)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                baglan.Open();

                string iadeSorgu = "UPDATE kitapodunc SET teslim_tarih = @tarih WHERE id = @oid";
                MySqlCommand cmd1 = new MySqlCommand(iadeSorgu, baglan);
                cmd1.Parameters.AddWithValue("@tarih", DateTime.Now);
                cmd1.Parameters.AddWithValue("@oid", oduncId);

                string durumSorgu = "UPDATE kitaplistesi SET durum = 1 WHERE id = @kid";
                MySqlCommand cmd2 = new MySqlCommand(durumSorgu, baglan);
                cmd2.Parameters.AddWithValue("@kid", kitapId);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                return true;
            }
        }
        public DataTable UyeKitaplariniGetir(int uyeId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                string sorgu = @"SELECT o.id AS 'No', k.kitap_ad AS 'Kitap Adı', 
                                 o.emanet_tarih AS 'Veriliş Tarihi'
                                 FROM kitapodunc o 
                                 INNER JOIN kitaplistesi k ON o.kitap_id = k.id 
                                 WHERE o.kullanici_id = @uid AND o.teslim_tarih IS NULL";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.SelectCommand.Parameters.AddWithValue("@uid", uyeId);
                da.Fill(dt);
            }
            return dt;
        }
        public DataTable AylikOduncIstatistikleri()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                string sorgu = @"SELECT DATE_FORMAT(emanet_tarih, '%Y-%m') AS 'Donem', COUNT(*) AS 'Adet' 
                         FROM kitapodunc 
                         WHERE emanet_tarih IS NOT NULL
                         GROUP BY Donem 
                         ORDER BY Donem DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.Fill(dt);
            }
            return dt;
        }
        public void OduncAl(int kullaniciId, int kitapId)
        {
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                baglan.Open();
                string sorguOdunc = "INSERT INTO kitapodunc (kullanici_id, kitap_id, emanet_tarih) VALUES (@uId, @kId, NOW())";
                MySqlCommand komutOdunc = new MySqlCommand(sorguOdunc, baglan);
                komutOdunc.Parameters.AddWithValue("@uId", kullaniciId);
                komutOdunc.Parameters.AddWithValue("@kId", kitapId);
                komutOdunc.Parameters.AddWithValue("@tarih", DateTime.Now);
                komutOdunc.ExecuteNonQuery();

                string sorguGuncelle = "UPDATE kitaplistesi SET durum = 0 WHERE id = @kId";
                MySqlCommand komutGuncelle = new MySqlCommand(sorguGuncelle, baglan);
                komutGuncelle.Parameters.AddWithValue("@kId", kitapId);
                komutGuncelle.ExecuteNonQuery();
            }
        }
    }  
}