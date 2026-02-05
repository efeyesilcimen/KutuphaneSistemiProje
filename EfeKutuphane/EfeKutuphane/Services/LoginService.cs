using EfeKutuphane.DAL;

namespace EfeKutuphane.Services
{
    public class LoginService
    {
        LoginDAL _loginDal = new LoginDAL();
        public string RolKontrol(string ad, string sifre)
        {
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(sifre))
                throw new System.Exception("Kullanıcı adı ve şifre zorunludur!");

            return _loginDal.GirisYapVeRolGetir(ad, sifre);
        }
        public int KullaniciIdGetir(string ad, string sifre)
        {
            return _loginDal.GirisYapanIdGetir(ad, sifre);
        }
    }
}

