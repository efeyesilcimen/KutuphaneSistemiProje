using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfeKutuphane.DAL;
using EfeKutuphane.Domain;

namespace EfeKutuphane.Services
{
    public class UyeService
    {
        UyeDAL _uyeDal = new UyeDAL();

        public DataTable Listele() => _uyeDal.UyeleriGetir();
        public DataTable RaporGetir() => _uyeDal.AktifOduncleriGetir();
        public DataTable EnCokOkuyanlarRaporu()
        {
            return _uyeDal.EnCokKitapAlanUyeler();
        }

        public void Kaydet(Uye u)
        {
            if (string.IsNullOrEmpty(u.Ad)) throw new Exception("İsim boş olamaz!");
            _uyeDal.UyeEkle(u);
        }

        public void Sil(int id)
        {
            if (id <= 0) throw new Exception("Geçersiz ID!");
            _uyeDal.UyeSil(id);
        }
    }
}
