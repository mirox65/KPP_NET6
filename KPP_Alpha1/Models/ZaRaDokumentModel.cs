using KPP_Alpha1.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Models
{
    internal class ZaRaDokumentModel
    {
        public string Djelatnik { get; set; }
        public string TipDokumenta { get; set; }
        public string Korisnik { get; set; } = LoginHelper.StaticKorisnik;
        public DateTime Datum { get; set; }
        public string Filter { get; set; }
        public string PredaoPreuzeo { get; set; }
        public string ZaduzioRazduzio { get; set; }
    }
}
