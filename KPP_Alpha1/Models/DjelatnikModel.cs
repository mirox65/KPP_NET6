using KPP_Alpha1.HelperClasses;
using System;

namespace KPP_Alpha1.Models
{
    public class DjelatnikModel
    {
        public int Id { get; set; }
        public int PerNum { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int OdjelId { get; set; }
        public string Aktivan { get; set; }
        public int KorisnikId { get; set; } = LoginHelper.StaticId;
        public DateTime Azurirano { get; set; } = DateTime.Now.Date;
    }
}
