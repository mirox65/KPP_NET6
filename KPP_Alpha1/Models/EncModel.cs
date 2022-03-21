using KPP_Alpha1.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Models
{
    internal class EncModel
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Status { get; set; }
        public string Napomena { get; set; }
        public int KorisnikId { get; set; } = LoginHelper.StaticId;
        public DateTime Ažurirano { get; set; } = DateTime.Now.Date;
    }
}
