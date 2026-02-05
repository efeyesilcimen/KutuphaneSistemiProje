using EfeKutuphane.DAL;
using System.Data;

namespace EfeKutuphane.Services
{
    public class OduncService
    {
        OduncDAL _oduncDal = new OduncDAL();
        public DataTable HepsiniGetir() => _oduncDal.TumOduncleriGetir();
        public bool OduncVer(int uId, int kId) => _oduncDal.KitapOduncVer(uId, kId);
        public bool IadeAl(int oId, int kId) => _oduncDal.KitapIadeAl(oId, kId);
        public DataTable AylikIstatistikRaporu()
        {
            return _oduncDal.AylikOduncIstatistikleri();
        }
    }
}