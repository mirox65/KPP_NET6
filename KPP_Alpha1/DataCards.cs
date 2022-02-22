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
        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();
        readonly DataCardsController controller = new DataCardsController();

        public FormDataCards()
        {
            InitializeComponent();
            Clear();
        }

        private void Clear()
        {
            Lbl_Id.Text = string.Empty;
            Txt_Imei.Text = string.Empty;
            Txt_SerBr.Text = string.Empty;
            Txt_Search.Text = string.Empty;
            Lbl_Imei.Focus();
        }

        private void DataCards_Load(object sender, EventArgs e)
        {
            DtUpdate();
        }

        private void DtUpdate()
        {
            var Dbs = "SELECT dc.id AS Id, dc.imei AS Imei, dc.serBr AS SerBr, [d.ime]&' '&[d.prezime] AS Korisnik," +
                "dc.ažurirano AS Ažurirano FROM (dataCards AS dc " +
                "LEFT JOIN korisnici AS k ON dc.korisnikId=k.id)" +
                "LEFT JOIN djelatnici AS d ON k.djelatnikId=d.id;";
            DataTable dt = db.Select(Dbs);
            Dgv.DataSource = dt;
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
                        DtUpdate();
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
                        DtUpdate();
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
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("imei LIKE '%{0}%' OR serBr LIKE '%{0}%'", Txt_Search.Text.Trim());
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
    }
}
