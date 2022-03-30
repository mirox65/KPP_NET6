using KPP_Alpha1.Controller;
using KPP_Alpha1.HelperClasses;
using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class DjelatniciBasic : Form
    {
        private readonly DbClass db = new();
        private readonly EditClass edit = new();
        private readonly DictionaryHelper dictionary = new();
        private readonly AutocompleteHelper autocomplete = new();
        private readonly DoubleCheckHelper doubleCheck = new();
        private readonly DjelatniciBasicController controller = new();

        private int setId;
        private readonly Dictionary<int, string> dictionaryDjelatnik = new();
        private readonly Dictionary<int, string> dictionaryMjesta = new();

        public DjelatniciBasic()
        {
            InitializeComponent();
            Clear();
            DtUpdate();
            dictionaryDjelatnik = dictionary.DictIntString("ime", "prezime", "djelatnici");
            dictionaryMjesta = dictionary.DictIntString("mjesto", "ptt", "mjesta");
            AutoCompleteCollections();
        }

        private void AutoCompleteCollections()
        {
            Txt_Djelatnik.AutoCompleteCustomSource = autocomplete.AutoComplete("djelatnici", "ime", "prezime");
            Txt_Mjesto.AutoCompleteCustomSource = autocomplete.AutoComplete("mjesta", "mjesto", "ptt");
        }

        private void DtUpdate()
        {
            var select = $"SELECT db.id AS Id, [d.ime]&' '&[d.prezime] AS Djelatnik, [db.position] AS Pozicija, db.chartNumber AS ChartNum, " +
                $"db.workRelationship AS Odnos, db.workRegion AS Regija, db.adresa AS Adresa, [m.mjesto]&' '&[m.ptt] AS Grad, db.dateOfBirth AS Rođendan, " +
                $"db.spol AS Spol, [dk.ime]&' '&[dk.prezime] AS Ažurirao, db.ažurirano AS Ažurirano " +
                $"FROM (((djelatniciBasic AS db " +
                $"LEFT JOIN djelatnici AS d ON db.djelatnikId=d.id) " +
                $"LEFT JOIN mjesta AS m ON db.mjestoId=m.id) " +
                $"LEFT JOIN korisnici AS k ON db.korisnikId=k.id) " +
                $"LEFT JOIN djelatnici AS dk ON k.djelatnikId=dk.id;";
            Dgv.DataSource = db.Select(select);
            edit.DgvColumnsResize(Dgv);
        }

        private void Clear()
        {
            setId = 0;
            Txt_Djelatnik.Clear();
            Txt_Adresa.Clear();
            Txt_Search.Clear();
            Txt_ChartNumber.Clear();
            Txt_Mjesto.Clear();
            Txt_Position.Clear();
            Txt_WorkRegion.Clear();
            Txt_WorkRelationship.Clear();
            Dtp_DateOfBirth.Value = DateTime.Now.Date;
            Cmb_Spol.SelectedIndex = 0;
            Txt_Djelatnik.Focus();
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Djelatnik) || edit.NullOrWhite(Txt_Mjesto))
            {
                PrazneCelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var djelatnikBasic = SetProperties();
                var provjeraKljučeva = ProvjeraKljučeva(djelatnikBasic);
                var duplikat = doubleCheck.DoubleInsertChecker("djelatnikId", "djelatniciBasic", djelatnikBasic.DjelatnikId);
                if (duplikat && provjeraKljučeva)
                {
                    Insert(djelatnikBasic);
                    DtUpdate();
                    Clear();
                }
                else
                {
                    if (provjeraKljučeva is false)
                    {
                        edit.MessageErrorKeyMissing();
                    }
                    if (duplikat is false)
                    {
                        edit.MessageDuplikat();
                    }
                }
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Djelatnik) || edit.NullOrWhite(Txt_Mjesto))
            {
                PrazneCelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PrazneCelije();
                var djelatnikBasic = SetProperties();
                var provjeraKljučeva = ProvjeraKljučeva(djelatnikBasic);
                var idForEdit = djelatnikBasic.Id > 0;
                if (provjeraKljučeva && idForEdit)
                {
                    Update(djelatnikBasic);
                    DtUpdate();
                    Clear();
                }
                else
                {
                    if (provjeraKljučeva is false)
                    {
                        edit.MessageErrorKeyMissing();
                    }
                    if (idForEdit is false)
                    {
                        edit.MessageNijeOdabranaStavka();
                    }
                }
            }
        }

        private void Insert(DjelatnikBasicModel djelatnikBasic)
        {
            try
            {
                bool success = controller.Insert(djelatnikBasic);
                if (success is false)
                {
                    edit.MessageDBErrorInsert();
                }
            }
            catch (Exception ex)
            {
                edit.MessageException(ex);
            }
        }


        private void Update(DjelatnikBasicModel djelatnikBasic)
        {
            try
            {
                bool success = controller.Update(djelatnikBasic);
                if (success is false)
                {
                    edit.MessageDBErrorUpdate();
                }
            }
            catch (Exception ex)
            {
                edit.MessageException(ex);
            }
        }

        private bool ProvjeraKljučeva(DjelatnikBasicModel djelatnikBasic)
        {
            bool provjera = false;
            if (djelatnikBasic.DjelatnikId > 0 && djelatnikBasic.MjestoId > 0)
            {
                provjera = true;
            }
            return provjera;
        }

        private DjelatnikBasicModel SetProperties()
        {
            var djelatnikBasic = new DjelatnikBasicModel();
            if (setId > 0)
            {
                djelatnikBasic.Id = setId;
            }
            djelatnikBasic.DjelatnikId = dictionaryDjelatnik.FirstOrDefault(d => d.Value == Txt_Djelatnik.Text.Trim()).Key;
            djelatnikBasic.DateOfBirth = Dtp_DateOfBirth.Value.Date;
            djelatnikBasic.Spol = Cmb_Spol.Text;
            djelatnikBasic.Adresa = Txt_Adresa.Text.Trim();
            djelatnikBasic.MjestoId = dictionaryMjesta.FirstOrDefault(m => m.Value == Txt_Mjesto.Text.Trim()).Key;
            djelatnikBasic.Postion = Txt_Position.Text.Trim();
            djelatnikBasic.ChartNumber = Txt_ChartNumber.Text.Trim();
            djelatnikBasic.WorkRegion = Txt_WorkRegion.Text.Trim();
            djelatnikBasic.WorkRelationship = Txt_WorkRelationship.Text.Trim();

            return djelatnikBasic;
        }

        private void PrazneCelije()
        {
            edit.BojaPozadineZaPrazneCeliji(Txt_Mjesto);
            edit.BojaPozadineZaPrazneCeliji(Txt_Djelatnik);
        }

        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rowIndex = e.RowIndex;
            setId = int.Parse(Dgv.Rows[rowIndex].Cells[0].Value.ToString());
            Txt_Djelatnik.Text = Dgv.Rows[rowIndex].Cells[1].Value.ToString();
            Txt_Position.Text = Dgv.Rows[rowIndex].Cells[2].Value.ToString();
            Txt_ChartNumber.Text = Dgv.Rows[rowIndex].Cells[3].Value.ToString();
            Txt_WorkRelationship.Text = Dgv.Rows[rowIndex].Cells[4].Value.ToString();
            Txt_WorkRegion.Text = Dgv.Rows[rowIndex].Cells[5].Value.ToString();
            Txt_Adresa.Text = Dgv.Rows[rowIndex].Cells[6].Value.ToString();
            Txt_Mjesto.Text = Dgv.Rows[rowIndex].Cells[7].Value.ToString();
            Dtp_DateOfBirth.Text = Dgv.Rows[rowIndex].Cells[8].Value.ToString();
            Cmb_Spol.Text = Dgv.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btn_Insert.PerformClick();
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btn_Update.PerformClick();
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("djelatnik LIKE '%{0}%' OR grad LIKE '%{0}%' OR pozicija LIKE '%{0}%' OR chartnum LIKE '%{0}%'", Txt_Search.Text.Trim());
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
