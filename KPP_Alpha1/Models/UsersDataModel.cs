using KPP_Alpha1.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Models
{
    internal class UsersDataModel
    {
        public int Id { get; set; }
        public int DjelatnikId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int KorisnikId { get; set; } = LoginHelper.StaticId;
        public DateTime Ažurirano { get; set; } = DateTime.Now.Date;
    }
}
