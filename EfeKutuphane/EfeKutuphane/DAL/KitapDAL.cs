using System;
using System.Data;
using MySqlConnector;
using EfeKutuphane.Domain;

namespace EfeKutuphane.DAL
{
    public class KitapDAL
    {
        public DataTable KitaplariGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                string sorgu = @"SELECT k.id, k.kitap_ad, k.yazar, c.kategori_ad, k.durum
                                FROM kitaplistesi k 
                                INNER JOIN kitapkategori c ON k.kategori_id = c.id";
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.Fill(dt);
            }
            return dt;
        }

        public void KitapEkle(Kitap k)
        {
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                baglan.Open();
                string sorgu = "INSERT INTO kitaplistesi (kitap_ad, yazar, kategori_id, durum) VALUES (@ad, @yazar, @kat, 1)";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@ad", k.Ad);
                komut.Parameters.AddWithValue("@yazar", k.Yazar);
                komut.Parameters.AddWithValue("@kat", k.KategoriId);
                komut.ExecuteNonQuery();
            }
        }
        public void KitapSil(int id)
        {
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                baglan.Open();
                string sorgu = "DELETE FROM kitaplistesi WHERE id = @id";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
            }
        }
        public void KitapGuncelle(Kitap k)
        {
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                baglan.Open();
                string sorgu = "UPDATE kitaplistesi SET kitap_ad=@ad, yazar=@yazar, kategori_id=@kat WHERE id=@id";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);

                komut.Parameters.AddWithValue("@ad", k.Ad);
                komut.Parameters.AddWithValue("@yazar", k.Yazar);
                komut.Parameters.AddWithValue("@kat", k.KategoriId);
                komut.Parameters.AddWithValue("@id", k.Id);

                komut.ExecuteNonQuery();
            }
        }
        public DataTable EnCokOkunanlar()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                string sorgu = @"SELECT k.kitap_ad AS 'Kitap', COUNT(o.id) AS 'Okunma Sayısı'
                 FROM kitapodunc o 
                 INNER JOIN kitaplistesi k ON o.kitap_id = k.id 
                 GROUP BY k.kitap_ad 
                 ORDER BY 2 DESC 
                 LIMIT 5";
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.Fill(dt);
            }
            return dt;
        }
        public DataTable GecikenKitaplar()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                string sorgu = @"SELECT u.ad AS 'Ad', u.soyad AS 'Soyad', k.kitap_ad AS 'Kitap', o.emanet_tarih AS 'Tarih' 
                 FROM kitapodunc o 
                 INNER JOIN uyeler u ON o.kullanici_id = u.id 
                 INNER JOIN kitaplistesi k ON o.kitap_id = k.id 
                 WHERE DATEDIFF(CURDATE(), o.emanet_tarih) > 15 
                 AND o.teslim_tarih IS NULL";
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable OduncIcinKitapGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                string sorgu = "SELECT id, kitap_ad, yazar FROM kitaplistesi WHERE durum = 1";
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.Fill(dt);
            }
            return dt;
        }
        public DataTable KategoriBazliKitapSayilari()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                string sorgu = @"SELECT c.kategori_ad AS 'Kategori', COUNT(k.id) AS 'Kitap Adedi' 
                         FROM kitaplistesi k 
                         INNER JOIN kitapkategori c ON k.kategori_id = c.id 
                         GROUP BY c.kategori_ad 
                         ORDER BY COUNT(k.id) DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.Fill(dt);
            }
            return dt;
        }
    }
}