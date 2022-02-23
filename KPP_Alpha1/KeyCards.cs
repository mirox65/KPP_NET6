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
    public partial class FormKeyCards : Form
    {
        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();
        readonly KarticeUlazController controller = new KarticeUlazController();
        public FormKeyCards()
        {
            InitializeComponent();
            Clear();
            DtUpdate();
        }
        private void Clear()
        {
            Lbl_ID.Text = string.Empty;
            Txt_Naziv.Clear();
            Txt_Naziv.Focus();
        }
        private void DtUpdate()
        {
            string Dbs = $"SELECT * FROM keyCards ORDER BY ažurirano ASC;";
            DataTable dt = db.Select(Dbs);
            Dgv.DataSource = dt;
        }
        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            Lbl_ID.Text = Dgv.Rows[rowIndex].Cells[0].Value.ToString();
            Txt_Naziv.Text = Dgv.Rows[rowIndex].Cells[1].Value.ToString();
        }
        private void PromjenaBojePrazneĆelije()
        {
            edit.BojaPozadineZaPrazneCeliji(Txt_Naziv);
        }
        private KarticeUlazModel SetProperties()
        {

            var kartica = new KarticeUlazModel
            {
                Naziv = Txt_Naziv.Text.Trim(),
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
                        DtUpdate();
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
    }
}
