namespace carparkclass
{
    public abstract class Arac
    {
        public string isim { get; set; }

        public abstract string Calis();
       
    }

    public class SUV : Arac
    {
        public SUV()
        {
            //isim = "suv";
        }

        public override string Calis()
        {
            return "Otopark girişi için suv seçilmiştir.";
        }
    }

    public class BinekArac : Arac
    {
        public BinekArac()
        {
            //isim = "binek araç";
        }

        public override string Calis()
        {
            return "Otopark girişi için binek araç seçilmiştir.";
        }
    }

    public class TicariArac : Arac
    {
        public TicariArac()
        {
            //isim = "ticari araç";
        }

        public override string Calis()
        {
            return "Otopark girişi için ticari araç seçilmiştir.";   
        }
    }
}

