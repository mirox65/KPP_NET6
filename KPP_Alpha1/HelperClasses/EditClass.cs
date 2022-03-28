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

        // Stringovi s kojima se rade poruke
        public string PraznaCelija = "Ćelije ne smiju biti prazne!";
        public string CelijaNazivUpozorenje = "Upozorenje";
        public string CelijaNazivObavjest = "Obavjest";
        public string IzmjenaError = "Izmjena nije izvršena!";
        public string UnosError = "Unos nije napravljen!";
        public string IdError = "ID stavke nije pronađen!\n\nProvjeri polja na greške u malim i velikim slovima.\n\n" +
            "Ako željeni naziv ili korisnik nije ponuđen dodaj ga u bazu.";
        public string ExError = "Dogodila se greška:\n\n";

        #region SYSTEM MESSAGES TO USER
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
        internal void MessageAccessDenied()
        {
            MessageBox.Show("Korisničko ime ili lozinka nisu točni. Pokušaj ponovno!\n" +
                        "Ili nisi ovlašten za korištenje aplikacije.", CelijaNazivUpozorenje);
        }
        internal void MessagePasswordMissmatch()
        {
            MessageBox.Show("Lozinke se ne podudaraju!", CelijaNazivUpozorenje);
        }

        internal void MessagePasswordChanged()
        {
            MessageBox.Show("Lozinka je promjenjena.\n\nPrijavite se sa novom lozinkom", CelijaNazivObavjest);
        }

        internal void MessageOpremaJeZadužena()
        {
            MessageBox.Show("Oprema je već zadužena.\n\nRazduži prije zaduživanja!", CelijaNazivUpozorenje);
        }

        internal void MessagePokušajRazduživanjaNaInsert()
        {
            MessageBox.Show("Provjeri dropdown ZaRa!\n\nPokušaj razduženja opreme na Spremi novi!" +
                "\n\nSva oprema za razduživanje mora biti zadužena!", CelijaNazivUpozorenje);
        }

        internal void MessageDuplikat()
        {
            MessageBox.Show("Ova stavka već postoji u bazi!\n\nNije dopušteno imati duple unose!", CelijaNazivUpozorenje);
        }



        #endregion

        #region METODE ZA PROVJERU PRAZNIH ČELIJA
        // Metoda za promjenu pozdaniske boje da se ukaže korisniku koji textBox mora biti ispunjen
        internal void BojaPozadineZaPrazneCeliji(TextBox textBox)
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

        #region METODA ZA RESAJZANJE DGV-A
        internal void DgvColumnsResize(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        #endregion
    }
}
