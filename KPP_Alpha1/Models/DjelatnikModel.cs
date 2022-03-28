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
        public string Oib { get; set; }
        public int OdjelId { get; set; }

        public DateTime DatZaposlen { get; set; }
        public DateTime DatOtkaz { get; set; }
        public string Status { get; set; }
        public int KorisnikId { get; set; } = LoginHelper.StaticId;
        public DateTime Azurirano { get; set; } = DateTime.Now.Date;
    }
}
