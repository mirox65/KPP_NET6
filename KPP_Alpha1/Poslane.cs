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
    public partial class FormPoslane : Form
    {
        /// <summary>
        /// Poslane forma i klase koje se bave unosom i izmjenom poslane pošte u bazu
        /// Primarne pomoćne klase su istoimene Model i Controller klase
        /// Skenudarne pomoćne klase su DbClass i EditClass
        /// </summary>
        
        readonly EditClass edit = new ();
        readonly DbClass db = new ();
        readonly DictionaryHelper dictionary = new();
        readonly AutocompleteHelper autocomplete = new ();
        readonly PoslaneController controller = new ();
        // Riječnik koji učitava djelatnike te se koristi kod pronažaenja stranog ključa prije unosa u bazu
        public Dictionary<int, string> partneriDict = new();
        public Dictionary<int, string> djelatniciDict = new();
        public Dictionary<int, string> posiljateljiDict = new();
        // Nakon incijalizacije instaciramo riječnike i kolekcije za daljnju obradu
        public FormPoslane()
        {
            InitializeComponent();
            partneriDict = dictionary.DictIntString("naziv", "partneri");
            djelatniciDict = dictionary.DictIntString("ime", "prezime", "djelatnici");
            posiljateljiDict = dictionary.DictIntString("naziv", "posiljatelji");
            CollectionPartneri();
            CollectionDjelatnici();
            CollectionPosiljatelji();
        }
        // Metoda za kolekciju  koja se veže za txtBox Pošiljatelji za suggest and append
        private void CollectionPosiljatelji()
        {
            string DbAc = "SELECT * FROM posiljatelji;";
            AutoCompleteStringCollection AcPosiljatelji = autocomplete.AutoComplete(DbAc, "naziv");
            txtPrimatelj.AutoCompleteCustomSource = AcPosiljatelji;
        }
        // Metoda za kolekciju koja se veže za txtBox Djelatnici za suggest and append
        private void CollectionDjelatnici()
        {
            string DbAc = "SELECT * FROM djelatnici;";
            AutoCompleteStringCollection AcDjelatnici = autocomplete.AutoComplete(DbAc, "ime", "prezime");
            txtPosiljatelj.AutoCompleteCustomSource = AcDjelatnici;
        }
        // Metoda za kolekciju  koja se veže za txtBox Partneri za suggest and append
        private void CollectionPartneri()
        {
            string dbAc = "SELECT * FROM partneri;";
            AutoCompleteStringCollection acPartneri = autocomplete.AutoComplete(dbAc, "naziv");
            txtPrevoznik.AutoCompleteCustomSource = acPartneri;
        }
        // BTN za INSERT podataka u bazu ova metoda poziva više metoda da bi uspješno izvršila zadatak
        // Provjera praznih ćelija, javlja poruke korisnicma (najbliža je korisniku)
        // Postavlja vrijednosti varijabli u modelu, i poziva generičku metodu za unos podatka
        private void Btn_dodaj_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txtNapomena) | edit.NullOrWhite(txtNaziv) | edit.NullOrWhite(txtPosiljatelj) |
                edit.NullOrWhite(txtPrevoznik) | edit.NullOrWhite(txtPrimatelj))
            {
                PrazneCelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var poslane = SetProperties();
                bool provjera = ProvjeraKljučeva(poslane);
                if (provjera is true)
                {
                    try
                    {
                        bool success = controller.Insert(poslane);
                        if (success is true)
                        {
                            DtUpdate();
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
            if (edit.NullOrWhite(txtNapomena) | edit.NullOrWhite(txtNaziv) | edit.NullOrWhite(txtPosiljatelj) |
                edit.NullOrWhite(txtPrevoznik) | edit.NullOrWhite(txtPrimatelj))
            {
                PrazneCelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var poslane = SetProperties();
                bool provjera = ProvjeraKljučeva(poslane);
                if (provjera is true)
                {
                    try
                    {
                        bool success = controller.Update(poslane);
                        if (success is true)
                        {
                            DtUpdate();
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
        private bool ProvjeraKljučeva(PoslaneModel poslane)
        {
            bool provjera = false;
            if (poslane.PartnerId > 0 | poslane.DjelanikId > 0 | poslane.PosiljateljId > 0) 
            { 
                provjera = true;
            }
            return provjera;
        }
        // Provjera je li neka od ćelija prazna. Poziva generičku metodu u edit klasi koju koriste sve forme
        private void PrazneCelije()
        {
            edit.BojaPozadineZaPrazneCeliji(txtPrimatelj);
            edit.BojaPozadineZaPrazneCeliji(txtPrevoznik);
            edit.BojaPozadineZaPrazneCeliji(txtPosiljatelj);
            edit.BojaPozadineZaPrazneCeliji(txtNaziv);
            edit.BojaPozadineZaPrazneCeliji(txtNapomena);
        }
        // Metoda postavljanja varijabili koja se poziva prije unosa i izmjne podatka
        private PoslaneModel SetProperties()
        {
            PoslaneModel poslane = new ();
            if (int.Parse(Lbl_Id.Text) > 0) 
            {
                poslane.Id = Convert.ToInt32(Lbl_Id.Text.Trim());
            }
            poslane.Datum = dtpDatum.Value.Date;
            poslane.PosiljateljId = posiljateljiDict.FirstOrDefault(p => p.Value == txtPrimatelj.Text.Trim()).Key;
            poslane.DjelanikId = djelatniciDict.FirstOrDefault(d => d.Value == txtPosiljatelj.Text.Trim()).Key;
            poslane.Naziv = txtNaziv.Text.Trim();
            poslane.Napomena = txtNapomena.Text.Trim();
            poslane.PartnerId = partneriDict.FirstOrDefault(p => p.Value == txtPrevoznik.Text.Trim()).Key;
            return poslane;
        }
        // Brisanje svih polja i fokus na početno polje
        private void Clear()
        {
            Lbl_Id.Text = "0";
            txtNapomena.Clear();
            txtNaziv.Clear();
            txtPosiljatelj.Clear();
            txtPrevoznik.Clear();
            txtPrimatelj.Clear();
            txt_pretrazivanje.Clear();
            txtPosiljatelj.Focus();
        }
        // Metoda koja isčitava podatke iz baze i prikazuje u DataGridView-u
        private void DtUpdate()
        {
            DataTable dt = db.Select("SELECT p.id AS ID, p.datum AS Datum, [d.ime]&' '&[d.prezime] AS Pošiljatelj, " +
                "po.naziv AS Primatelj, p.naziv AS Naziv, p.napomena AS Napomena, " +
                "pa.naziv AS Prijevoznik, [do.ime]&' '&[do.prezime] AS Korisnik, p.azurirano AS Ažurirano " +
                "FROM ((((Poslane AS p LEFT JOIN posiljatelji AS po ON po.id = p.posiljateljid) " +
                "LEFT JOIN djelatnici AS d ON d.id = p.djelatnikid) " +
                "LEFT JOIN partneri AS pa ON pa.id = p.partnerid) " +
                "LEFT JOIN korisnici AS k ON k.id = p.korisnikid)" +
                "LEFT JOIN djelatnici AS do ON do.id=k.djelatnikid " +
                "ORDER BY Datum DESC;");
            Dgv.DataSource = dt;
            edit.DgvColumnsResize(Dgv);
        }
        // Učitavanje podataka iz tablice za prikaz prije editiranja (izmjene)
        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Lbl_Id.Text = Dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpDatum.Text = Dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPosiljatelj.Text = Dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrimatelj.Text = Dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNaziv.Text = Dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNapomena.Text = Dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPrevoznik.Text = Dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        // Učitavanje Forme, koja poziva metodu DtUpdate
        private void Poslane_Load(object sender, EventArgs e)
        {
            DtUpdate();
        }
        // Otvaranje druge forme preko gumba plus pored polja za unos
        private void btnAddDjelatnik_Click(object sender, EventArgs e)
        {
            var form = new FormDjelatnici();
            form.Show();
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            this.Close(); ;
        }
        // Otvaranje druge forme preko gumba plus pored polja za unos
        private void BtnAddPrimatelj_Click(object sender, EventArgs e)
        {
            var form = new FormPosiljatelji();
            form.Show();
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            this.Close();
        }
        // Otvaranje druge forme preko gumba plus pored polja za unos
        private void BtnAddPartneri_Click(object sender, EventArgs e)
        {
            var form = new FormPartneri();
            form.Show();
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            this.Close();
        }
        // Metoda za pretraživanje podataka unesenih u bazu
        private void Txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("Primatelj LIKE '%{0}%' OR Pošiljatelj LIKE '%{0}%' OR " +
                    "Naziv LIKE '%{0}%' OR Prijevoznik LIKE '%{0}%'", txt_pretrazivanje.Text.Trim());
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
