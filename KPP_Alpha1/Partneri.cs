using KPP_Alpha1.Controller;
using KPP_Alpha1.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class Partneri : Form
    {
        readonly EditClass edit = new EditClass();
        readonly dbClass db = new dbClass();
        readonly PartnerController controller = new PartnerController();

        public Partneri()
        {
            InitializeComponent();
        }

        private void Btn_dodaj_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txt_naziv))
            {
                edit.PrazneCelije(txt_naziv);
                db.PorukaPraznaCelija();
            }
            else
            {
                PartnerModel partner = new PartnerModel();
                partner.Naziv = txt_naziv.Text.Trim();
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
                        db.MessageDBErrorInsert();
                    }
                }
                catch(Exception ex) { db.MessageGeneralDError(ex); }
            }
        }

        private void Btn_uredi_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(txt_naziv))
            {
                edit.PrazneCelije(txt_naziv);
                db.PorukaPraznaCelija();
            }
            else
            {
                edit.PrazneCelije(txt_naziv);
                PartnerModel partner = new PartnerModel();
                partner.Id = Convert.ToInt32(txt_id.Text.Trim());
                partner.Naziv = txt_naziv.Text.Trim();
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
                        db.MessageDBErrorInsert();
                    }
                }
                catch (Exception ex) { db.MessageGeneralDError(ex); }
            }
        }

        private void Clear()
        {
            txt_id.Clear();
            txt_naziv.Clear();
            txt_naziv.Focus();
        }

        private void DTUpdate()
        {
            DataTable dt = db.Select("SELECT p.id AS ID, p.naziv AS Naziv, [k.ime]&' '&[k.prezime] AS Korisnik, p.azurirano AS Ažurirnao " +
                "FROM partneri AS p " +
                "LEFT JOIN korisnici AS k ON k.id=p.idkorisnika ORDER BY p.naziv ASC;");
            Dgv.DataSource = dt;
        }

        private void Partneri_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }

        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_id.Text = Dgv.Rows[rowIndex].Cells[0].Value.ToString();
            txt_naziv.Text = Dgv.Rows[rowIndex].Cells[1].Value.ToString();
        }

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
                db.MessageGeneralDError(ex);
            }
        }
    }
}
