using KPP_Alpha1.Controller;
using KPP_Alpha1.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class FormPartneri : Form
    {
        /// <summary>
        /// Djelatnici forma i klase koje se bave unosom i izmjenom djelatnika u bazu
        /// Primarne pomoćne klase su istoimene Model i Controller klase
        /// Skenudarne pomoćne klase su DbClass i EditClass
        /// </summary>
        
        readonly EditClass edit = new EditClass();
        readonly DbClass db = new DbClass();
        readonly PartnerController controller = new PartnerController();

        public FormPartneri()
        {
            InitializeComponent();
        }
        // BTN za INSERT podataka u bazu ova metoda poziva više metoda da bi uspješno izvršila zadatak
        // Provjera praznih ćelija, javlja poruke korisnicma (najbliža je korisniku)
        // Postavlja vrijednosti varijabli u modelu, i poziva generičku metodu za unos podatka
        private void Btn_dodaj_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txt_naziv))
            {
                edit.BojaPozadineZaPrazneCeliji(txt_naziv);
                edit.PorukaPraznaCelija();
            }
            else
            {
                var partner = SetProperties();
                try
                {
                    bool success = controller.Insert(partner);
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
                catch(Exception ex) { edit.MessageException(ex); }
            }
        }
        // BTN za izmjenu podataka radi sve što i unos metoda osim koraka pozivanja generičke metode za update podataka u bazi
        private void Btn_uredi_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txt_naziv))
            {
                edit.BojaPozadineZaPrazneCeliji(txt_naziv);
                edit.PorukaPraznaCelija();
            }
            else
            {
                edit.BojaPozadineZaPrazneCeliji(txt_naziv);
                var partner = SetProperties();
                try
                {
                    bool success = controller.Edit(partner);

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
        }
        // Metoda postavljanja varijabili koja se poziva prije unosa i izmjne podatka
        private PartnerModel SetProperties()
        {
            PartnerModel partner = new PartnerModel();
            if (!edit.NullOrWhite(txt_id)) 
            {
                partner.Id = Convert.ToInt32(txt_id.Text.Trim());
            }
            partner.Naziv = txt_naziv.Text.Trim();
            return partner;
        }
        // Brisanje svih polja i fokus na početno polje
        private void Clear()
        {
            txt_id.Clear();
            txt_naziv.Clear();
            txt_pretrazivanje.Clear();
            txt_naziv.Focus();
        }
        // Metoda koja isčitava podatke iz baze i prikazuje u DataGridView-u
        private void DTUpdate()
        {
            DataTable dt = db.Select("SELECT p.id AS ID, p.naziv AS Naziv, [d.ime]&' '&[d.prezime] AS Korisnik, p.azurirano AS Ažurirnao " +
                "FROM (partneri AS p LEFT JOIN korisnici AS k ON k.id=p.idkorisnika) " +
                "LEFT JOIN djelatnici AS d ON d.id=k.djelatnikid " +
                "ORDER BY p.naziv ASC;");
            Dgv.DataSource = dt;
        }
        // Učitavanje Forme, koja poziva metodu DtUpdate
        private void Partneri_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }
        // Učitavanje podataka iz tablice za prikaz prije editiranja (izmjene)
        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_id.Text = Dgv.Rows[rowIndex].Cells[0].Value.ToString();
            txt_naziv.Text = Dgv.Rows[rowIndex].Cells[1].Value.ToString();
        }
        // Metoda za pretraživanje podataka unesenih u bazu
        private void txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("naziv LIKE '%{0}%' OR korisnik LIKE '%{0}%'", txt_pretrazivanje.Text.Trim());
                if(Dgv.Rows[0].Cells[0].Value is null)
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                edit.MessageException(ex);
            }
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
