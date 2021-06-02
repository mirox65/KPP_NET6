using System;

namespace KPP_Alpha1.Models
{
    class PoslaneModel
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int PosiljateljId { get; set; }
        public int DjelanikId { get; set; }
        public string Naziv { get; set; }
        public string Napomena { get; set; }
        public int PartnerId { get; set; }
        public int KorisnikId { get; set; } = EditClass.IdKorisnika;
        public DateTime Azurirano { get; set; } = DateTime.Now.Date;
    }
}
