using KPP_Alpha1.HelperClasses;
using System;

namespace KPP_Alpha1.Models
{
    class OdjelModel
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Status { get; set; }
        public int KorisnikId { get; set; } = LoginHelper.StaticId;
        public DateTime Azurirano { get; set; } = DateTime.Now.Date;
    }
}
