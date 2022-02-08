using KPP_Alpha1.Controller;
using KPP_Alpha1.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class FormOdjeli : Form
    {
        /// <summary>
        /// Odjeli forma i klase koje se bave unosom i izmjenom djelatnika u bazu
        /// Primarne pomoćne klase su istoimene Model i Controller klase
        /// Skenudarne pomoćne klase su DbClass i EditClass
        /// </summary>

        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();
        readonly OdjelController controller = new OdjelController();

        public FormOdjeli()
        {
            InitializeComponent();
        }
        // Učitavanje Forme, koja poziva metodu DtUpdate
        private void form_Odjeli_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }
        // Metoda koja isčitava podatke iz baze i prikazuje u DataGridView-u
        private void DTUpdate()
        {
            string Dbs = "SELECT o.id AS ID, o.naziv AS Naziv, [d.ime]&' '&[d.prezime] AS Korisnik, o.azurirano AS Ažurirano " +
                "FROM (odjeli AS o LEFT JOIN korisnici AS k ON k.id=o.korisnikid) " +
                "LEFT JOIN djelatnici AS d ON d.id=k.djelatnikid ORDER BY naziv ASC;";
            DataTable dt = db.Select(Dbs);
            dgv_odjel.DataSource = dt;
        }
        // Brisanje svih polja i fokus na početno polje
        private void Clear()
        {
            txt_naziv.Clear();
            txt_id.Clear();
            txt_pretrazivanje.Clear();
            txt_naziv.Focus();
        }
        // BTN za INSERT podataka u bazu ova metoda poziva više metoda da bi uspješno izvršila zadatak
        // Provjera praznih ćelija, javlja poruke korisnicma (najbliža je korisniku)
        // Postavlja vrijednosti varijabli u modelu, i poziva generičku metodu za unos podatka
        private void Lbl_dodaj_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txt_naziv))
            {
                edit.BojaPozadineZaPrazneCeliji(txt_naziv);
                edit.PorukaPraznaCelija();
            }
            else
            {
                edit.BojaPozadineZaPrazneCeliji(txt_naziv);
                var odjel = SetProperties();
                bool success = controller.Insert(odjel);
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
        }
        // BTN za izmjenu podataka radi sve što i unos metoda osim koraka pozivanja generičke metode za update podataka u bazi
        private void lbl_uredi_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txt_naziv))
            {
                edit.BojaPozadineZaPrazneCeliji(txt_naziv);
                edit.PorukaPraznaCelija();
            }
            else
            {
                edit.BojaPozadineZaPrazneCeliji(txt_naziv);
                var odjel = SetProperties();
                try
                {
                    bool success = controller.Update(odjel);
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
        }
        // Metoda postavljanja varijabili koja se poziva prije unosa i izmjne podatka
        private OdjelModel SetProperties()
        {
            OdjelModel odjel = new OdjelModel();
            if (!edit.NullOrWhite(txt_id))
            {
                odjel.Id = int.Parse(txt_id.Text.Trim());
            }
            odjel.Naziv = txt_naziv.Text.Trim();
            return odjel;
        }
        // Učitavanje podataka iz tablice za prikaz prije editiranja (izmjene)
        private void dgv_odjel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = dgv_odjel.Rows[RowIndex].Cells[0].Value.ToString();
            txt_naziv.Text = dgv_odjel.Rows[RowIndex].Cells[1].Value.ToString();
        }
        // Metoda za pretraživanje podataka unesenih u bazu
        private void txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dgv_odjel.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("naziv LIKE '%{0}%' OR korisnik LIKE '%{0}%'", txt_pretrazivanje.Text.Trim());
                if (dgv_odjel.Rows[0].Cells[0].Value is null)
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
