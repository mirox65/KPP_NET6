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
    public partial class FormUsersData : Form
    {
        readonly DbClass db = new();
        readonly EditClass edit = new();
        readonly AutocompleteHelper autocomplete = new();
        readonly DictionaryHelper dictionary = new();
        readonly UsersDataController controller = new();
        readonly DoubleCheckHelper doubleCheck = new();

        private Dictionary<int, string> djelatniciDic = new();

        int setId;

        public FormUsersData()
        {
            InitializeComponent();
            DtUpdate();
            CollectionDjelatnici();
            djelatniciDic = dictionary.DictIntString("ime", "prezime", "djelatnici");
        }
        private void CollectionDjelatnici()
        {
            Txt_Djelatnik.AutoCompleteCustomSource = autocomplete.AutoComplete("djelatnici", "ime", "prezime");
        }
        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Username) || edit.NullOrWhite(Txt_Password))
            {
                PromjenaBojePrazneĆelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PromjenaBojePrazneĆelije();
                var usersData = SetProperties();
                bool provjeraKljučeva = usersData.DjelatnikId > 0;
                bool dupli = doubleCheck.DoubleInsertChecker("djelatnikId", "usersData", usersData.DjelatnikId);
                if (provjeraKljučeva && dupli)
                {
                    Insert(usersData);
                    DtUpdate();
                    Clear();
                }
            }
        }

        private void Insert(UsersDataModel usersData)
        {
            try
            {
                bool success = controller.Insert(usersData);
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
        private void Clear()
        {
            setId = 0;
            Txt_Djelatnik.Clear();
            Txt_Username.Clear();
            Txt_Password.Clear();
            Txt_Email.Clear();
            Txt_PhoneNumber.Clear();
            Txt_Search.Clear();
            Txt_Djelatnik.Focus();
        }
        private void DtUpdate()
        {
            string Dbs = "SELECT u.id AS ID, [d.ime]&' '&[d.prezime] AS Djelatnik, u.username AS KorisničkoIme, " +
               "u.[password] AS Lozinka, u.email AS Email, u.phoneNumber AS PhoneNumber, " +
               "[kd.ime]&' '&[kd.prezime] AS Ažurirao, u.ažurirano AS Ažurirano " +
               "FROM ((usersData AS u " +
               "LEFT JOIN djelatnici AS d ON u.djelatnikId=d.id) " +
               "LEFT JOIN korisnici AS k ON u.korisnikId = k.id) " +
               "LEFT JOIN djelatnici AS kd ON k.djelatnikId=kd.id " +
               "ORDER BY u.ažurirano ASC;";
            Dgv.DataSource = db.Select(Dbs);
            edit.DgvColumnsResize(Dgv);
        }
        private UsersDataModel SetProperties()
        {
            var usersData = new UsersDataModel
            {
                DjelatnikId = djelatniciDic.FirstOrDefault(d => d.Value == Txt_Djelatnik.Text.Trim()).Key,
                Username = Txt_Username.Text.Trim(),
                Password = Txt_Password.Text.Trim(),
                Email = Txt_Email.Text.Trim(),
                PhoneNumber = Txt_PhoneNumber.Text.Trim()
            };
            if (setId > 0)
            {
                usersData.Id = setId;
            }
            return usersData;
        }
        private void PromjenaBojePrazneĆelije()
        {
            edit.BojaPozadineZaPrazneCeliji(Txt_Username);
            edit.BojaPozadineZaPrazneCeliji(Txt_Password);
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Username) || edit.NullOrWhite(Txt_Password))
            {
                PromjenaBojePrazneĆelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PromjenaBojePrazneĆelije();
                var usersData = SetProperties();
                bool provjeraKljučeva = usersData.DjelatnikId > 0;
                if (provjeraKljučeva)
                {
                    Update(usersData);
                    DtUpdate();
                    Clear(); 
                }
            }
        }

        private void Update(UsersDataModel usersData)
        {
            try
            {
                bool success = controller.Update(usersData);
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

        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            setId = int.Parse(Dgv.Rows[rowIndex].Cells[0].Value.ToString());
            Txt_Djelatnik.Text = Dgv.Rows[rowIndex].Cells[1].Value.ToString();
            Txt_Username.Text = Dgv.Rows[rowIndex].Cells[2].Value.ToString();
            Txt_Password.Text = Dgv.Rows[rowIndex].Cells[3].Value.ToString();
            Txt_Email.Text = Dgv.Rows[rowIndex].Cells[4].Value.ToString();
            Txt_PhoneNumber.Text = Dgv.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Dgv.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("Djelatnik LIKE '%{0}%' OR PhoneNumber LIKE '%{0}%' OR Email LIKE '%{0}%' OR KorisničkoIme LIKE '%{0}%'", Txt_Search.Text.Trim());
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

        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btn_Insert.PerformClick();
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btn_Edit.PerformClick();
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
