using System;
using System.Drawing;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    class EditClass
    {
        /// <summary>
        /// EditClasss služi za poruke korisnicima.
        /// Metode za provjeru textBoxova koji su prazni
        /// i uloge korisnika aplikacije.
        /// </summary>

        // STATIC čuvanje korisničkog podatka
        // jako bitna varijabla UlogaKorisnika koristi se kroz aplikaciju
        // za ograničavanje pristupa elementima ukoliko korisnik nije administrator
        public static string KorisnikAplikacije { get; set; }
        public static int IdKorisnika { get; set; }
        public static string UlogaKorisnika { get; set; }

        // Stringovi s kojima se rade poruke
        public string PraznaCelija = "Ćelije ne smiju biti prazne!";
        public string CelijaNazivUpozorenje = "Upozorenje";
        public string CelijaNazivObavjest = "Obavjest aplikacije";
        public string IzmjenaError = "Izmjena nije izvršena!";
        public string UnosError = "Unos nije napravljen!";
        public string IdError = "ID stavke nije pronađen!\n\nProvjeri polja na greške u malim i velikim slovima.\n\n" +
            "Ako željeni naziv ili korisnik nije ponuđen dodaj ga u bazu.";
        public string ExError = "Dogodila se greška:\n\n";

        #region USER MESSAGES
        // Poruke korisniku
        // Prazna ćelija upozorava da ista ne smije biti prazna
        internal void PorukaPraznaCelija()
        {
            MessageBox.Show(PraznaCelija, CelijaNazivUpozorenje);
        }
        // INSERT u bazu nije napravljen
        internal void MessageDBErrorInsert()
        {
            MessageBox.Show(UnosError, CelijaNazivUpozorenje);
        }
        // UPDATE nije napravljen
        internal void MessageDBErrorUpdate()
        {
            MessageBox.Show(IzmjenaError, CelijaNazivUpozorenje);
        }
        // EX error poruka koristi se u try-catch bloku
        internal void MessageException(Exception ex)
        {
            MessageBox.Show(ExError + ex.Message + $"\n\n Stack Trace:" + ex.StackTrace, CelijaNazivUpozorenje);
        }
        // Dictionary KEY ako nije nađen koji se koristi kao forigne key u tablicama
        internal void MessageErrorKeyMissing()
        {
            MessageBox.Show(IdError, CelijaNazivUpozorenje);
        }
        // Poruka korisniku da nije pronađen u aplikaciji kod logiranja ili da nema prava pristupa
        internal void MessageLoginFaild()
        {
            MessageBox.Show("Korisničko ime ili lozinka nisu točni. Pokušaj ponovno!\n" +
                        "Ili nisi ovlašten za korištenje aplikacije.", CelijaNazivUpozorenje);
        }       

        #endregion

        #region METODE ZA PROVJERU PRAZNIH ČELIJA
        // Metoda za promjenu pozdaniske boje da se ukaže korisniku koji textBox mora biti ispunjen
        internal void PrazneCelije(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                textBox.BackColor = Color.LightPink;
            }
            else
            {
                textBox.BackColor = Color.White;
            }
        }
        // Metoda za prvjeru prazne čelije koristi se prije metode za promjenu boje i svaki put kad se žele vrati boja u bijelo,
        // ako je uvijet zadovoljen
        internal bool NullOrWhite(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text);
        }
        #endregion
    }
}
