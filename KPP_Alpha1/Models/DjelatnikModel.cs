using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Models
{
    public class DjelatnikModel
    {
        public int Id { get; set; }
        public int PerNum { get; set; }
        public string Ime { get; set; }
        public string  Prezime { get; set; }
        public int OdjelId { get; set; }
        public int KorisnikId { get; set; } = EditClass.IdKorisnika;
        public DateTime Azurirano { get; set; } = DateTime.Now.Date;
    }
}
