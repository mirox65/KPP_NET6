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
    public partial class FormVozila : Form
    {

        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();
        readonly VozilaController controller = new VozilaController();

        public FormVozila()
        {
            InitializeComponent();
            Clear();
            DtUpdate();
        }
        private void Clear()
        {
            Lbl_ID.Text = string.Empty;
            Txt_Proizvodac.Clear();
            Txt_Model.Clear();
            Txt_Opis.Clear();
            Txt_BrSasije.Clear();
            Txt_RegOznaka.Clear();
            Txt_BrUgovora.Clear();
            Txt_Proizvodac.Focus();
        }

        private void DtUpdate()
        {
            string Dbs = $"SELECT * FROM vozila ORDER BY ažurirano ASC;";
            DataTable dt = db.Select(Dbs);
            Dgv.DataSource = dt;
        }

        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            Lbl_ID.Text = Dgv.Rows[rowIndex].Cells[0].Value.ToString();
            Txt_Proizvodac.Text = Dgv.Rows[rowIndex].Cells[1].Value.ToString();
            Txt_Model.Text = Dgv.Rows[rowIndex].Cells[2].Value.ToString();
            Txt_Opis.Text = Dgv.Rows[rowIndex].Cells[3].Value.ToString();
            Txt_BrSasije.Text = Dgv.Rows[rowIndex].Cells[4].Value.ToString();
            Txt_RegOznaka.Text = Dgv.Rows[rowIndex].Cells[5].Value.ToString();
            Txt_BrUgovora.Text = Dgv.Rows[rowIndex].Cells[6].Value.ToString();
        }
        private void PromjenaBojePrazneĆelije()
        {
            edit.BojaPozadineZaPrazneCeliji(Txt_Proizvodac);
            edit.BojaPozadineZaPrazneCeliji(Txt_Model);
            edit.BojaPozadineZaPrazneCeliji(Txt_Opis);
            edit.BojaPozadineZaPrazneCeliji(Txt_BrSasije);
            edit.BojaPozadineZaPrazneCeliji(Txt_RegOznaka);
            edit.BojaPozadineZaPrazneCeliji(Txt_BrUgovora);
        }
        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Proizvodac) || edit.NullOrWhite(Txt_BrSasije) || edit.NullOrWhite(Txt_Model) || edit.NullOrWhite(Txt_Opis) || edit.NullOrWhite(Txt_RegOznaka) || edit.NullOrWhite(Txt_BrUgovora))
            {
                PromjenaBojePrazneĆelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                var vozilo = SetProperties();
                try
                {
                    bool success = controller.Insert(vozilo);
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

        private VozilaModel SetProperties()
        {

            var vozilo = new VozilaModel
            {
                Proizvodac = Txt_Proizvodac.Text.Trim(),
                Model = Txt_Model.Text.Trim(),
                Opis = Txt_Opis.Text.Trim(),
                BrSasije = Txt_BrSasije.Text.ToString(),
                RegOznaka = Txt_RegOznaka.Text.ToString(),
                BrUgovora = Txt_BrUgovora.Text.ToString()
            };

            if (Lbl_ID.Text.Length > 0)
            {
                vozilo.Id = Convert.ToInt32(Lbl_ID.Text);
            }

            return vozilo;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Proizvodac) || edit.NullOrWhite(Txt_BrSasije) || edit.NullOrWhite(Txt_Model) || edit.NullOrWhite(Txt_Opis) || edit.NullOrWhite(Txt_RegOznaka) || edit.NullOrWhite(Txt_BrUgovora))
            {
                PromjenaBojePrazneĆelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                var vozilo = SetProperties();
                try
                {
                    bool success = controller.Update(vozilo);
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
