using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carparkclass
{
    public class adminyetki:yetki
    {
        public adminyetki(float IlkSaatUcret, float IkinciSaatUcret, float UcuncuSaatUcret)
        {
            IlkSaatUcret = this.BirİleBesSaat;
            IkinciSaatUcret = this.BesİleOnSSaat;
            UcuncuSaatUcret = this.OnSaatuzeri;
        }

        public string Pazartesi()
        {
            return "Pazartesi\n50 Binek Araç\n60 SUV Araç\n40 Ticari Araç";
        }

        public string Sali()
        {
            return "Salı\n70 Binek Araç\n60 SUV Araç\n 12 Ticari Araç";
        }
        public string Carsamba()
        {
            return "Çarşamba\n50 Binek Araç\n45 SUV Araç\n48 Ticari Araç";
        }

        public string Persembe()
        {
            return "Perşembe\n 96 Binek Araç\n50 SUV Araç\n15 Ticari Araç";
        }

        public string Cuma()
        {
            return "Cuma\n40 Binek Araç\n14 SUV Araç\n40 Ticari Araç";
        }
        public string Cumartesi()
        {
            return "Cumartesi\n50 Binek Araç\n60 SUV Araç\n40 Ticari Araç";
        }
        public string Pazar()
        {
            return "Pazar\n45 Binek Araç\n49 SUV Araç\n102 Ticari Araç";
        }


        public string MesajYazdir()
        {
            return "Otoparkın Saatlik Ücretleri belirlenmiştir.";
        }
    }
}
