using System;
using System.Windows.Forms;
using EfeKutuphane.Services;

namespace EfeKutuphane
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                LoginService loginServis = new LoginService();

                string kullaniciAd = txtKullaniciAd.Text;
                string sifre = txtSifre.Text;

                string rol = loginServis.RolKontrol(kullaniciAd, sifre);
                int kullaniciId = loginServis.KullaniciIdGetir(kullaniciAd, sifre);

                if (rol != null)
                {
                    if (rol == "uye")
                    {
                        UyePanel up = new UyePanel(kullaniciId);
                        up.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form1 anaForm = new Form1();
                        anaForm.girisYapanRol = rol;

                        if (rol == "personel")
                        {
                            if (anaForm.btnUyeSil != null) anaForm.btnUyeSil.Visible = false;
                            if (anaForm.btnSil != null) anaForm.btnSil.Visible = false;

                            MessageBox.Show("Personel girişi: Silme yetkileriniz kısıtlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        anaForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
