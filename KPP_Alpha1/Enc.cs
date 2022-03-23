using KPP_Alpha1.Controller;
using KPP_Alpha1.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class FormEnc : Form
    {
        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();
        readonly EncController controller = new EncController();

        public FormEnc()
        {
            InitializeComponent();
            Clear();
        }

        private void Clear()
        {
            Lbl_Id.Text = string.Empty;
            Txt_Naziv.Clear();
            Txt_Search.Clear();
            Txt_Napomena.Clear();
            CmbStatus.SelectedIndex = 0;
            Txt_Naziv.Focus();
        }

        private void FormEnc_Load(object sender, EventArgs e)
        {
            CmbFilter.SelectedIndex = 0;
            DtUpdate(CmbFilter.Text);
        }

        private void DtUpdate(string filter)
        {
            var dbs = "SELECT e.id AS Id, e.naziv AS Naziv, [dz.ime]&' '&[dz.prezime] AS Zadužio, " +
                "ze.datZaduženja AS Zaduženo, ze.datRazduženja AS Razdužio, e.status AS Status, " +
                "e.napomena AS Napomena, [d.ime]&' '&[d.prezime] AS Ažurirao, e.ažurirano AS Ažurirano " +
                "FROM (((enc AS e " +
                "LEFT JOIN korisnici AS k ON e.korisnikId=k.id) " +
                "LEFT JOIN djelatnici AS d ON k.djelatnikId=d.id) " +
                "LEFT JOIN zaRaEnc AS ze ON ze.opremaId=e.id) " +
                "LEFT JOIN djelatnici dz ON ze.djelatnikId=dz.id " +
                $"WHERE e.status='{filter}' AND ze.datZaduženja IS NULL " +
                $"OR ze.datZaduženja IN " +
                $"(SELECT MAX(zaRa2.datZaduženja) " +
                $"FROM zaRaEnc AS zaRa2 " +
                $"WHERE zaRa2.opremaId=e.id AND e.status='{filter}');";

            var dt = db.Select(dbs);
            Dgv.DataSource = dt;
            edit.DgvColumnsResize(Dgv);
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Naziv))
            {
                edit.BojaPozadineZaPrazneCeliji(Txt_Naziv);
                edit.PorukaPraznaCelija();
            }
            else
            {
                edit.BojaPozadineZaPrazneCeliji(Txt_Naziv);
                EncModel enc = SetProperties();
                bool success = controller.Insert(enc);
                if (success)
                {
                    DtUpdate(CmbFilter.Text);
                    Clear();
                }
                else
                {
                    edit.MessageDBErrorInsert();
                }
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Naziv))
            {
                edit.BojaPozadineZaPrazneCeliji(Txt_Naziv);
                edit.PorukaPraznaCelija();
            }
            else
            {
                edit.BojaPozadineZaPrazneCeliji(Txt_Naziv);
                EncModel enc = SetProperties();
                bool success = controller.Update(enc);
                if (success)
                {
                    DtUpdate(CmbFilter.Text);
                    Clear();
                }
                else
                {
                    edit.MessageDBErrorUpdate();
                }
            }
        }

        private EncModel SetProperties()
        {
            var enc = new EncModel();
            if (Lbl_Id.Text.Length > 0)
            {
                enc.Id = Convert.ToInt32(Lbl_Id.Text);
            }
            enc.Naziv = Txt_Naziv.Text.Trim();
            enc.Status = CmbStatus.Text;
            enc.Napomena = Txt_Napomena.Text.Trim();

            return enc;
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("naziv LIKE '%{0}%' OR zadužio LIKE '%{0}%'", Txt_Search.Text.Trim());
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

        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rowIndex = e.RowIndex;
            Lbl_Id.Text = Dgv.Rows[rowIndex].Cells[0].Value.ToString();
            Txt_Naziv.Text = Dgv.Rows[rowIndex].Cells[1].Value.ToString();
            CmbStatus.Text = Dgv.Rows[rowIndex].Cells[5].Value.ToString();
            Txt_Napomena.Text = Dgv.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void InsertTSMI_Click(object sender, EventArgs e)
        {
            Btn_Insert.PerformClick();
        }

        private void UpdateTSMI_Click(object sender, EventArgs e)
        {
            Btn_Edit.PerformClick();
        }

        private void ClearTSMI_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DtUpdate(CmbFilter.Text);
        }
    }
}
