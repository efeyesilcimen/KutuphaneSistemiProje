using EfeKutuphane.DAL;
using System.Data;

namespace EfeKutuphane.Services
{
    public class KategoriService
    {
        KategoriDAL _katDal = new KategoriDAL();
        public DataTable Listele() => _katDal.KategorileriGetir();
    }
}