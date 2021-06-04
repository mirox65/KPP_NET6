using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    /// <summary>
    /// Login forma služi za provjeru prava pristupa korisniku.
    /// Osim ispravne lozinke, klasa postavalja korisničkiId u globalnu vbarijablu, 
    /// kao i ime i prezime za prikaze unutra prozora za vrijeme rada.
    /// I jako bitno Ulogu Korisnika koju možemo koristi kroz aplikaciju za davanje prava pristupa elementima
    /// </summary>

    public partial class FormLogin : Form
    {
        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();
        readonly FormKorisnici korisnici = new FormKorisnici();

        public FormLogin()
        {
            InitializeComponent();
        }
        // BTN prijava zaduen za provjeru ima li korisnik sa svojim korisničkim imenom i lozinkom pravo pristupa
        // Baza sadrži i neaktivne korisnike koji su označeni sa NE i time korisnicima je isto ulaz zabranjen
        // Poziva metodu za isčitavanje podatka iz baze i postavljanje globalnih statičkih varijabli u Edit klasi
        private void Btn_prijava_Click_1(object sender, EventArgs e)
        {
            var dbs = "SELECT k.id, [d.ime]&' '&[d.prezime] AS Korisnik, k.korisnickoIme, k.uloga " +
                "FROM (korisnici AS k " +
                "LEFT JOIN djelatnici AS d ON d.id=k.djelatnikId) " +
                "WHERE k.korisnickoIme=? AND k.lozinka=? AND aktivan='DA';";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(dbs, conn);
            cmd.Parameters.AddWithValue("@korsinickoIme", txt_korIme.Text.Trim());
            cmd.Parameters.AddWithValue("@lozinka", korisnici.NapraviMD5(txt_lozinka.Text.Trim()));
            try
            {
                conn.Open();
                var korisnik = cmd.ExecuteReader();
                if (korisnik.HasRows)
                {
                    SetProperties(korisnik);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    edit.MessageLoginFaild();
                    Clear();
                }
            }
            catch (Exception ex) { edit.MessageException(ex); }
            finally
            {
                conn.Close();
            }
        }
        // Metoda postavalj globalne statiče varijable koje se koriste za vrije sesije
        private void SetProperties(OleDbDataReader korisnik)
        {
            while (korisnik.Read())
            {
                if (txt_korIme.Text == korisnik.GetValue(2).ToString())
                {
                    EditClass.IdKorisnika = int.Parse(korisnik.GetValue(0).ToString());
                    EditClass.KorisnikAplikacije = korisnik.GetValue(1).ToString();
                    EditClass.UlogaKorisnika = korisnik.GetValue(3).ToString();
                }
            }
            korisnik.Close();
        }
        // Brisanje polja i fokus na polje lozinka
        private void Clear()
        {
            txt_lozinka.Clear();
            txt_lozinka.Focus();
        }
        // BTN zadužen za izlaz iz apiakcije i zatvaranje ako se korisnik predomislio
        private void Btn_izlaz_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Enterom iz polja password može se isto "kliknuti" na Prijavu
        private void Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_prijava.PerformClick();
            }
        }
    }
}
