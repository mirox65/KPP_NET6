using KPP_Alpha1.Controller;
using KPP_Alpha1.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class FormKeyCards : Form
    {
        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();
        readonly KarticeUlazController controller = new KarticeUlazController();

        public FormKeyCards()
        {
            InitializeComponent();
            Clear();
            CmbFilter.SelectedIndex = 0;
            DtUpdate(CmbFilter.Text);
        }
        private void Clear()
        {
            Lbl_ID.Text = string.Empty;
            Txt_Naziv.Clear();
            Txt_Napomena.Clear();
            CmbStatus.SelectedIndex = 0;
            Txt_Naziv.Focus();
        }
        private void DtUpdate(string filter)
        {
            string Dbs = $"SELECT kc.id AS ID, kc.naziv AS Naziv, kc.napomena AS Napomena, kc.status AS Status, " +
                $"[dc.ime]&' '&[dc.prezime] AS Zadužio, zc.datZaduženja AS Zaduženo, zc.datRazduženja AS Razduženo, " +
                $"[d.ime]&' '&[d.prezime] AS Ažurirao, kc.ažurirano AS Ažurirano " +
                $"FROM (((keyCards AS kc " +
                $"LEFT JOIN korisnici AS k ON kc.korisnikId=k.id) " +
                $"LEFT JOIN djelatnici AS d ON k.djelatnikId=d.id) " +
                $"LEFT JOIN zaRaKeyCards AS zc ON zc.opremaId=kc.id) " +
                $"LEFT JOIN djelatnici AS dc ON zc.djelatnikId=dc.id " +
                $"WHERE kc.status='{filter}' AND zc.datZaduženja is null " +
                $"OR zc.datZaduženja IN " +
                $"(SELECT MAX(zkc2.datZaduženja) " +
                $"FROM zaRaKeyCards AS zkc2 " +
                $"WHERE zkc2.opremaId=kc.id AND kc.status='{filter}') " +
                $"ORDER BY kc.ažurirano ASC;";
            
            Dgv.DataSource = db.Select(Dbs);
            edit.DgvColumnsResize(Dgv);
        }

        private void PromjenaBojePrazneĆelije()
        {
            edit.BojaPozadineZaPrazneCeliji(Txt_Naziv);
        }
        private KeyCardModel SetProperties()
        {

            var kartica = new KeyCardModel
            {
                Naziv = Txt_Naziv.Text.Trim(),
                Napomena = Txt_Napomena.Text.Trim(),
                Status = CmbStatus.Text.Trim()
            };

            if (Lbl_ID.Text.Length > 0)
            {
                kartica.Id = Convert.ToInt32(Lbl_ID.Text);
            }

            return kartica;
        }
        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Naziv))
            {
                PromjenaBojePrazneĆelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                var kartica = SetProperties();
                try
                {
                    bool success = controller.Insert(kartica);
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
                catch (Exception ex)
                {
                    edit.MessageException(ex);
                }
            }
        }
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Naziv))
            {
                PromjenaBojePrazneĆelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                var kartica = SetProperties();
                try
                {
                    bool success = controller.Update(kartica);
                    if (success is true)
                    {
                        DtUpdate(CmbFilter.Text);
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

        private void Dgv_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            Lbl_ID.Text = Dgv.Rows[rowIndex].Cells[0].Value.ToString();
            Txt_Naziv.Text = Dgv.Rows[rowIndex].Cells[1].Value.ToString();
            Txt_Napomena.Text = Dgv.Rows[rowIndex].Cells[2].Value.ToString();
            CmbStatus.Text = Dgv.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DtUpdate(CmbFilter.Text.ToString());
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("Zadužio LIKE '%{0}%' OR Naziv LIKE '%{0}%' OR Napomena LIKE '%{0}%'",
                    Txt_Search.Text.Trim());
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
