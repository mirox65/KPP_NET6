using KPP_Alpha1.Controller;
using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    /// <summary>
    /// Zadužnice i razdužnice klasa namjenjana za pračenje opreme
    /// koja se nalazi kod djelatnika da nemamo repova. 
    /// Zaduženja raditi odmah kad se oprema izdaje a razudžnica tek
    /// kad se oprema vrati u ured
    /// </summary>
    public partial class FormZaRa : Form
    {
        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();
        readonly ZaRaController controller = new ZaRaController();

        private Dictionary<int, string> djelatniciDic = new Dictionary<int, string>();
        private Dictionary<string, int> opremaDic = new Dictionary<string, int>();
        private Dictionary<string, string> opremaBazaDic = new Dictionary<string, string>();

        public Dictionary<string, int> OpremaDic { get; set; }
        public Dictionary<string, string> OpremaBaza { get; set; }

        public FormZaRa()
        {
            InitializeComponent();
            Clear();
            if (djelatniciDic.Count > 0)
            {
                djelatniciDic.Clear();
            }
            djelatniciDic = db.DictIntString("ime", "prezime", "djelatnici");
            if (opremaDic.Count > 0)
            {
                opremaDic.Clear();
            }
            opremaDic = UčitavanjeOpremaDictionary();
            if (opremaBazaDic.Count > 0)
            {
                opremaBazaDic.Clear();
            }
            opremaBazaDic = UčitavanjeBazaDictionary();
            CoollectionDjelatnici();
            CollectionOprema();
        }

        private void CollectionOprema()
        {
            var DbIct = "SELECT * FROM ictOprema;";
            var DbDc = "SELECT * FROM dataCards;";
            var AcOprema = db.AutoComplete(DbIct, "serBr", "naziv");
            AcOprema = db.AutoComplete(DbDc, "imei", "SerBr");
            Txt_Oprema.AutoCompleteCustomSource = AcOprema;
        }

        private void CoollectionDjelatnici()
        {
            var DbAc = "SELECT * FROM djelatnici;";
            var AcDjelatnici = db.AutoComplete(DbAc, "ime", "prezime");
            Txt_Djelatnik.AutoCompleteCustomSource = AcDjelatnici;
        }

        private Dictionary<string, string> UčitavanjeBazaDictionary()
        {
            OpremaBaza = db.DictStringString(opremaBazaDic, "serBr", "naziv", "zaRaIct", "ictOprema");
            OpremaBaza = db.DictStringString(OpremaBaza, "imei", "serBr", "zaRaDataCards", "dataCards");
            return opremaBazaDic;
        }

        private Dictionary<string, int> UčitavanjeOpremaDictionary()
        {
            OpremaDic = db.DicStringInt(opremaDic, "serBr", "naziv", "ictOprema");

            OpremaDic = db.DicStringInt (OpremaDic, "imei", "serBr", "dataCards");
            return OpremaDic;
        }

        private void Clear()
        {
            Lbl_Id.Text = string.Empty;
            Txt_Djelatnik.Clear();
            Txt_Oprema.Clear();
            CmbFilter.SelectedIndex = 0;
            CmbZaRa.SelectedIndex = 0;
        }

        private void Btn_Pretraži_Click(object sender, EventArgs e)
        {
            var djelatnikId = djelatniciDic.FirstOrDefault(d => d.Value == Txt_Djelatnik.Text.Trim()).Key;
            string Dbs = $"SELECT z.id AS Id, [i.serBr]&' '&[i.naziv] AS Oprema, z.datZaduženja AS Zaduženo, " +
                $"datRazduženja AS Razduženo, [d.ime]&' '&[d.prezime] AS Korisnik, z.ažurirano AS Ažurirano " +
                $"FROM ((zaraIct AS z " +
                $"LEFT JOIN ictOprema AS i ON z.opremaId = i.id) " +
                $"LEFT JOIN korisnici AS k ON z.korisnikId = k.id)" +
                $"LEFT JOIN djelatnici AS d ON k.djelatnikId = d.id " +
                $"WHERE z.djelatnikId={djelatnikId};";
            var lista = db.Select(Dbs);
            string D2 = "SELECT z.id AS Id, [dc.imei]&' '&[dc.serBr] AS Oprema, z.datZaduženja AS Zaduženo, " +
                "z.datRazduženja AS Razduženo, [d.ime]&' '&[d.prezime] AS Korisnik, z.ažurirano AS Ažurirano " +
                "FROM ((zaRaDataCards AS z " +
                "LEFT JOIN dataCards AS dc ON z.opremaId=dc.id) " +
                "LEFT JOIN korisnici AS k ON z.korisnikId=k.id) " +
                "LEFT JOIN djelatnici AS d ON k.djelatnikId=d.id " +
                $"WHERE z.djelatnikId={djelatnikId};";
            lista.Merge(db.Select(D2));
            Dgv.DataSource = lista;
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Djelatnik) | edit.NullOrWhite(Txt_Oprema))
            {
                PromjenaBojePrazneČelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PromjenaBojePrazneČelije();
                var zaRa = SetProperties();
                bool provjera = ProvjeraKljučeva(zaRa);
                if (provjera)
                {
                    try
                    {
                        bool success = controller.Insert(zaRa);
                        if (success is true)
                        {
                            Btn_Pretraži.PerformClick();
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
                else
                {
                    edit.MessageErrorKeyMissing();
                }
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (edit.NullOrWhite(Txt_Djelatnik) | edit.NullOrWhite(Txt_Oprema))
            {
                PromjenaBojePrazneČelije();
                edit.PorukaPraznaCelija();
            }
            else
            {
                PromjenaBojePrazneČelije();
                var zaRa = SetProperties();
                bool provjera = ProvjeraKljučeva(zaRa);
                if (provjera)
                {
                    try
                    {
                        var success = false;
                        if (CmbZaRa.Text == "Razduženje")
                        {
                            success = controller.UpdateRazudženje(zaRa);
                        }
                        else
                        {
                            success = controller.Update(zaRa);
                        }
                        if (success is true)
                        {
                            Btn_Pretraži.PerformClick();
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
                else
                {
                    edit.MessageErrorKeyMissing();
                }
            }

        }

        private bool ProvjeraKljučeva(ZaRaModel zaRa)
        {
            var provjera = false;
            if (zaRa.DjelatnikId > 0 & zaRa.OpremaId > 0 & zaRa.NazivZaRaTablice.Length > 0)
            {
                provjera = true;
            }
            return provjera;
        }

        private ZaRaModel SetProperties()
        {
            var zaRa = new ZaRaModel();
            if (CmbZaRa.Text == "Razduživanje")
            {
                zaRa.DatumRazduženja = Dtp_Razduženo.Value.Date;
            }
            else
            {
                zaRa.DjelatnikId = djelatniciDic.FirstOrDefault(d => d.Value == Txt_Djelatnik.Text.Trim()).Key;
                zaRa.OpremaId = opremaDic.FirstOrDefault(o => o.Key == Txt_Oprema.Text.Trim()).Value;
                zaRa.NazivZaRaTablice = opremaBazaDic.FirstOrDefault(b => b.Key == Txt_Oprema.Text.Trim()).Value;
                zaRa.DatumZaduženja = Dtp_Zaduženo.Value.Date;
            }            
            if (Lbl_Id.Text.Length > 0)
            {
                zaRa.Id = Convert.ToInt32(Lbl_Id.Text);
            }
            return zaRa;
        }

        private void PromjenaBojePrazneČelije()
        {
            edit.BojaPozadineZaPrazneCeliji(Txt_Djelatnik);
            edit.BojaPozadineZaPrazneCeliji(Txt_Oprema);
        }

        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            Lbl_Id.Text = Dgv.Rows[rowIndex].Cells[0].Value.ToString();
            Txt_Oprema.Text = Dgv.Rows[rowIndex].Cells[1].Value.ToString();
            Txt_Djelatnik.Text = Dgv.Rows[rowIndex].Cells[2].Value.ToString();
            Dtp_Zaduženo.Text = Dgv.Rows[rowIndex].Cells[3].Value.ToString();
        }
    }
}
