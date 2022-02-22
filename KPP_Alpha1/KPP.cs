using KPP_Alpha1.Controller;
using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace KPP_Alpha1
{
    public partial class FormKPP : Form
    {
        /// <summary>
        /// Djelatnici forma i klase koje se bave unosom i izmjenom djelatnika u bazu
        /// Primarne pomoćne klase su istoimene Model i Controller klase
        /// Skenudarne pomoćne klase su DbClass i EditClass
        /// </summary>

        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();
        readonly KnjigaController controller = new KnjigaController();

        // Riječnik koji učitava djelatnike te se koristi kod pronažaenja stranog ključa prije unosa u bazu
        public Dictionary<int, string> odjeliDict = new Dictionary<int, string>();
        public Dictionary<int, string> posiljateljiDict = new Dictionary<int, string>();

        // Nakon incijalizacije instaciramo riječnike i kolekcije za daljnju obradu
        public FormKPP()
        {
            InitializeComponent();
            odjeliDict = db.DictIntString("naziv", "odjeli");
            posiljateljiDict = db.DictIntString("naziv", "posiljatelji");
            CollectionPosiljatelji();
            CollectionOdjeli();
        }
        // Metoda za kolekciju koja se veže za txtBox Pošiljatelji za suggest and append
        private void CollectionPosiljatelji()
        {
            string DbAc = "SELECT naziv FROM posiljatelji;";
            AutoCompleteStringCollection AcPosiljatelj = db.AutoComplete(DbAc, "naziv");

            txt_Posiljatelj.AutoCompleteCustomSource = AcPosiljatelj;
        }
        // Metoda za kolekciju koja se veže za txtBox Odjeli za suggest and append
        private void CollectionOdjeli()
        {
            string DbAc = "SELECT naziv FROM odjeli;";
            AutoCompleteStringCollection AcOdjel = db.AutoComplete(DbAc, "naziv");

            txt_Odjel.AutoCompleteCustomSource = AcOdjel;
        }
        // Metoda koja isčitava podatke iz baze i prikazuje u DataGridView-u
        private void DTUpdate()
        {
            string Dbs = "SELECT k.id AS ID, k.datumPrimitka AS Primljeno, k.pismeno AS Pismeno, k.brojcano AS Brojčano, " +
                "p.naziv AS Pošiljatelj, k.datum AS Poslano, o.naziv AS Odjel, [d.ime]&' '&[d.prezime] AS Korisnik, k.azurirano AS Ažurirano " +
                "FROM (((knjiga AS k " +
                "LEFT JOIN posiljatelji AS p ON p.id = k.idposiljatelj) " +
                "LEFT JOIN odjeli AS o ON o.id = k.idodjel) " +
                "LEFT JOIN korisnici AS ko ON ko.id = k.idkorisnik) " +
                "LEFT JOIN djelatnici AS d ON d.id=ko.djelatnikid " +
                "ORDER BY k.id DESC;";
            DataTable dt = db.Select(Dbs);
            Dgv.DataSource = dt;
        }
        // Učitavanje Forme, koja poziva metodu DtUpdate
        private void form_KPP_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }
        // BTN za INSERT podataka u bazu ova metoda poziva više metoda da bi uspješno izvršila zadatak
        // Provjera praznih ćelija, javlja poruke korisnicma (najbliža je korisniku)
        // Postavlja vrijednosti varijabli u modelu, i poziva generičku metodu za unos podatka
        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txt_Odjel) | edit.NullOrWhite(txt_Brojcano) |
                edit.NullOrWhite(txt_Pismeno) | edit.NullOrWhite(txt_Posiljatelj))
            {
                PrazneCelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var knjiga = SetProperties();
                var provjera = ProvjeraKljučeva(knjiga);
                if (provjera is true)
                {
                    try
                    {
                        bool success = controller.Insert(knjiga);
                        if (success == true)
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
        }
        // BTN za izmjenu podataka radi sve što i unos metoda osim koraka pozivanja generičke metode za update podataka u bazi
        private void btn_uredi_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txt_Odjel) | edit.NullOrWhite(txt_Brojcano) |
                edit.NullOrWhite(txt_Pismeno) | edit.NullOrWhite(txt_Posiljatelj))
            {
                PrazneCelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var knjiga = SetProperties();
                var provjera = ProvjeraKljučeva(knjiga);
                if(provjera is true)
                {
                    try
                    {
                        bool success = controller.Update(knjiga);
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
        private bool ProvjeraKljučeva(KnjigaModel knjiga)
        {
            bool provjera = false;
            if (knjiga.KorisnikId > 0 | knjiga.OdjelId > 0 | knjiga.PosiljateljId > 0)
            {
                provjera = true;
            }
            return provjera;
        }
        // Metoda postavljanja varijabili koja se poziva prije unosa i izmjne podatka
        private KnjigaModel SetProperties()
        {
            KnjigaModel knjiga = new KnjigaModel();
            if (!edit.NullOrWhite(txt_id))
            {
                knjiga.Id = int.Parse(txt_id.Text);
            }
            knjiga.DatumPrimitka = date_primitka.Value.Date;
            knjiga.Pismeno = txt_Pismeno.Text;
            knjiga.Brojcano = txt_Brojcano.Text;
            knjiga.PosiljateljId = posiljateljiDict.FirstOrDefault(p => p.Value == txt_Posiljatelj.Text.Trim()).Key;
            knjiga.Datum = date_datum.Value.Date;
            knjiga.OdjelId = odjeliDict.FirstOrDefault(o => o.Value == txt_Odjel.Text.Trim()).Key;
            return knjiga;
        }
        // Brisanje svih polja i fokus na početno polje
        private void Clear()
        {
            txt_Posiljatelj.Clear();
            txt_Pismeno.Clear();
            txt_Brojcano.Clear();
            txt_Odjel.Clear();
            txt_pretrazivanje.Clear();
            txt_Posiljatelj.Focus();
        }
        // Metoda za pretraživanje podataka unesenih u bazu
        private void txt_pretraži_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("pismeno LIKE '%{0}%' OR brojčano LIKE '%{0}%' OR pošiljatelj LIKE '%{0}%' OR odjel LIKE '%{0}%'",
                    txt_pretrazivanje.Text.Trim());
                if (Dgv.Rows[0].Cells[0].Value is null)
                {
                    return;
                }
            }
            catch (Exception ex) { edit.MessageException(ex); }
        }
        // Učitavanje podataka iz tablice za prikaz prije editiranja (izmjene)
        private void dgv_kpp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_id.Text = Dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            date_primitka.Text = Dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Pismeno.Text = Dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Brojcano.Text = Dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Posiljatelj.Text = Dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            date_datum.Text = Dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_Odjel.Text = Dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        // Brisanje svih polja i fokus na početno polje
        private void PrazneCelije()
        {
            edit.BojaPozadineZaPrazneCeliji(txt_Odjel);
            edit.BojaPozadineZaPrazneCeliji(txt_Posiljatelj);
            edit.BojaPozadineZaPrazneCeliji(txt_Pismeno);
            edit.BojaPozadineZaPrazneCeliji(txt_Brojcano);
        }
        // Otvaranje druge forme preko gumba plus pored polja za unos
        private void btn_search_posiljatelj_Click(object sender, EventArgs e)
        {
            var form = new FormPosiljatelji();
            form.Show();
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            this.Close();
        }
        // Otvaranje druge forme preko gumba plus pored polja za unos
        private void btn_search_odjel_Click(object sender, EventArgs e)
        {
            var form = new FormOdjeli();
            form.Show();
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            this.Close();
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
