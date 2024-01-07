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
        }
        public override string Calis()
        {
            return "Otopark girişi için ticari araç seçilmiştir.";   
        }
    }
}

