using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp;

namespace carparkclass
{
    public class yetkiliyetki : yetki, IYetki
    {
        public yetkiliyetki(float BinekUcret, float SuvUcret, float TicariUcret)
        {
            BinekUcret = this.BinekAracUcret;
            SuvUcret = this.SUVAracUcret;
            TicariUcret = this.TicariAracUcret;
        }

        public string MesajYazdir()
        {
            return "Araçlara Ücretler Atanmıştır.";
        }

        public int BinekAracSayisi { get; set; }
        public int SuvAracSayisi { get; set; }
        public int TicariAracSayisi { get; set; }
        public int BosParkalani { get; set; }
        public int ToplamAracSayisi { get; set; }

        public void Belirlendi()
        {
            base.Belirlendi();
            // Belirlendi metodu özelleştirilebilir işlemleri içerir.
        }

        public void Guncelle()
        {
            base.Guncelle();
            // Guncelle metodu özelleştirilebilir işlemleri içerir.
        }
    }
}

