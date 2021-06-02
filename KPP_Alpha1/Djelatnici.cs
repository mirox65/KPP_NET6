using KPP_Alpha1.Controller;
using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class Djelatnici : Form
    {
        private readonly dbClass db = new dbClass();
        private readonly EditClass edit = new EditClass();
        readonly DjelatnikController controller = new DjelatnikController();
        public Dictionary<int, string> Odjeli = new Dictionary<int, string>();

        public string TrazenaSifra { get; set; }

        public Djelatnici()
        {
            InitializeComponent();
            Odjeli = db.DictFill("naziv", "odjeli");
            AutoCompOdjel();
        }

        private void AutoCompOdjel()
        {
            string DbAc = "SELECT * FROM odjeli;";
            string AcPrvi = "naziv";
            AutoCompleteStringCollection AcOdjel = db.AutoComplete(DbAc, AcPrvi);
            txtOdjelId.AutoCompleteCustomSource = AcOdjel;
        }

        private void Djelatnici_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }

        private void DTUpdate()
        {
            string Dbs = "SELECT d.id AS ID, d.pn AS PN, d.ime AS Ime, d.prezime AS Prezime, o.naziv AS Odjel, " +
                "[k.ime]&' '&[k.prezime] AS Korisnik, d.azurirano AS Ažurirano " +
                "FROM(Djelatnici AS d " +
                "LEFT JOIN odjeli AS o ON o.id = d.idodjel) " +
                "LEFT JOIN korisnici AS k ON k.id = d.idkorisnika ORDER BY d.prezime ASC;";
            DataTable dt = db.Select(Dbs);
            Dgv.DataSource = dt;
        }
        private void Clear()
        {
            txtPN.Clear();
            txt_ime.Clear();
            txt_prezime.Clear();
            txtOdjelId.Clear();
            txt_id.Clear();
            txtPN.Focus();
        }
        private void PrazneCelije()
        {
            edit.PrazneCelije(txtPN);
            edit.PrazneCelije(txt_ime);
            edit.PrazneCelije(txt_prezime);
            edit.PrazneCelije(txtOdjelId);
        }

        private void Btn_dodaj_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txtPN) | edit.NullOrWhite(txt_ime) |
               edit.NullOrWhite(txt_prezime) | edit.NullOrWhite(txtOdjelId))
            {
                PrazneCelije();
                db.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var djelatnik = SetProperties();
                var provjera = ProvjeraKljučeva(djelatnik);
                if (provjera is true)
                {
                    db.MessageErrorKeyMissing();
                }
                else
                {
                    try
                    {
                        bool sucess = controller.Insert(djelatnik);
                        if (sucess is true)
                        {
                            DTUpdate();
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

        private bool ProvjeraKljučeva(DjelatnikModel djelatnik)
        {
            bool provjera;
            if (djelatnik.OdjelId == 0)
            {
                provjera = true;
            }
            else
            {
                provjera = false;
            }
            return provjera;
        }

        private void Btn_uredi_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txtPN) | edit.NullOrWhite(txt_ime) |
               edit.NullOrWhite(txt_prezime) | edit.NullOrWhite(txtOdjelId))
            {
                PrazneCelije();
                MessageBox.Show(db.PraznaCelija, db.CelijaNazivUpozorenje);
            }
            else
            {
                PrazneCelije();
                var djelatnik = SetProperties();
                var provjera = ProvjeraKljučeva(djelatnik);
                if (provjera is true)
                {
                    db.MessageErrorKeyMissing();
                }
                else
                {
                    try
                    {
                        bool sucess = controller.Update(djelatnik);
                        if (sucess is true)
                        {
                            DTUpdate();
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

        private DjelatnikModel SetProperties()
        {
            DjelatnikModel djelatnik = new DjelatnikModel();
            if (edit.NullOrWhite(txt_id)) { }
            else
            {
                djelatnik.Id = Convert.ToInt32(txt_id.Text.Trim());
            }
            djelatnik.PerNum = Convert.ToInt32(txtPN.Text.Trim());
            djelatnik.Ime = txt_ime.Text.Trim();
            djelatnik.Prezime = txt_prezime.Text.Trim();
            djelatnik.OdjelId = edit.Sifra(TrazenaSifra = txtOdjelId.Text.Trim(), "odjeli", "naziv");
            return djelatnik;
        }

        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = Dgv.Rows[RowIndex].Cells[0].Value.ToString();
            txtPN.Text = Dgv.Rows[RowIndex].Cells[1].Value.ToString();
            txt_ime.Text = Dgv.Rows[RowIndex].Cells[2].Value.ToString();
            txt_prezime.Text = Dgv.Rows[RowIndex].Cells[3].Value.ToString();
            txtOdjelId.Text = Dgv.Rows[RowIndex].Cells[4].Value.ToString();
        }

        private void txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("Ime LIKE '%{0}%' OR prezime LIKE '%{0}%' OR " +
                "Odjel LIKE '%{0}%' OR Korisnik LIKE '%{0}%'", txt_pretrazivanje.Text.Trim());
            if(Dgv.Rows[0].Cells[0].Value is null)
            {
                return;
            }
        }
    }
}
