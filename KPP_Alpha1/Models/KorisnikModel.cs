using KPP_Alpha1.HelperClasses;
using System;

namespace KPP_Alpha1.Models
{
    class KorisnikModel
    {
        public int Id { get; set; }
        public int DjelatnikId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Uloga { get; set; }
        public string Aktivan { get; set; } = "DA";
        public int KorisnikId { get; set; } = LoginHelper.StaticId;
        public DateTime Azurirano { get; set; } = DateTime.Now.Date;
    }
}
