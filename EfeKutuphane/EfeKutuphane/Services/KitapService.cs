using EfeKutuphane.DAL;
using EfeKutuphane.Domain;
using System.Data;

namespace EfeKutuphane.Services
{
    public class KitapService
    {
        KitapDAL _kitapDal = new KitapDAL();
        public DataTable HepsiniGetir() => _kitapDal.KitaplariGetir();
        public DataTable GecikenleriGetir() => _kitapDal.GecikenKitaplar();
        public DataTable EnCokOkunanlariGetir() => _kitapDal.EnCokOkunanlar();
        public DataTable MevcutKitaplariGetir() => _kitapDal.OduncIcinKitapGetir();
        public DataTable KategoriIstatistikRaporu()
        {
            return _kitapDal.KategoriBazliKitapSayilari();
        }
        public void Ekle(Kitap k)
        {
            if (string.IsNullOrWhiteSpace(k.Ad)) throw new Exception("Kitap ismi boş olamaz!");
            _kitapDal.KitapEkle(k);
        }
        public void Sil(int id)
        {
            _kitapDal.KitapSil(id);
        }
        public void Guncelle(Kitap k)
        {
            if (k.Id <= 0) throw new Exception("Güncellenecek kitap bulunamadı (ID hatalı)!");
            if (string.IsNullOrWhiteSpace(k.Ad)) throw new Exception("Kitap adı boş olamaz!");

            _kitapDal.KitapGuncelle(k);
        }
    }
}  