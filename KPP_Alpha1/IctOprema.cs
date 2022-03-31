using KPP_Alpha1.Controller;
using KPP_Alpha1.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class FormIctOprema : Form
    {
        /// <summary>
        /// Oprema forma i klasa koja se bavi unosom i izmjenom it opreme u bazu podataka.
        /// Primarne pomoćne klasee su istoimeni Model i Controller
        /// Sekundarne pomoćne klase su DbClass i EditClass
        /// </summary>
        /// 
        readonly DbClass db = new ();
        readonly EditClass edit = new();
        readonly IctOpremaController controller = new ();

        public FormIctOprema()
        {
            InitializeComponent();
            Clear();
        }

        private void Clear()
        {
            Lbl_Id.Text = "0";
            Txt_Naziv.Clear();
            Txt_Search.Clear();
            Txt_InvBroj.Clear();
            Txt_SerBroj.Clear();
            Txt_Napomena.Clear();
            CmbAktivno.SelectedIndex = 0;
            Txt_Naziv.Focus();
        }

        private void Oprema_Load(object sender, EventArgs e)
        {
            CmbFilter.SelectedIndex = 0;
            DtUpdate(CmbFilter.Text);
        }

        private void DtUpdate(string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                throw new ArgumentException($"'{nameof(filter)}' cannot be null or empty.", nameof(filter));
            }
            else
            {
                string Dbs = $"SELECT o.id AS Id, o.naziv AS Naziv, o.serbr AS Serijski, o.invbr AS Inventarni, " +
                    $"o.status AS Status, o.datKupovine AS Nabavljeno, o.vijek AS Vijek, o.datZamjene AS Zamjena, " +
                    $"[dc.ime]&' '&[dc.prezime] AS Zadužio, z.datZaduženja AS Zaduženo, z.datRazduženja AS Razduženo, " +
                    $"o.napomena AS Napomena, [d.ime]&' '&[d.prezime] AS Ažurirao, " +
                    $"o.dateEdited AS Ažurirano " +
                    $"FROM (((ictOprema AS o " +
                    $"LEFT JOIN korisnici AS k ON o.korisnikId = k.id) " +
                    $"LEFT JOIN djelatnici AS d ON k.djelatnikId=d.id) " +
                    $"LEFT JOIN zaRaIctOprema AS z ON z.opremaId=o.id) " +
                    $"LEFT JOIN djelatnici AS dc ON z.djelatnikId=dc.id " +
                    $"WHERE o.status ='{filter}' AND z.datZaduženja is NULL OR " +
                    $"z.datZaduženja IN " +
                    $"(SELECT MAX(zaRa2.datZaduženja) FROM zaRaIctOprema AS zaRa2 WHERE zaRa2.opremaId=o.id " +
                    $"AND o.status = '{filter}') " +
                    $"ORDER BY o.dateEdited ASC;";
                DataTable dt = db.Select(Dbs);
                Dgv.DataSource = dt;
                edit.DgvColumnsResize(Dgv);
            }
        }

        private void PromjenaBojePrazneČelije()
        {
            edit.BojaPozadineZaPrazneCeliji(Txt_Naziv);
            edit.BojaPozadineZaPrazneCeliji(Txt_SerBroj);
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Naziv) || edit.NullOrWhite(Txt_SerBroj))
            {
                PromjenaBojePrazneČelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PromjenaBojePrazneČelije();
                var oprema = SetProperties();
                try
                {
                    bool success = controller.Insert(oprema);
                    if (success)
                    {
                        DtUpdate("Novo");
                        Clear();
                    }
                    else
                    {
                        edit.MessageDBErrorInsert();
                    }
                }
                catch (Exception ex)
                {
                    edit.MessageException(ex);
                }
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Naziv) |
                edit.NullOrWhite(Txt_InvBroj) | edit.NullOrWhite(Txt_Vijek))
            {
                PromjenaBojePrazneČelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PromjenaBojePrazneČelije();
                var oprema = SetProperties();
                try
                {
                    bool success = controller.Update(oprema);
                    if (success is true)
                    {
                        DtUpdate(CmbAktivno.Text);
                        Clear();
                    }
                    else
                    {
                        edit.MessageDBErrorUpdate();
                    }
                }
                catch (Exception ex)
                {
                    edit.MessageException(ex);
                }
            }
        }

        private IctOpremaModel SetProperties()
        {

            var oprema = new IctOpremaModel
            {
                Naziv = Txt_Naziv.Text.Trim(),
                SerijskiBroj = Txt_SerBroj.Text.Trim(),
                DatumKupovine = Dtp_Kupljeno.Value.Date,
                StatusOpreme = CmbAktivno.Text.ToString(),
                VijekTrajanja = Convert.ToInt32(Txt_Vijek.Text.Trim()),
                DatumZamjene = Dtp_Kupljeno.Value.AddYears(Convert.ToInt32(Txt_Vijek.Text)).Date,
                Napomena = Txt_Napomena.Text.Trim()
            };
            if (int.Parse(Lbl_Id.Text) > 0)
            {
                oprema.Id = Convert.ToInt32(Lbl_Id.Text);
            }
            if (!edit.NullOrWhite(Txt_InvBroj))
            {
                oprema.InventarniBroj = Txt_InvBroj.Text.Trim();
            }
            return oprema;
        }

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DtUpdate(CmbFilter.Text);
            CmbAktivno.SelectedIndex = CmbFilter.SelectedIndex;
        }

        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            Lbl_Id.Text = Dgv.Rows[rowIndex].Cells[0].Value.ToString();
            Txt_Naziv.Text = Dgv.Rows[rowIndex].Cells[1].Value.ToString();
            Txt_SerBroj.Text = Dgv.Rows[rowIndex].Cells[2].Value.ToString();
            Txt_InvBroj.Text = Dgv.Rows[rowIndex].Cells[3].Value.ToString();
            CmbAktivno.Text = Dgv.Rows[rowIndex].Cells[4].Value.ToString();
            Dtp_Kupljeno.Text = Dgv.Rows[rowIndex].Cells[5].Value.ToString();
            Txt_Vijek.Text = Dgv.Rows[rowIndex].Cells[6].Value.ToString();
            Txt_Napomena.Text = Dgv.Rows[rowIndex].Cells[11].Value.ToString();
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("Naziv LIKE '%{0}%' OR Serijski LIKE '%{0}%' OR inventarni LIKE '%{0}%' OR Zadužio LIKE '%{0}%'", Txt_Search.Text.Trim());
                if (Dgv.Rows[0].Cells[0].Value is null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                edit.MessageException(ex);
            }
        }

        private void dodajNoviUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btn_Insert.PerformClick();
        }

        private void spremiIzmjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btn_Edit.PerformClick();
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
