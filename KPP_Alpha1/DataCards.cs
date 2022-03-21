using KPP_Alpha1.Controller;
using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class FormDataCards : Form
    {
        readonly DbClass db = new ();
        readonly EditClass edit = new ();
        readonly DataCardsController controller = new ();

        public FormDataCards()
        {
            InitializeComponent();
            Clear();
            CmbFilter.SelectedIndex = 0;
        }

        private void Clear()
        {
            Lbl_Id.Text = string.Empty;
            Txt_Imei.Clear();
            Txt_SerBr.Clear();
            Txt_Search.Clear();
            CmbStatus.SelectedIndex = 0;
            Txt_Napomena.Clear();
            Lbl_Imei.Focus();
        }

        private void DataCards_Load(object sender, EventArgs e)
        {
            DtUpdate(CmbFilter.Text);
        }

        private void DtUpdate(string filter)
        {
            var Dbs = "SELECT dc.id AS Id, dc.imei AS Imei, dc.serBr AS SerBr, [dz.ime]&' '&[dz.prezime] AS Zadužio, " +
                "zc.datZaduženja AS Zaduženo, zc.datRazduženja AS Razduženo, dc.status AS Status, dc.napomena AS Napomena, " +
                "[d.ime]&' '&[d.prezime] AS Ažurirao, dc.ažurirano AS Ažurirano " +
                "FROM (((dataCards AS dc " +
                "LEFT JOIN korisnici AS k ON dc.korisnikId=k.id) " +
                "LEFT JOIN djelatnici AS d ON k.djelatnikId=d.id) " +
                "LEFT JOIN zaRaDataCards AS zc ON zc.opremaId=dc.id) " +
                "LEFT JOIN djelatnici AS dz ON zc.djelatnikId=dz.id " +
                $"WHERE dc.status='{filter}' AND zc.datZaduženja IS NULL " +
                $"OR zc.datZaduženja IN " +
                $"(SELECT MAX(zaRa2.datZaduženja) " +
                $"FROM zaRaDataCards AS zaRa2 " +
                $"WHERE zaRa2.opremaId=dc.id AND dc.status='{filter}');";

            DataTable dt = db.Select(Dbs);
            Dgv.DataSource = dt;
            edit.DgvColumnsResize(Dgv);
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Imei) |edit.NullOrWhite(Txt_SerBr))
            {
                PromjenaBojePrazneČelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PromjenaBojePrazneČelije();
                var dataCard = SetProperties();
                try
                {
                    bool success = controller.Insert(dataCard);
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
            if (edit.NullOrWhite(Txt_Imei) | edit.NullOrWhite(Txt_SerBr))
            {
                PromjenaBojePrazneČelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PromjenaBojePrazneČelije();
                var dataCard = SetProperties();
                try
                {
                    bool success = controller.Update(dataCard);
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

        private DataCardModel SetProperties()
        {
            var dataCard = new DataCardModel();
            if (Lbl_Id.Text.Length > 0)
            {
                dataCard.Id = Convert.ToInt32( Lbl_Id.Text);
            }
            dataCard.Imei = Txt_Imei.Text;
            dataCard.SerBr = Txt_SerBr.Text;
            dataCard.Status = CmbStatus.Text;
            dataCard.Napomena = Txt_Napomena.Text;
            return dataCard;
        }

        private void PromjenaBojePrazneČelije()
        {
            edit.BojaPozadineZaPrazneCeliji(Txt_Imei);
            edit.BojaPozadineZaPrazneCeliji(Txt_SerBr);
        }

        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rowIndex = e.RowIndex;
            Lbl_Id.Text = Dgv.Rows[rowIndex].Cells[0].Value.ToString();
            Txt_Imei.Text = Dgv.Rows[rowIndex].Cells[1].Value.ToString();
            Txt_SerBr.Text = Dgv.Rows[rowIndex].Cells[2].Value.ToString();
            CmbStatus.Text = Dgv.Rows[rowIndex].Cells[6].Value.ToString();
            Txt_Napomena.Text = Dgv.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("imei LIKE '%{0}%' OR serBr LIKE '%{0}%' OR zadužio LIKE '%{0}%'", Txt_Search.Text.Trim());
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

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DtUpdate(CmbFilter.Text);
        }
    }
}
