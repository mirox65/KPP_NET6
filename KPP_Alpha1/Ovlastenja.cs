using KPP_Alpha1.HelperClasses;
using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class FormOvlastenja : Form
    {

        readonly DictionaryHelper dictionary = new();
        readonly AutocompleteHelper autocomplete = new();
        readonly WordHelper wordHelper = new();
        readonly ModelHelper modelHelper = new();

        private readonly string fileName = @"R:\Studenti\DB\KPP_DB\Bianco dokumenti - NE DIRATI\ovlastenja_za_auto_template.docx";
        private readonly string saveAsPath = @"R:\Studenti\DB\KPP_DB\Bianco dokumenti - NE DIRATI\";

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
            djelatniciDic = dictionary.DictIntString("ime", "prezime", "djelatnici");
            if (vozilaDic.Count > 0)
            {
                vozilaDic.Clear();
            }
            vozilaDic = dictionary.DictIntString("regOznaka", "vozila");
        }

        // Metoda za kolekciju koja se veže za txtBox Djelatnici za suggest and append
        private void CollectionDjelatnici()
        {
            string DbAc = "SELECT * FROM djelatnici";
            AutoCompleteStringCollection djelatniciCollection = autocomplete.AutoComplete(DbAc, "ime", "prezime");
            Txt_Djelatnik.AutoCompleteCustomSource = djelatniciCollection;
        }

        // Metoda za kolekciju koja se veže za txtBox regOznaka za suggest and append
        private void CollectionVozila()
        {
            string DbAc = "SELECT * FROM vozila";
            AutoCompleteStringCollection vozilaCollection = autocomplete.AutoComplete(DbAc, "regOznaka");
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
            OvlastenjaModel ovlastenje = new();

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

            var saveAs = $"{saveAsPath}Ovlaštenje_{ovlastenje.Djelatnik}_{ovlastenje.RegOznaka}.docx";
            wordHelper.CreateWordDocument(fileName, saveAs, djelatnik, vozilo, ovlastenje);
            wordHelper.OpenWordDocumentForPrint(saveAs);
        }
    }
}
