using KPP_Alpha1.HelperClasses;
using System;

namespace KPP_Alpha1.Models
{
    class MjestoModel
    {
        public int Id { get; set; }
        public string Ptt { get; set; }
        public string Mjesto { get; set; }
        public int IdZupanije { get; set; }
        public string Status { get; set; }
        public int KorisnikId { get; set; } = LoginHelper.StaticId;
        public DateTime Azurirano { get; set; } = DateTime.Now.Date;
    }
}
