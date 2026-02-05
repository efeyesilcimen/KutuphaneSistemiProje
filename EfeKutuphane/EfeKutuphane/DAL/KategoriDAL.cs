using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using MySql.Data.MySqlClient;
using MySqlConnector;

namespace EfeKutuphane.DAL
{
    public class KategoriDAL
    {
        public DataTable KategorileriGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglan = new MySqlConnection(Baglanti.Yol))
            {
                string sorgu = "SELECT id, kategori_ad FROM kitapkategori";
                MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                da.Fill(dt);
            }
            return dt;
        }
    }
}


