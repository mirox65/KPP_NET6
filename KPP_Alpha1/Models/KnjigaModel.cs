using System;

namespace KPP_Alpha1.Models
{
    class KnjigaModel
    {
        public int Id { get; set; }
        public DateTime DatumPrimitka { get; set; }
        public string Pismeno { get; set; }
        public string Brojcano { get; set; }
        public int PosiljateljId { get; set; }
        public DateTime Datum { get; set; }
        public int OdjelId { get; set; }
        public int KorisnikId { get; set; } = EditClass.IdKorisnika;
        public DateTime Azurirano { get; set; } = DateTime.Now.Date;
    }
}
