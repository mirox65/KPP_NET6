using KPP_Alpha1.Controller;
using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class Poslane : Form
    {
        readonly EditClass edit = new EditClass();
        readonly dbClass db = new dbClass();
        readonly PoslaneController controller = new PoslaneController();
        readonly form_Main main = new form_Main();

        public Dictionary<int, string> Partneri = new Dictionary<int, string>();
        public Dictionary<int, string> Djelatnici = new Dictionary<int, string>();
        public Dictionary<int, string> Posiljatelji = new Dictionary<int, string>();

        public Poslane()
        {
            InitializeComponent();
            Partneri = db.DictFill("naziv", "partneri");
            Djelatnici = db.DictFill("ime", "prezime", "djelatnici");
            Posiljatelji = db.DictFill("naziv", "posiljatelji");
            CollectionPartneri();
            CollectionDjelatnici();
            CollectionPosiljatelji();
        }

        private void CollectionPosiljatelji()
        {
            string DbAc = "SELECT * FROM posiljatelji;";
            string AcPrvi = "naziv";
            AutoCompleteStringCollection AcPosiljatelji = db.AutoComplete(DbAc, AcPrvi);
            txtPrimatelj.AutoCompleteCustomSource = AcPosiljatelji;
        }

        private void CollectionDjelatnici()
        {
            string DbAc = "SELECT * FROM djelatnici;";
            string AcPrvi = "ime";
            string AcDrugi = "prezime";
            AutoCompleteStringCollection AcDjelatnici = db.AutoComplete(DbAc, AcPrvi, AcDrugi);
            txtPosiljatelj.AutoCompleteCustomSource = AcDjelatnici;
        }

        private void CollectionPartneri()
        {
            string dbAc = "SELECT * FROM partneri;";
            string prvi = "naziv";
            AutoCompleteStringCollection acPartneri = db.AutoComplete(dbAc, prvi);
            txtPrevoznik.AutoCompleteCustomSource = acPartneri;
        }

        private void Btn_dodaj_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txtNapomena) | edit.NullOrWhite(txtNaziv) | edit.NullOrWhite(txtPosiljatelj) |
                edit.NullOrWhite(txtPrevoznik) | edit.NullOrWhite(txtPrimatelj))
            {
                PrazneCelije();
                db.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var poslane = SetProperties();
                bool provjera = ProvjeraKljučeva(poslane);
                if (provjera is true)
                {
                    db.MessageErrorKeyMissing();
                }
                else
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
                            db.MessageDBErrorInsert();
                        }
                    }
                    catch (Exception ex) { db.MessageGeneralDError(ex); }
                }
            }
        }

        private void Btn_uredi_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txtNapomena) | edit.NullOrWhite(txtNaziv) | edit.NullOrWhite(txtPosiljatelj) |
                edit.NullOrWhite(txtPrevoznik) | edit.NullOrWhite(txtPrimatelj))
            {
                PrazneCelije();
                db.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var poslane = SetProperties();
                bool provjera = ProvjeraKljučeva(poslane);
                if (provjera is true)
                {
                    db.MessageErrorKeyMissing();
                }
                else
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
                            db.MessageDBErrorUpdate();
                        }
                    }
                    catch (Exception ex) { db.MessageGeneralDError(ex); }
                }
            }
        }

        private bool ProvjeraKljučeva(PoslaneModel poslane)
        {
            bool provjera;
            if (poslane.PartnerId == 0 | poslane.DjelanikId == 0 | poslane.PosiljateljId == 0)
            {
                provjera = true;
            }
            else
            {
                provjera = false;
            }
            return provjera;
        }

        private void PrazneCelije()
        {
            edit.PrazneCelije(txtPrimatelj);
            edit.PrazneCelije(txtPrevoznik);
            edit.PrazneCelije(txtPosiljatelj);
            edit.PrazneCelije(txtNaziv);
            edit.PrazneCelije(txtNapomena);
        }

        private PoslaneModel SetProperties()
        {
            PoslaneModel poslane = new PoslaneModel();
            if (edit.NullOrWhite(txtId)) { }
            else
            {
                poslane.Id = Convert.ToInt32(txtId.Text.Trim());
            }
            poslane.Datum = dtpDatum.Value.Date;
            poslane.PosiljateljId = Posiljatelji.FirstOrDefault(p => p.Value == txtPrimatelj.Text.Trim()).Key;
            poslane.DjelanikId = Djelatnici.FirstOrDefault(d => d.Value == txtPosiljatelj.Text.Trim()).Key;
            poslane.Naziv = txtNaziv.Text.Trim();
            poslane.Napomena = txtNapomena.Text.Trim();
            poslane.PartnerId = Partneri.FirstOrDefault(p => p.Value == txtPrevoznik.Text.Trim()).Key;
            return poslane;
        }

        private void Clear()
        {
            txtId.Clear();
            txtNapomena.Clear();
            txtNaziv.Clear();
            txtPosiljatelj.Clear();
            txtPrevoznik.Clear();
            txtPrimatelj.Clear();
            txt_pretrazivanje.Clear();
            txtPosiljatelj.Focus();
        }

        private void DtUpdate()
        {
            DataTable dt = db.Select("SELECT p.id AS ID, p.datum AS Datum, po.naziv AS Primatelj, " +
                "[d.ime]&' '&[d.prezime] AS Pošiljatelj, p.naziv AS Naziv, p.napomena AS Napomena, " +
                "pa.naziv AS Prijevoznik, [k.ime]&' '&[k.prezime] AS Korisnik, p.azurirano AS Ažurirano " +
                "FROM(((Poslane AS p " +
                "LEFT JOIN posiljatelji AS po ON po.id = p.posiljateljid) " +
                "LEFT JOIN djelatnici AS d ON d.id = p.djelatnikid) " +
                "LEFT JOIN partneri AS pa ON pa.id = p.partnerid) " +
                "LEFT JOIN korisnici AS k ON k.id = p.korisnikid " +
                "ORDER BY Datum DESC;");
            Dgv.DataSource = dt;
        }

        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtId.Text = Dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpDatum.Text = Dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPosiljatelj.Text = Dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrimatelj.Text = Dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNaziv.Text = Dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNapomena.Text = Dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPrevoznik.Text = Dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void Poslane_Load(object sender, EventArgs e)
        {
            DtUpdate();
        }

        private void btnAddDjelatnik_Click(object sender, EventArgs e)
        {
            var form = new Djelatnici();
            form.Show();
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            this.Close(); ;
        }

        private void BtnAddPrimatelj_Click(object sender, EventArgs e)
        {
            var form = new form_Posiljatelji();
            form.Show();
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void BtnAddPartneri_Click(object sender, EventArgs e)
        {
            var form = new Partneri();
            form.Show();
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            this.Close();
        }

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
            catch(Exception ex) { db.MessageGeneralDError(ex); }
        }
    }
}
