using KPP_Alpha1.Controller;
using KPP_Alpha1.HelperClasses;
using System;

namespace KPP_Alpha1.Models
{
    public class LoginModel
    {
        readonly KorisnikController korisnikController = new KorisnikController();

        private string lozinka;
        public int Id { get; set; } = LoginHelper.StaticId;
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string NovaLozinka { get; set; }
        public string PonovljenaLozinka { get; set; }
        public string HashedLozinka { get; set; }

        internal string HashLozinke()
        {
            return korisnikController.HashPasswordForCheck(KorisnickoIme, Lozinka);
        }
    }
}
