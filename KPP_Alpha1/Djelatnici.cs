using KPP_Alpha1.Controller;
using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class FormDjelatnici : Form
    {
        /// <summary>
        /// Djelatnici forma i klase koje se bave unosom i izmjenom djelatnika u bazu
        /// Primarne pomoćne klase su istoimene Model i Controller klase
        /// Skenudarne pomoćne klase su DbClass i EditClass
        /// </summary>

        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();
        readonly DjelatnikController controller = new DjelatnikController();

        // Riječnik koji učitava djelatnike te se koristi kod pronažaenja stranog ključa prije unosa u bazu
        public Dictionary<int, string> odjeliDict = new Dictionary<int, string>();

        // Nakon incijalizacije instaciramo riječnike i kolekcije za daljnju obradu
        public FormDjelatnici()
        {
            InitializeComponent();
            Clear();
            odjeliDict = db.DictIntString("naziv", "odjeli");
            CollectionOdjeli();
        }
        // Metoda za kolekciju koja se veže za txtBox Odjeli za suggest and append
        private void CollectionOdjeli()
        {
            string DbAc = "SELECT * FROM odjeli;";
            AutoCompleteStringCollection AcOdjel = db.AutoComplete(DbAc, "naziv");
            txtOdjelId.AutoCompleteCustomSource = AcOdjel;
        }
        // Učitavanje Forme, koja poziva metodu DtUpdate
        private void Djelatnici_Load(object sender, EventArgs e)
        {
            DTUpdate("DA");
        }
        // Metoda koja isčitava podatke iz baze i prikazuje u DataGridView-u
        private void DTUpdate(string aktivan)
        {
            string Dbs = "SELECT d.id AS ID, d.pn AS PN, d.ime AS Ime, d.prezime AS Prezime, o.naziv AS Odjel, " +
                "d.aktivan AS Aktivan, [do.ime]&' '&[do.prezime] AS Korisnik, d.azurirano AS Ažurirano " +
                "FROM ((Djelatnici AS d " +
                "LEFT JOIN odjeli AS o ON o.id = d.idodjel) " +
                "LEFT JOIN korisnici AS k ON k.id = d.idkorisnika) " +
                "LEFT JOIN djelatnici AS do ON do.id=k.djelatnikid " +
                $"WHERE d.aktivan='{ aktivan }' " +
                "ORDER BY d.prezime ASC;";
            DataTable dt = db.Select(Dbs);
            Dgv.DataSource = dt;
        }
        // Brisanje svih polja i fokus na početno polje
        private void Clear()
        {
            txtPN.Clear();
            txt_ime.Clear();
            txt_prezime.Clear();
            txtOdjelId.Clear();
            txt_id.Clear();
            txt_pretrazivanje.Clear();
            ComBoxFilter.SelectedIndex = 0;
            ComBoxAktivan.SelectedIndex = 0;
            txtPN.Focus();
        }
        // Provjera je li neka od ćelija prazna. Poziva generičku metodu u edit klasi koju koriste sve forme
        private void PrazneCelije()
        {
            edit.BojaPozadineZaPrazneCeliji(txtPN);
            edit.BojaPozadineZaPrazneCeliji(txt_ime);
            edit.BojaPozadineZaPrazneCeliji(txt_prezime);
            edit.BojaPozadineZaPrazneCeliji(txtOdjelId);
        }
        // BTN za INSERT podataka u bazu ova metoda poziva više metoda da bi uspješno izvršila zadatak
        // Provjera praznih ćelija, javlja poruke korisnicma (najbliža je korisniku)
        // Postavlja vrijednosti varijabli u modelu, i poziva generičku metodu za unos podatka
        private void Btn_dodaj_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txtPN) | edit.NullOrWhite(txt_ime) |
               edit.NullOrWhite(txt_prezime) | edit.NullOrWhite(txtOdjelId))
            {
                PrazneCelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var djelatnik = SetProperties();
                var provjera = ProvjeraKljučeva(djelatnik);
                if (provjera is true)
                {
                    try
                    {
                        bool sucess = controller.Insert(djelatnik);
                        if (sucess is true)
                        {
                            DTUpdate("DA");
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
        private void Btn_uredi_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txtPN) | edit.NullOrWhite(txt_ime) |
               edit.NullOrWhite(txt_prezime) | edit.NullOrWhite(txtOdjelId))
            {
                PrazneCelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var djelatnik = SetProperties();
                var provjera = ProvjeraKljučeva(djelatnik);
                if (provjera is true)
                {
                    try
                    {
                        bool sucess = controller.Update(djelatnik);
                        if (sucess is true)
                        {
                            DTUpdate("DA");
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
        // Metoda provjerava da je strani ključ veći od 0 prije unosa
        private bool ProvjeraKljučeva(DjelatnikModel djelatnik)
        {
            bool provjera = false;
            if (djelatnik.OdjelId > 0)
            {
                provjera = true;
            }
            return provjera;
        }
        // Metoda postavljanja varijabili koja se poziva prije unosa i izmjne podatka
        private DjelatnikModel SetProperties()
        {
            DjelatnikModel djelatnik = new DjelatnikModel();
            if (!edit.NullOrWhite(txt_id))
            {
                djelatnik.Id = Convert.ToInt32(txt_id.Text.Trim());
            }
            djelatnik.PerNum = Convert.ToInt32(txtPN.Text.Trim());
            djelatnik.Ime = txt_ime.Text.Trim();
            djelatnik.Prezime = txt_prezime.Text.Trim();
            djelatnik.OdjelId = odjeliDict.FirstOrDefault(o => o.Value == txtOdjelId.Text.Trim()).Key;
            djelatnik.Aktivan = ComBoxAktivan.Text.Trim();
            return djelatnik;
        }
        // Učitavanje podataka iz tablice za prikaz prije editiranja (izmjene)
        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = Dgv.Rows[RowIndex].Cells[0].Value.ToString();
            txtPN.Text = Dgv.Rows[RowIndex].Cells[1].Value.ToString();
            txt_ime.Text = Dgv.Rows[RowIndex].Cells[2].Value.ToString();
            txt_prezime.Text = Dgv.Rows[RowIndex].Cells[3].Value.ToString();
            txtOdjelId.Text = Dgv.Rows[RowIndex].Cells[4].Value.ToString();
            ComBoxAktivan.Text = Dgv.Rows[RowIndex].Cells[5].Value.ToString();
        }
        // Metoda za pretraživanje podataka unesenih u bazu
        private void txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("Ime LIKE '%{0}%' OR prezime LIKE '%{0}%' OR " +
                    "Odjel LIKE '%{0}%' OR Korisnik LIKE '%{0}%'", txt_pretrazivanje.Text.Trim());
                if (Dgv.Rows[0].Cells[0].Value is null)
                {
                    return;
                }
            }
            catch(Exception ex) { edit.MessageException(ex); }
        }
        // Izbornik gumb za Insert/unos podataka kratica F4
        private void dodajNoviUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnInsert.PerformClick();
        }
        // Izbornik gumb za Update/izmjenu podataka kratica F3
        private void spremiIzmjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }
        // Izbornik gumb za brisanje teksta iz textBoxova kratica F1
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ComBoxFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(ComBoxFilter.Text == "Aktivni djelatnici")
            {
                DTUpdate("DA");
            }
            else
            {
                DTUpdate("NE");
            }
        }
    }
}
