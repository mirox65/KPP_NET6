namespace KPP_Alpha1.HelperClasses
{
    class LoginHelper
    {
        /// <summary>
        /// STATIC čuvanje korisničkog podatka
        // jako bitna varijabla UlogaKorisnika koristi se kroz aplikaciju
        // za ograničavanje pristupa elementima ukoliko korisnik nije administrator
        /// </summary>
        
        public static int StaticId { get; set; }
        public static string StaticKorisnickoIme { get; set; }
        public static string StaticKorisnik { get; set; }
        public static string StaticUloga { get; set; }
        public static string StaticOdjel { get; set; }
    }
}
