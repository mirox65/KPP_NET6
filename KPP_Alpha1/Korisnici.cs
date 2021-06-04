using KPP_Alpha1.Controller;
using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class FormKorisnici : Form
    {
        /// <summary>
        /// Djelatnici forma i klase koje se bave unosom i izmjenom djelatnika u bazu
        /// Primarne pomoćne klase su istoimene Model i Controller klase
        /// Skenudarne pomoćne klase su DbClass i EditClass
        /// </summary>

        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();
        readonly KorisnikController controller = new KorisnikController();

        // Riječnik koji učitava djelatnike te se koristi kod pronažaenja stranog ključa prije unosa u bazu
        public Dictionary<int, string> djelatniciDict = new Dictionary<int, string>();
        // Bool varijabla koja određuje da korisnik kod unosa mora imati password zadan za novog korisnika
        private bool EditPassword { get; set; } = false;

        // Nakon incijalizacije instaciramo riječnike i kolekcije za daljnju obradu
        public FormKorisnici()
        {
            InitializeComponent();
            Clear();
            djelatniciDict = db.DictFill("ime", "prezime", "djelatnici");
            CollectionDjelatnici();
        }
        // Metoda za kolekciju koja se veže za txtBox Djelatnici za suggest and append
        private void CollectionDjelatnici()
        {
            string DbAc = "SELECT * FROM djelatnici";
            AutoCompleteStringCollection djelatniciCollection = db.AutoComplete(DbAc, "ime", "prezime");
            txt_prezime.AutoCompleteCustomSource = djelatniciCollection;
        }
        // Metoda koja isčitava podatke iz baze i prikazuje u DataGridView-u
        private void DTUpdate()
        {
            string Dbs = "SELECT k.id AS ID, [d.ime]&' '&[d.prezime] AS Djelatnik, k.korisnickoIme AS KorIme, " +
                "k.uloga AS Uloga, k.aktivan AS Aktivan, [da.ime]&' '&[da.prezime] AS Korisnik, k.azurirano AS Ažurirano " +
                "FROM ((korisnici AS k " +
                "LEFT JOIN djelatnici AS d ON d.id=k.djelatnikid) " +
                "LEFT JOIN korisnici AS ka ON ka.id=k.korisnikid) " +
                "LEFT JOIN djelatnici AS da ON da.id=ka.djelatnikid " +
                "ORDER BY k.id ASC;";
            DataTable dt = db.Select(Dbs);
            Dgv.DataSource = dt;
        }
        // Brisanje svih polja i fokus na početno polje
        private void Clear()
        {
            txt_id.Clear();
            txt_prezime.Clear();
            txt_korIme.Clear();
            txt_lozinka.Clear();
            cmb_uloga.SelectedIndex = 0;
            ComBoxAktivan.SelectedIndex = 0;
            txt_pretrazivanje.Clear();
            txt_prezime.Focus();
        }
        // Učitavanje Forme, koja poziva metodu DtUpdate
        private void form_Korisnici_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }
        // Metoda za hesh-anje passworda koji se sprema u bazu kodiran zbog sigurnosti
        public string NapraviMD5(string Lozinka)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Lozinka));
            byte[] rezultat = md5.Hash;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < rezultat.Length; i++)
            {
                sb.Append(rezultat[i].ToString("x2"));
            }
            return sb.ToString();
        }
        // BTN za INSERT podataka u bazu ova metoda poziva više metoda da bi uspješno izvršila zadatak
        // Provjera praznih ćelija, javlja poruke korisnicma (najbliža je korisniku)
        // Postavlja vrijednosti varijabli u modelu, i poziva generičku metodu za unos podatka
        private void lbl_dodaj_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txt_prezime) | edit.NullOrWhite(txt_korIme) | edit.NullOrWhite(txt_lozinka))
            {
                EditPassword = true;
                PrazneCelije();
            }
            else
            {
                EditPassword = true;
                PrazneCelije();
                var korisnik = SetProperties();
                var provjera = ProvjeraKljučeva(korisnik);
                if (provjera is true)
                {
                    bool success = controller.Insert(korisnik);
                    try
                    {
                        if (success is true)
                        {
                            DTUpdate();
                            Clear();
                        }
                        else
                        {
                            edit.MessageDBErrorInsert();
                        }
                    }
                    catch (Exception ex) { edit.MessageException(ex); }
                }
                else
                {
                    edit.MessageErrorKeyMissing();
                }
            }
            EditPassword = false;
        }
        // BTN za izmjenu podataka radi sve što i unos metoda osim koraka pozivanja generičke metode za update podataka u bazi
        private void Lbl_uredi_Click(object sender, EventArgs e)
        {
            bool success; // lokalna varijabla za provjeru izmjene koja se koristi jedno ovdije zbog passworda
            if (edit.NullOrWhite(txt_prezime) | edit.NullOrWhite(txt_korIme))
            {
                PrazneCelije();
            }
            else
            {
                PrazneCelije();
                var korisnik = SetProperties();
                var provjera = ProvjeraKljučeva(korisnik);
                if (provjera is true)
                {
                    if (edit.NullOrWhite(txt_lozinka))
                    {
                        success = controller.Edit(korisnik);
                    }
                    else
                    {
                        success = controller.EditWithPassword(korisnik);
                    }
                    try
                    {
                        if (success is true)
                        {
                            DTUpdate();
                            Clear();
                        }
                        else
                        {
                            edit.MessageDBErrorUpdate();
                        }
                    }
                    catch (Exception ex) { edit.MessageException(ex); }
                }
                else
                {
                    edit.MessageErrorKeyMissing();
                }
            }
        }
        // Metoda provjerava da je strani ključ veći od 0 prije unosa
        private bool ProvjeraKljučeva(KorisnikModel korisnik)
        {
            bool provjera = false;
            if(korisnik.DjelatnikId > 0 | korisnik.KorisnikId > 0)
            {
                provjera = true;
            }
            return provjera;
        }
        // Metoda postavljanja varijabili koja se poziva prije unosa i izmjne podatka
        private KorisnikModel SetProperties()
        {
            KorisnikModel korisnik = new KorisnikModel();
            if (!edit.NullOrWhite(txt_id) | !edit.NullOrWhite(txt_lozinka))
            {
                korisnik.Id = int.Parse(txt_id.Text.Trim());
                korisnik.Lozinka = NapraviMD5(txt_lozinka.Text);

            }
            korisnik.DjelatnikId = djelatniciDict.FirstOrDefault(d => d.Value == txt_prezime.Text.Trim()).Key;
            korisnik.KorisnickoIme = txt_korIme.Text.Trim();
            korisnik.Uloga = cmb_uloga.Text;
            korisnik.Aktivan = ComBoxAktivan.Text;
            return korisnik;
        }
        // Provjera je li neka od ćelija prazna. Poziva generičku metodu u edit klasi koju koriste sve forme
        private void PrazneCelije()
        {
            edit.PrazneCelije(txt_prezime);
            edit.PrazneCelije(txt_korIme);
            if (EditPassword is true)
            {
                edit.PrazneCelije(txt_lozinka);
            }
        }
        // Učitavanje podataka iz tablice za prikaz prije editiranja (izmjene)
        private void Dgv_korisnik_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = Dgv.Rows[RowIndex].Cells[0].Value.ToString();
            txt_prezime.Text = Dgv.Rows[RowIndex].Cells[1].Value.ToString();
            txt_korIme.Text = Dgv.Rows[RowIndex].Cells[2].Value.ToString();
            cmb_uloga.Text = Dgv.Rows[RowIndex].Cells[3].Value.ToString();
            ComBoxAktivan.Text = Dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        // Metoda za pretraživanje podataka unesenih u bazu
        private void txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("djelatnik LIKE '%{0}%' OR KorIme LIKE '%{0}%' OR Uloga LIKE '%{0}%'",
                        txt_pretrazivanje.Text.Trim());
                if (Dgv.Rows[0].Cells[0].Value is null)
                {
                    return;
                }
            }
            catch (Exception ex) { edit.MessageException(ex); }
        }
        // Izbornik gumb za Insert/unos podataka kratica F4
        private void dodajNoviUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_dodaj.PerformClick();
        }
        // Izbornik gumb za Update/izmjenu podataka kratica F3
        private void spremiIzmjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_uredi.PerformClick();
        }
        // Izbornik gumb za brisanje teksta iz textBoxova kratica F1
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
