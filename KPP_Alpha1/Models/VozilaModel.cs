using KPP_Alpha1.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Models
{
    internal class VozilaModel
    {
        public int Id { get; set; }
        public string Proizvodac { get; set; }
        public string Model { get; set; }
        public string Opis { get; set; }
        public string BrSasije { get; set; }
        public string RegOznaka { get; set; }
        public string BrUgovora { get; set; }
        public string Status { get; set; }
        public string Napomena { get; set; }
        public int KorisnikId { get; set; } = LoginHelper.StaticId;
        public DateTime DateEdited { get; set; } = DateTime.Now.Date;
    }
}
