using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carparkclass
{
    public class kullanıcıgiris
    {
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }

        public kullanıcıgiris(string kullaniciAdi, string kullaniciSifre)
        {
            KullaniciAdi = (kullaniciAdi == "kullanıcı1" || kullaniciAdi == "kullanıcı2" || kullaniciAdi == "kullanıcı3") ? kullaniciAdi : "kullanıcı1";
            KullaniciSifre = (kullaniciSifre == "kullanıcı1" || kullaniciSifre == "kullanıcı2" || kullaniciSifre == "kullanıcı3") ? kullaniciSifre : "kullanıcı1";
        }

        public bool KullaniciGirisKontrol(string kullaniciAdi, string kullaniciSifre)
        {
            return (kullaniciAdi == "kullanıcı1" && kullaniciSifre == "kullanıcı1") ||
                   (kullaniciAdi == "kullanıcı2" && kullaniciSifre == "kullanıcı2") ||
                   (kullaniciAdi == "kullanıcı3" && kullaniciSifre == "kullanıcı3");
        }
    }
}
