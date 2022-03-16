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

        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object matchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitis = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute2007(ref ToFindText,
                ref matchCase, ref matchWholeWord, ref matchWildCards, ref matchSoundLike, ref matchAllforms,
                ref forward, ref wrap, ref format, ref replaceWithText, ref replace, ref matchKashida,
                ref matchDiactitis, ref matchAlefHamza, ref matchControl);
        }

        private void CreateWordDocument(object filename, object SaveAs, DjelatnikModel djelatnik, VozilaModel vozilo)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                this.FindAndReplace(wordApp, "<ime_prezime>", Txt_Djelatnik.Text);
                this.FindAndReplace(wordApp, "<oib>", djelatnik.Oib);
                this.FindAndReplace(wordApp, "<br_ugovora>", vozilo.BrUgovora);
                this.FindAndReplace(wordApp, "<marka_vozila>", vozilo.Proizvodac);
                this.FindAndReplace(wordApp, "<model_vozila>", $"{vozilo.Model} {vozilo.Opis}");
                this.FindAndReplace(wordApp, "<br_sasije>", vozilo.BrSasije);
                this.FindAndReplace(wordApp, "<reg_oznaka>", Txt_RegOznaka.Text);
                this.FindAndReplace(wordApp, "<datum>", Dtp_DatumOvlastenja.Value.Date);
            }
            else
            {
                MessageBox.Show("File not found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("Ovlaštenje kreirano!");
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            DjelatnikModel djelatnik = UcitavanjeDjelatnika();
            VozilaModel vozilo = UcitavanjeVozila();
            CreateWordDocument(fileName, saveAs, djelatnik, vozilo);
            OpenWordDocumentForPrint(saveAs);
        }

        private static void OpenWordDocumentForPrint(string wordToOpen)
        {
            Word.Application ap = new();
            ap.Documents.Open(wordToOpen);
            ap.Visible = true;
        }

        private VozilaModel UcitavanjeVozila()
        {
            var id = vozilaDic.FirstOrDefault(v => v.Value == Txt_RegOznaka.Text.Trim()).Key;
            var select = $"SELECT * FROM vozila WHERE id = {id}";
            var dt = db.Select(select);

            var vozilo = new VozilaModel();

            foreach (DataRow row in dt.Rows)
            {
                vozilo.Id = Convert.ToInt32(row["ID"].ToString());
                vozilo.Proizvodac = row["proizvođač"].ToString();
                vozilo.Model = row["model"].ToString();
                vozilo.Opis = row["opis"].ToString();
                vozilo.BrSasije = row["brŠasije"].ToString();
                vozilo.BrUgovora = row["brUgovora"].ToString();
            }

            return vozilo;
        }

        private DjelatnikModel UcitavanjeDjelatnika()
        {
            var id = djelatniciDic.FirstOrDefault(d => d.Value == Txt_Djelatnik.Text.Trim()).Key;
            var select = $"SELECT * FROM djelatnici WHERE id = {id}";
            var dt = db.Select(select);

            DjelatnikModel djelatnik = new DjelatnikModel();

            foreach (DataRow row in dt.Rows)
            {
                djelatnik.Id = Convert.ToInt32(row["id"].ToString());
                djelatnik.Oib = row["oib"].ToString();
            }

            return djelatnik;
        }
    }



}
