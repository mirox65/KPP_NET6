using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Models
{
    public class PartnerModel
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int KorisnikId { get; set; } = EditClass.IdKorisnika;
        public DateTime Azurirano { get; set; } = DateTime.Now.Date;
    }
}
