using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carparkclass
{
    public class kullanıcıuyeol:kullanıcıgiris
    {
        public kullanıcıuyeol(string kullaniciAdi, string kullaniciSifre) : base(kullaniciAdi, kullaniciSifre)
        {
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
