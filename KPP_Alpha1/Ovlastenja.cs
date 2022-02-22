using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;

namespace KPP_Alpha1
{
    public partial class FormOvlastenja : Form
    {

        readonly DbClass db = new DbClass();

        public FormOvlastenja()
        {
            InitializeComponent();
            Clear();
            CollectionDjelatnici();
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

        private void CreateWordDocument(object filename, object SaveAs)
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
                this.FindAndReplace(wordApp, "<name>", Txt_Djelatnik.Text);
                this.FindAndReplace(wordApp, "<auto>", Txt_RegOznaka.Text);
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
            CreateWordDocument(@"C:\Users\palaca\source\repos\KPP\KPP_Alpha1\bin\Debug\template.doc", @"\\zagw19fs01\Users\palaca\Desktop\Ovlastenje.doc");
        }

    }

    
    
}
