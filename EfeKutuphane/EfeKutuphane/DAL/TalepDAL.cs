using MySqlConnector;
using System.Data;
using System;

namespace EfeKutuphane.DAL
{
    public class TalepDAL
    {
        private string yol = Baglanti.Yol;
        public bool TalepOlustur(int uyeId, int kitapId)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                baglan.Open();
                string sorgu = "INSERT INTO kitaptalepleri (uye_id, kitap_id, talep_tarihi, durum) VALUES (@uid, @kid, NOW(), 'Beklemede')";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@uid", uyeId);
                komut.Parameters.AddWithValue("@kid", kitapId);
                return komut.ExecuteNonQuery() > 0;
            }
        }
        public DataTable TalepleriGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                string sorgu = @"SELECT t.id AS 'Talep No', t.uye_id, t.kitap_id, 
                         CONCAT(u.ad, ' ', u.soyad) AS 'Üye', k.kitap_ad AS 'İstenen Kitap', 
                         t.talep_tarihi AS 'Tarih'
                         FROM kitaptalepleri t 
                         INNER JOIN uyeler u ON t.uye_id = u.id 
                         INNER JOIN kitaplistesi k ON t.kitap_id = k.id 
                         WHERE t.durum = 'Beklemede'";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.Fill(dt);
            }
            return dt;
        }

        public bool TalepOnayla(int talepId, int uyeId, int kitapId)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                baglan.Open();
                MySqlTransaction trans = baglan.BeginTransaction();
                try
                {
                    string sorgu1 = "UPDATE kitaptalepleri SET durum = 'Onaylandı' WHERE id = @tid";
                    MySqlCommand cmd1 = new MySqlCommand(sorgu1, baglan, trans);
                    cmd1.Parameters.AddWithValue("@tid", talepId);
                    cmd1.ExecuteNonQuery();

                    string sorgu2 = "INSERT INTO kitapodunc (kullanici_id, kitap_id, emanet_tarih) VALUES (@uid, @kid, NOW())";
                    MySqlCommand cmd2 = new MySqlCommand(sorgu2, baglan, trans);
                    cmd2.Parameters.AddWithValue("@uid", uyeId);
                    cmd2.Parameters.AddWithValue("@kid", kitapId);
                    cmd2.ExecuteNonQuery();

                    string sorgu3 = "UPDATE kitaplistesi SET durum = 0 WHERE id = @kid";
                    MySqlCommand cmd3 = new MySqlCommand(sorgu3, baglan, trans);
                    cmd3.Parameters.AddWithValue("@kid", kitapId);
                    cmd3.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    return false;
                }
            }  
        }
        public bool TalepReddet(int talepId, string neden)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                baglan.Open();
                string sorgu = "UPDATE kitaptalepleri SET durum = 'Reddedildi', ret_nedeni = @neden WHERE id = @tid";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@neden", neden);
                cmd.Parameters.AddWithValue("@tid", talepId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public DataTable UyeOzelTalepleriGetir(int uyeId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                string sorgu = @"SELECT t.id, k.kitap_ad, t.durum, t.ret_nedeni 
                         FROM kitaptalepleri t 
                         INNER JOIN kitaplistesi k ON t.kitap_id = k.id 
                         WHERE t.uye_id = @uid AND t.durum != 'Beklemede' AND t.is_read = 0";

                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.SelectCommand.Parameters.AddWithValue("@uid", uyeId);
                da.Fill(dt);
            }
            return dt;
        }
    }
}