using MySqlConnector;
using System;

namespace EfeKutuphane.DAL
{
    public class LoginDAL
    {
        private string yol = Baglanti.Yol;
        public string GirisYapVeRolGetir(string ad, string sifre)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                baglan.Open();
                string sorgu = "SELECT rol FROM kullanicilar WHERE kullanici_adi=@ad AND sifre=@sifre";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@sifre", sifre);

                object sonuc = komut.ExecuteScalar();
                return sonuc != null ? sonuc.ToString() : null;
            }
        }
        public int GirisYapanIdGetir(string kAdi, string sifre)
        {
            using (MySqlConnection baglan = new MySqlConnection(yol))
            {
                baglan.Open();
                string sorgu = "SELECT id FROM kullanicilar WHERE kullanici_adi=@ka AND sifre=@s";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@ka", kAdi);
                komut.Parameters.AddWithValue("@s", sifre);

                object sonuc = komut.ExecuteScalar();
                return sonuc != null ? Convert.ToInt32(sonuc) : 0;
            }
        }
    }
}
