using System;
using System.Data;
using MySqlConnector;
using System.Windows.Forms;
using EfeKutuphane.Domain;

namespace EfeKutuphane.DAL
{
    public class UyeDAL
    {
        public DataTable UyeleriGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                string sorgu = "SELECT id, CONCAT(ad, ' ', soyad) AS tam_ad, ad, soyad, telefon FROM uyeler";
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.Fill(dt);
            }
            return dt;
        }
        
        public void UyeEkle(Uye u)
        {
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                baglan.Open();
                string sorgu = "INSERT INTO uyeler (ad, soyad, telefon) VALUES (@ad, @soyad, @tel)";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@ad", u.Ad);
                komut.Parameters.AddWithValue("@soyad", u.Soyad);
                komut.Parameters.AddWithValue("@tel", u.Telefon);
                komut.ExecuteNonQuery();
            }
        }
        public void UyeSil(int id)
        {
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                baglan.Open();
                string sorgu = "DELETE FROM uyeler WHERE id = @id";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
            }
        }
        public DataTable UyeOduncleriGetir(int uyeId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                string sorgu = @"SELECT k.kitap_ad AS 'Kitap Adı', o.emanet_tarih AS 'Veriliş' 
                         FROM kitapodunc o 
                         JOIN kitaplistesi k ON o.kitap_id = k.id 
                         WHERE o.kullanici_id = @uyeId";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.SelectCommand.Parameters.AddWithValue("@uyeId", uyeId);
                da.Fill(dt);
            }
            return dt;
        }
        public DataTable AktifOduncleriGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                string sorgu = @"SELECT uyeler.Ad, uyeler.Soyad, kitaplistesi.kitap_ad AS 'Aldığı Kitap', kitapodunc.emanet_tarih 
                        FROM kitapodunc 
                        INNER JOIN uyeler ON kitapodunc.kullanici_id = uyeler.id 
                        INNER JOIN kitaplistesi ON kitapodunc.kitap_id = kitaplistesi.id";
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.Fill(dt);
            }
            return dt;
        }
        public DataTable EnCokKitapAlanUyeler()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                string sorgu = @"SELECT u.ad AS 'Ad', u.soyad AS 'Soyad', COUNT(o.id) AS 'Aldığı Kitap Sayısı' 
                         FROM kitapodunc o 
                         INNER JOIN uyeler u ON o.kullanici_id = u.id 
                         GROUP BY u.id, u.ad, u.soyad 
                         ORDER BY COUNT(o.id) DESC 
                         LIMIT 10";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.Fill(dt);
            }
            return dt;
        }
    }     
}

