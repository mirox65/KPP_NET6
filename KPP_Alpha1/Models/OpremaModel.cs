using KPP_Alpha1.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Models
{
    internal class OpremaModel
    {

        public int Id { get; set; }
        public string Naziv { get; set; } 
        public string SerijskiBroj { get; set; }
        public string InventarniBroj { get; set; } = "Novo";
        public string StatusOpreme { get; set; }
        public DateTime DatumKupovine { get; set; }
        public int VijekTrajanja { get; set; }
        public DateTime DatumZamjene { get; set; }
        public int KorisnikId { get; set; } = LoginHelper.StaticId;
        public DateTime DateEdited { get; set; } = DateTime.Now.Date;
    }
}
