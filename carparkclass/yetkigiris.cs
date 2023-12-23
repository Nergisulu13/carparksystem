using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carparkclass
{
    public class yetkigiris
    {
        public string YetkiliAdi { get; set; }
        public string YetkiliSifre { get; set; }
      
                public yetkigiris(string yAdi, string ySifre)
                {
                    YetkiliAdi = (yAdi == "yetkili1" || yAdi == "yetkili2" || yAdi == "yetkili3") ? yAdi : "yetkili1";
                    YetkiliSifre = (ySifre == "yetkili1" || ySifre == "yetkili2" || ySifre == "yetkili3") ? ySifre : "yetkili1";
                }

                public bool YetkiliGirisKontrol(string yAdi, string ySifre)
                {
                    return (yAdi == "yetkili1" && ySifre == "yetkili1") ||
                           (yAdi == "yetkili2" && ySifre == "yetkili2") ||
                           (yAdi == "yetkili3" && ySifre == "yetkili3");

                }

            
        
    }
}


