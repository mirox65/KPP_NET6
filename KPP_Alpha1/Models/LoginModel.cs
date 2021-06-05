using System;

namespace KPP_Alpha1.Models
{
    public class LoginModel
    {
        private string lozinka;
        public int Id { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string NovaLozinka { get; set; }
        public string PonovljenaLozinka { get; set; }
        public string HashLozinke
        {
            get { return lozinka; }
            set => lozinka = LozinkaHash();
        }
        private string LozinkaHash()
        {
            throw new NotImplementedException();
        }
    }
}
