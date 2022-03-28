using KPP_Alpha1.Controller;
using KPP_Alpha1.HelperClasses;
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

        readonly DbClass db = new();
        readonly EditClass edit = new();
        readonly DictionaryHelper dictionary = new();
        readonly AutocompleteHelper autocomplete = new();
        readonly DjelatnikController controller = new();

        // Riječnik koji učitava djelatnike te se koristi kod pronažaenja stranog ključa prije unosa u bazu
        public Dictionary<int, string> odjeliDict = new();

        // Nakon incijalizacije instaciramo riječnike i kolekcije za daljnju obradu
        public FormDjelatnici()
        {
            InitializeComponent();
            Clear();
            odjeliDict = dictionary.DictIntString("naziv", "odjeli");
            CollectionOdjeli();
        }
        // Metoda za kolekciju koja se veže za txtBox Odjeli za suggest and append
        private void CollectionOdjeli()
        {
            string DbAc = "SELECT * FROM odjeli;";
            AutoCompleteStringCollection AcOdjel = autocomplete.AutoComplete(DbAc, "naziv");
            Txt_OdjelId.AutoCompleteCustomSource = AcOdjel;
        }
        // Učitavanje Forme, koja poziva metodu DtUpdate
        private void Djelatnici_Load(object sender, EventArgs e)
        {
            DTUpdate(ComBoxFilter.Text);
        }
        // Metoda koja isčitava podatke iz baze i prikazuje u DataGridView-u
        private void DTUpdate(string filter)
        {
            string Dbs = "SELECT d.id AS ID, d.pn AS PN, d.ime AS Ime, d.prezime AS Prezime, d.oib AS Oib, o.naziv AS Odjel, " +
                "d.datZaposlen AS Zaposlen, d.datOtkaz AS Otkaz, d.status AS Status, [do.ime]&' '&[do.prezime] AS Korisnik, " +
                "d.azurirano AS Ažurirano " +
                "FROM ((Djelatnici AS d " +
                "LEFT JOIN odjeli AS o ON o.id = d.idodjel) " +
                "LEFT JOIN korisnici AS k ON k.id = d.idkorisnika) " +
                "LEFT JOIN djelatnici AS do ON do.id=k.djelatnikid " +
                $"WHERE d.status='{ filter }' " +
                "ORDER BY d.prezime ASC;";
            DataTable dt = db.Select(Dbs);
            Dgv.DataSource = dt;
            edit.DgvColumnsResize(Dgv);
        }
        // Brisanje svih polja i fokus na početno polje
        private void Clear()
        {
            Txt_Pn.Clear();
            Txt_Ime.Clear();
            Txt_Prezime.Clear();
            Txt_OdjelId.Clear();
            Txt_Oib.Clear();
            Dtp_Otkaz.Value = DateTime.Now.Date;
            Dtp_Zaposlen.Value = DateTime.Now.Date;
            Lbl_Id.Text = string.Empty;
            txt_pretrazivanje.Clear();
            ComBoxFilter.SelectedIndex = 0;
            ComBoxStatus.SelectedIndex = 0;
            CheckBoxOtkaz.Checked = false;
            Txt_Pn.Focus();
        }
        // Provjera je li neka od ćelija prazna. Poziva generičku metodu u edit klasi koju koriste sve forme
        private void PrazneCelije()
        {
            edit.BojaPozadineZaPrazneCeliji(Txt_Pn);
            edit.BojaPozadineZaPrazneCeliji(Txt_Ime);
            edit.BojaPozadineZaPrazneCeliji(Txt_Prezime);
            edit.BojaPozadineZaPrazneCeliji(Txt_Oib);
            edit.BojaPozadineZaPrazneCeliji(Txt_OdjelId);
        }
        // BTN za INSERT podataka u bazu ova metoda poziva više metoda da bi uspješno izvršila zadatak
        // Provjera praznih ćelija, javlja poruke korisnicma (najbliža je korisniku)
        // Postavlja vrijednosti varijabli u modelu, i poziva generičku metodu za unos podatka
        private void Btn_dodaj_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Pn) | edit.NullOrWhite(Txt_Ime) |
               edit.NullOrWhite(Txt_Prezime) | edit.NullOrWhite(Txt_OdjelId) |
               edit.NullOrWhite(Txt_Oib))
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
                            DTUpdate(ComBoxFilter.Text);
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
            if (edit.NullOrWhite(Txt_Pn) | edit.NullOrWhite(Txt_Ime) |
               edit.NullOrWhite(Txt_Prezime) | edit.NullOrWhite(Txt_OdjelId))
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
                        var success = false;
                        if (CheckBoxOtkaz.Checked)
                        {
                            success = controller.UpdateOtkaz(djelatnik);
                        }
                        else
                        {
                             success = controller.Update(djelatnik);
                        }
                        if (success is true)
                        {
                            DTUpdate(ComBoxFilter.Text);
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
            var djelatnik = new DjelatnikModel();
            if (Lbl_Id.Text.Length > 0)
            {
                djelatnik.Id = Convert.ToInt32(Lbl_Id.Text.Trim());
            }
            if (CheckBoxOtkaz.Checked)
            {
                djelatnik.DatOtkaz = Dtp_Otkaz.Value.Date;
            }
            djelatnik.PerNum = Convert.ToInt32(Txt_Pn.Text.Trim());
            djelatnik.Ime = Txt_Ime.Text.Trim();
            djelatnik.Prezime = Txt_Prezime.Text.Trim();
            djelatnik.Oib = Txt_Oib.Text.Trim();
            djelatnik.DatZaposlen = Dtp_Zaposlen.Value.Date;
            djelatnik.OdjelId = odjeliDict.FirstOrDefault(o => o.Value == Txt_OdjelId.Text.Trim()).Key;
            djelatnik.Status = ComBoxStatus.Text.Trim();
            return djelatnik;
        }
        // Učitavanje podataka iz tablice za prikaz prije editiranja (izmjene)
        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            Lbl_Id.Text = Dgv.Rows[rowIndex].Cells[0].Value.ToString();
            Txt_Pn.Text = Dgv.Rows[rowIndex].Cells[1].Value.ToString();
            Txt_Ime.Text = Dgv.Rows[rowIndex].Cells[2].Value.ToString();
            Txt_Prezime.Text = Dgv.Rows[rowIndex].Cells[3].Value.ToString();
            Txt_Oib.Text = Dgv.Rows[rowIndex].Cells[4].Value.ToString();
            Txt_OdjelId.Text = Dgv.Rows[rowIndex].Cells[5].Value.ToString();
            Dtp_Zaposlen.Text = Dgv.Rows[rowIndex].Cells[6].Value.ToString();
            if (Dgv.Rows[rowIndex].Cells[7].Value != null)
            {
                Dtp_Otkaz.Text = Dgv.Rows[rowIndex].Cells[7].Value.ToString();
            }
            ComBoxStatus.Text = Dgv.Rows[rowIndex].Cells[8].Value.ToString();
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

        private void ComBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTUpdate(ComBoxFilter.Text);
        }
    }
}
