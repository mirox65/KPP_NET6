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
    public partial class FormPosiljatelji : Form
    {
        /// <summary>
        /// Posiljatelji forma i klase koje se bave unosom i izmjenom pošiljatelja u bazu
        /// Primarne pomoćne klase su istoimene Model i Controller klase
        /// Skenudarne pomoćne klase su DbClass i EditClass
        /// </summary>

        readonly DbClass db = new();
        readonly EditClass edit = new();
        readonly DictionaryHelper dictionary = new();
        readonly AutocompleteHelper autocomplete = new();
        readonly PosiljateljController controller = new();
        readonly DoubleCheckHelper doubleCheck = new();

        // Riječnik koji učitava djelatnike te se koristi kod pronažaenja stranog ključa prije unosa u bazu
        public Dictionary<int, string> mjestaDict = new();

        // Nakon incijalizacije instaciramo riječnik Mjesta i kolekciju Mjesto
        public FormPosiljatelji()
        {
            InitializeComponent();
            Clear();
            mjestaDict = dictionary.DictIntString("mjesto", "ptt", "mjesta");
            CollecionMjesta();
        }
        // Metoda za kolekciju Mjesta koja se veže za txtBox Mjesta za suggest and append
        private void CollecionMjesta()
        {
            AutoCompleteStringCollection AcMjesto = autocomplete.AutoComplete("mjesta", "mjesto", "ptt");
            txt_mjesto.AutoCompleteCustomSource = AcMjesto;
        }
        // Metoda koja isčitava podatke iz baze i prikazuje u DataGridView-u
        private void DTUpdate(string filter)
        {
            string Dbs = "SELECT p.id AS ID, p.naziv AS Pošiljatelj, p.oib AS OIB, m.mjesto AS Mjesto, p.status AS Status, " +
                "[d.ime]&' '&[d.prezime] AS Ažurirao, p.azurirano AS Ažurirano " +
                "FROM ((posiljatelji AS p " +
                "LEFT JOIN mjesta AS m ON m.id = p.idmjesto) " +
                "LEFT JOIN korisnici AS k ON k.id=p.korisnikId) " +
                "LEFT JOIN djelatnici AS d ON d.id=k.djelatnikid " +
                $"WHERE p.status = '{filter}' " +
                "ORDER BY p.naziv ASC;";
            DataTable dt = db.Select(Dbs);
            Dgv.DataSource = dt;
        }
        // Učitavanje Forme, koja poziva metodu DtUpdate
        private void form_Posiljatelji_Load(object sender, EventArgs e)
        {
            DTUpdate(CmbFilter.Text);
        }
        // Brisanje svih polja i fokus na početno polje
        private void Clear()
        {
            txt_naziv.Clear();
            Txt_Oib.Clear();
            txt_mjesto.Clear();
            CmbStatus.SelectedIndex = 0;
            CmbFilter.SelectedIndex = 0;
            Lbl_Id.Text = "0";
            txt_pretrazivanje.Clear();
            txt_naziv.Focus();
        }
        // BTN za INSERT podataka u bazu ova metoda poziva više metoda da bi uspješno izvršila zadatak
        // Provjera praznih ćelija, javlja poruke korisnicma (najbliža je korisniku)
        // Postavlja vrijednosti varijabli u modelu, i poziva generičku metodu za unos podatka
        private void lbl_dodaj_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txt_naziv) | edit.NullOrWhite(txt_mjesto))
            {
                PrazneCelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var posiljatelj = SetProperties();
                var provjera = ProvjeraKljučeva(posiljatelj);
                var duplikat = doubleCheck.DoubleInsertChecker("oib", "posiljatelji",posiljatelj.Oib);
                if (provjera is true && duplikat is true)
                {
                    Insert(posiljatelj);
                    DTUpdate(CmbFilter.Text);
                    Clear();
                }
                else
                {
                    if (provjera is false)
                    {
                        edit.MessageErrorKeyMissing();
                    }
                    if (duplikat is false)
                    {
                        edit.MessageDuplikat();
                    }
                }
            }
        }

        private void Insert(PosiljateljModel posiljatelj)
        {
            try
            {
                bool success = controller.Insert(posiljatelj);
                if (success is false)
                {
                    edit.MessageDBErrorInsert();
                }
            }
            catch (Exception ex) { edit.MessageException(ex); }
        }

        // BTN za izmjenu podataka radi sve što i unos metoda osim koraka pozivanja generičke metode za update podataka u bazi
        private void lbl_uredi_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txt_naziv) | edit.NullOrWhite(txt_mjesto))
            {
                PrazneCelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var posiljatelj = SetProperties();
                var provjera = ProvjeraKljučeva(posiljatelj);
                var duplikat = doubleCheck.DoubleInsertChecker("oib", "posiljatelji", posiljatelj.Oib);
                if (provjera is true && duplikat is true)
                {
                    Update(posiljatelj);
                    DTUpdate(CmbFilter.Text);
                    Clear();

                }
                else
                {
                    if (provjera is false)
                    {
                        edit.MessageErrorKeyMissing();
                    }
                    if (duplikat is false)
                    {
                        edit.MessageDuplikat();
                    }
                }
            }
        }

        private void Update(PosiljateljModel posiljatelj)
        {
            try
            {
                bool success = controller.Update(posiljatelj);
                if (success is false)
                {
                    edit.MessageDBErrorUpdate();
                }
            }
            catch (Exception ex) { edit.MessageException(ex); }
        }

        // Metoda provjerava da je strani ključ veći od 0 prije unosa
        private object ProvjeraKljučeva(PosiljateljModel posiljatelj)
        {
            bool provjera = false;
            if (posiljatelj.IdMjesto > 0)
            {
                provjera = true;
            }
            return provjera;
        }
        // Metoda postavljanja varijabili koja se poziva prije unosa i izmjne podatka
        private PosiljateljModel SetProperties()
        {
            PosiljateljModel posiljatelj = new();
            if (int.Parse(Lbl_Id.Text) > 0)
            {
                posiljatelj.Id = int.Parse(Lbl_Id.Text.Trim());
            }
            posiljatelj.Naziv = txt_naziv.Text.Trim();
            posiljatelj.Oib = Txt_Oib.Text.Trim();
            posiljatelj.IdMjesto = mjestaDict.FirstOrDefault(m => m.Value == txt_mjesto.Text.Trim()).Key;
            posiljatelj.Status = CmbStatus.Text;
            return posiljatelj;
        }
        // Provjera je li neka od ćelija prazna. Poziva generičku metodu u edit klasi koju koriste sve forme
        private void PrazneCelije()
        {
            edit.BojaPozadineZaPrazneCeliji(txt_naziv);
            edit.BojaPozadineZaPrazneCeliji(txt_mjesto);
        }
        // Učitavanje podataka iz tablice za prikaz prije editiranja (izmjene)
        private void dgv_posiljatelji_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Lbl_Id.Text = Dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_naziv.Text = Dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            Txt_Oib.Text = Dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_mjesto.Text = Dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            CmbStatus.Text = Dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        // Metoda za pretraživanje podataka unesenih u bazu
        private void txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                     string.Format("pošiljatelj LIKE '%{0}%' OR mjesto LIKE '%{0}%' OR ažurirao LIKE '%{0}%'",
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

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTUpdate(CmbFilter.Text);
        }
    }
}
