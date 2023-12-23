namespace carparkclass
{
    public class admingiris
    {
        public string AdminAdi { get; set; }
        public string AdminSifre { get; set; }

        public admingiris(string aAdi, string aSifre)
        {
            AdminAdi = (aAdi == "admin1" || aAdi == "admin2" || aAdi == "admin3") ? aAdi : "admin1";
            AdminSifre = (aSifre == "admin1" || aSifre == "admin2" || aSifre == "admin3") ? aSifre : "admin1";
        }

        public bool AdminGirisKontrol(string aAdi, string aSifre)
        {
            return (aAdi == "admin1" && aSifre == "admin1") ||
                   (aAdi == "admin2" && aSifre == "admin2") ||
                   (aAdi == "admin3" && aSifre == "admin3");

        }

    }
}