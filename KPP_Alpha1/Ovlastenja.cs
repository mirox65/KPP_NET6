using KPP_Alpha1.HelperClasses;
using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace KPP_Alpha1
{
    public partial class FormOvlastenja : Form
    {

        readonly DbClass db = new();
        readonly WordHelper wordHelper = new();
        readonly ModelHelper modelHelper = new();
        private readonly string fileName = @"R:\Studenti\DB\KPP_DB\Bianco dokumenti - NE DIRATI\ovlastenja_za_auto_template.doc";
        private readonly string saveAs = @"R:\Studenti\DB\KPP_DB\Bianco dokumenti - NE DIRATI\ovlastenje_za_auto_created.doc";

        private Dictionary<int, string> djelatniciDic = new();
        private Dictionary<int, string> vozilaDic = new();

        public FormOvlastenja()
        {
            InitializeComponent();
            Clear();
            CollectionDjelatnici();
            CollectionVozila();

            if (djelatniciDic.Count > 0)
            {
                djelatniciDic.Clear();
            }
            djelatniciDic = db.DictIntString("ime", "prezime", "djelatnici");
            if (vozilaDic.Count > 0)
            {
                vozilaDic.Clear();
            }
            vozilaDic = db.DictIntString("regOznaka", "vozila");
        }

        // Metoda za kolekciju koja se veže za txtBox Djelatnici za suggest and append
        private void CollectionDjelatnici()
        {
            string DbAc = "SELECT * FROM djelatnici";
            AutoCompleteStringCollection djelatniciCollection = db.AutoComplete(DbAc, "ime", "prezime");
            Txt_Djelatnik.AutoCompleteCustomSource = djelatniciCollection;
        }

        // Metoda za kolekciju koja se veže za txtBox regOznaka za suggest and append
        private void CollectionVozila()
        {
            string DbAc = "SELECT * FROM vozila";
            AutoCompleteStringCollection vozilaCollection = db.AutoComplete(DbAc, "regOznaka");
            Txt_RegOznaka.AutoCompleteCustomSource = vozilaCollection;
        }



        // Brisanje svih polja i fokus na početno polje
        private void Clear()
        {
            Txt_RegOznaka.Clear();
            Txt_Djelatnik.Clear();
            Txt_Djelatnik.Focus();
        }

        private OvlastenjaModel SetProperties()
        {
            var ovlastenje = new OvlastenjaModel();

            ovlastenje.Djelatnik = Txt_Djelatnik.Text;
            ovlastenje.RegOznaka = Txt_RegOznaka.Text;
            ovlastenje.DatumOvlastenja = Dtp_DatumOvlastenja.Value.Date;

            return ovlastenje;
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            var djelatnik = modelHelper.UcitavanjeDjelatnika(djelatniciDic.FirstOrDefault(d => d.Value == Txt_Djelatnik.Text.Trim()).Key);
            var vozilo = modelHelper.UcitavanjeVozila(vozilaDic.FirstOrDefault(v => v.Value == Txt_RegOznaka.Text.Trim()).Key);
            var ovlastenje = SetProperties();

            wordHelper.CreateWordDocument(fileName, saveAs, djelatnik, vozilo, ovlastenje);
            wordHelper.OpenWordDocumentForPrint(saveAs);
        }

        

        
    }



}
