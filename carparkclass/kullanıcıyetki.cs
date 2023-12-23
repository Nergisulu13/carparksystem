using WinFormsApp;

namespace carparkclass
{
    public class kullanıcıyetki : yetki, IYetki
    {
        public kullanıcıyetki()
        {
            this.BinekAracUcret = 100;
            this.SUVAracUcret = 150;
            this.TicariAracUcret = 200;

            this.BirİleBesSaat = 20;
            this.BesİleOnSSaat = 30;
            this.OnSaatuzeri = 50;
        }

        public int tc { get; set; }
        public float OgrIndirim = 15;
        public float YeniUcret { get; set; }

        public void Belirlendi()
        {
            base.Belirlendi();
        }

        public void Guncelle()
        {
            base.Guncelle();
        }
    }
}
