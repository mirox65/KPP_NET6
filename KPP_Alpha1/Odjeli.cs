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

        readonly DbClass db = new();
        readonly EditClass edit = new();
        readonly OdjelController controller = new();

        public FormOdjeli()
        {
            InitializeComponent();
            Clear();
        }
        // Učitavanje Forme, koja poziva metodu DtUpdate
        private void form_Odjeli_Load(object sender, EventArgs e)
        {
            DTUpdate(CmbFilter.Text);
        }
        // Metoda koja isčitava podatke iz baze i prikazuje u DataGridView-u
        private void DTUpdate(string filter)
        {
            string Dbs = "SELECT o.id AS ID, o.naziv AS Naziv, o.status AS Status, [d.ime]&' '&[d.prezime] AS Ažurirao, o.azurirano AS Ažurirano " +
                "FROM (odjeli AS o LEFT JOIN korisnici AS k ON k.id=o.korisnikid) " +
                "LEFT JOIN djelatnici AS d ON d.id=k.djelatnikid " +
                $"WHERE o.status='{filter}' " +
                "ORDER BY naziv ASC;";
            DataTable dt = db.Select(Dbs);
            dgv_odjel.DataSource = dt;
        }
        // Brisanje svih polja i fokus na početno polje
        private void Clear()
        {
            txt_naziv.Clear();
            lbl_id_odjel.Text = "0";
            txt_pretrazivanje.Clear();
            CmbStatus.SelectedIndex = 0;
            CmbFilter.SelectedIndex = 0;
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
                Insert(odjel);
                DTUpdate(CmbFilter.Text);
                Clear();
            }
        }

        private void Insert(OdjelModel odjel)
        {
            try
            {
                bool success = controller.Insert(odjel);
                if (success is false)
                {
                    edit.MessageDBErrorInsert();
                }

            }
            catch (Exception) { throw; }
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
                Edit(odjel);
                DTUpdate(CmbFilter.Text);
                Clear();
            }
        }

        private void Edit(OdjelModel odjel)
        {
            try
            {
                bool success = controller.Update(odjel);
                if (success is false)
                {
                    edit.MessageDBErrorUpdate();
                }
            }
            catch (Exception ex) { edit.MessageException(ex); }
        }

        // Metoda postavljanja varijabili koja se poziva prije unosa i izmjne podatka
        private OdjelModel SetProperties()
        {
            var odjel = new OdjelModel();
            if (int.Parse(lbl_id_odjel.Text) > 0)
            {
                odjel.Id = int.Parse(lbl_id_odjel.Text.Trim());
            }
            odjel.Naziv = txt_naziv.Text.Trim();
            odjel.Status = CmbStatus.Text;
            return odjel;
        }
        // Učitavanje podataka iz tablice za prikaz prije editiranja (izmjene)
        private void dgv_odjel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            lbl_id_odjel.Text = dgv_odjel.Rows[RowIndex].Cells[0].Value.ToString();
            txt_naziv.Text = dgv_odjel.Rows[RowIndex].Cells[1].Value.ToString();
            CmbStatus.Text = dgv_odjel.Rows[RowIndex].Cells[2].Value.ToString();
        }
        // Metoda za pretraživanje podataka unesenih u bazu
        private void txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dgv_odjel.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("naziv LIKE '%{0}%' OR ažurirao LIKE '%{0}%'", txt_pretrazivanje.Text.Trim());
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

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTUpdate(CmbFilter.Text);
        }
    }
}
