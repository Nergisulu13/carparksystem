using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp;

namespace carparkclass
{
    public class yetki : IYetki
    {
        public float AracUcret { get; set; }
        public float SaatUcret { get; set; }
        public float BinekAracUcret { get; set; }
        public float SUVAracUcret { get; set; }
        public float TicariAracUcret { get; set; }
        public float BirİleBesSaat { get; set; }
        public float BesİleOnSSaat { get; set; }
        public float OnSaatuzeri { get; set; }
        public float Otoparkucret { get; set; }

        public string Belirlendi()
        {
           return "Saat seçimi yaptınız,gün seçimine geçebilirsiniz. ";
        }
    }
}
