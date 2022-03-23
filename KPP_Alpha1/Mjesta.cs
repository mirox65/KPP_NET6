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
    public partial class FormMjesta : Form
    {
        /// <summary>
        /// Djelatnici forma i klase koje se bave unosom i izmjenom djelatnika u bazu
        /// Primarne pomoćne klase su istoimene Model i Controller klase
        /// Skenudarne pomoćne klase su DbClass i EditClass
        /// </summary>

        readonly DbClass db = new ();
        readonly EditClass edit = new ();
        readonly DictionaryHelper dictionary = new();
        readonly AutocompleteHelper autocomplete = new ();
        readonly MjestoController controller = new ();

        // Riječnik koji učitava djelatnike te se koristi kod pronažaenja stranog ključa prije unosa u bazu
        public Dictionary<int, string> zpanijeDict = new();

        // Nakon incijalizacije instaciramo riječnike i kolekcije za daljnju obradu
        public FormMjesta()
        {
            InitializeComponent();
            zpanijeDict = dictionary.DictIntString("zupanija", "zupanije");
            CollectionZpanije();
        }
        // Metoda za kolekciju koja se veže za txtBox Odjeli za suggest and append
        private void CollectionZpanije()
        {
            string DbAc = "SELECT * FROM zupanije;";
            string AcPrvi = "zupanija";
            AutoCompleteStringCollection AcZup = autocomplete.AutoComplete(DbAc, AcPrvi);
            txt_Zupanija.AutoCompleteCustomSource = AcZup;
        }
        // Metoda koja isčitava podatke iz baze i prikazuje u DataGridView-u
        private void DTUpdate()
        {
            string Dbs = "SELECT m.id AS ID, m.ptt AS PTT, m.mjesto AS Mjesto, z.zupanija AS Županija, " +
                "[d.ime]&' '&[d.prezime] AS Korsinik, m.azurirano AS Ažurirano " +
                "FROM ((mjesta AS m LEFT JOIN zupanije AS z ON z.id=m.idZupanije) " +
                "LEFT JOIN korisnici AS k ON k.id=m.korisnikId) " +
                "LEFT JOIN djelatnici AS d ON d.id=k.djelatnikid " +
                "ORDER BY m.ptt ASC, m.id ASC;";
            DataTable dt = db.Select(Dbs);
            DGV_Mjesta.DataSource = dt;
        }
        // Učitavanje Forme, koja poziva metodu DtUpdate
        private void Form_Mjesta_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }
        // BTN za INSERT podataka u bazu ova metoda poziva više metoda da bi uspješno izvršila zadatak
        // Provjera praznih ćelija, javlja poruke korisnicma (najbliža je korisniku)
        // Postavlja vrijednosti varijabli u modelu, i poziva generičku metodu za unos podatka
        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txt_Mjesto) | edit.NullOrWhite(txt_Ptt) | edit.NullOrWhite(txt_Zupanija))
            {
                PrazneCelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var mjesto = SetProperties();
                var provjera = ProvjeraKljučeva(mjesto);
                if (provjera is true)
                {
                    try
                    {
                        bool success = controller.Insert(mjesto);
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
        private void btn_Uredi_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txt_Mjesto) | edit.NullOrWhite(txt_Ptt) | edit.NullOrWhite(txt_Zupanija))
            {
                PrazneCelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var mjesto = SetProperties();
                var provjera = ProvjeraKljučeva(mjesto);
                if (provjera is true)
                {
                    edit.MessageErrorKeyMissing();
                }
                else
                {
                    try
                    {
                        bool success = controller.Update(mjesto);
                        if (success == true)
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
            }
        }
        // Metoda provjerava da je strani ključ veći od 0 prije unosa
        private bool ProvjeraKljučeva(MjestoModel mjesto)
        {
            bool provjera = false;
            if (mjesto.IdZupanije > 0)
            {
                provjera = true;
            }
            return provjera;
        }
        // Metoda postavljanja varijabili koja se poziva prije unosa i izmjne podatka
        private MjestoModel SetProperties()
        {
            MjestoModel mjesto = new();
            if (int.Parse(Lbl_Id.Text) > 0) 
            {
                mjesto.Id = int.Parse(Lbl_Id.Text.Trim());
            }
            mjesto.Ptt = txt_Ptt.Text.Trim();
            mjesto.Mjesto = txt_Mjesto.Text.Trim();
            mjesto.IdZupanije = zpanijeDict.FirstOrDefault(z => z.Value == txt_Zupanija.Text.Trim()).Key;
            return mjesto;
        }
        // Učitavanje podataka iz tablice za prikaz prije editiranja (izmjene)
        private void DGV_Mjesta_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            Lbl_Id.Text = DGV_Mjesta.Rows[RowIndex].Cells[0].Value.ToString();
            txt_Ptt.Text = DGV_Mjesta.Rows[RowIndex].Cells[1].Value.ToString();
            txt_Mjesto.Text = DGV_Mjesta.Rows[RowIndex].Cells[2].Value.ToString();
            txt_Zupanija.Text = DGV_Mjesta.Rows[RowIndex].Cells[3].Value.ToString();
        }
        // Metoda za pretraživanje podataka unesenih u bazu
        private void txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (DGV_Mjesta.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("ptt LIKE '%{0}%' OR mjesto LIKE '%{0}%' OR županija LIKE '%{0}%'", txt_pretrazivanje.Text.Trim());
                if (DGV_Mjesta.Rows[0].Cells[0].Value is null)
                {
                    return;
                }
            }
            catch (Exception ex) { edit.MessageException(ex); }
        }
        // Brisanje svih polja i fokus na početno polje
        private void Clear()
        {
            Lbl_Id.Text = "0";
            txt_Ptt.Clear();
            txt_Mjesto.Clear();
            txt_Zupanija.Clear();
            txt_pretrazivanje.Clear();
            txt_Ptt.Focus();
        }
        // Provjera je li neka od ćelija prazna. Poziva generičku metodu u edit klasi koju koriste sve forme
        private void PrazneCelije()
        {
            edit.BojaPozadineZaPrazneCeliji(txt_Mjesto);
            edit.BojaPozadineZaPrazneCeliji(txt_Ptt);
            edit.BojaPozadineZaPrazneCeliji(txt_Zupanija);
        }
        // Izbornik gumb za Insert/unos podataka kratica F4
        private void dodajNoviUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_dodaj.PerformClick();
        }
        // Izbornik gumb za Update/izmjenu podataka kratica F3
        private void spremiIzmjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Uredi.PerformClick();
        }
        // Izbornik gumb za brisanje teksta iz textBoxova kratica F1
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
