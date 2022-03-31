using KPP_Alpha1.Models;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace KPP_Alpha1.HelperClasses
{
    internal class WordHelper
    {
        //Find and Replace metoda za Word
        public void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object matchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute2007(ref ToFindText,
                ref matchCase, ref matchWholeWord, ref matchWildCards, ref matchSoundLike, ref matchAllforms,
                ref forward, ref wrap, ref format, ref replaceWithText, ref replace, ref matchKashida,
                ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }
        //Kreiranje word dokumenta - Ovlaštenja
        public void CreateWordDocument(object filename, object SaveAs, DjelatnikModel djelatnik, VozilaModel vozilo, OvlastenjaModel ovlastenje)
        {
            Word.Application wordApp = new();
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
                FindAndReplace(wordApp, "<ime_prezime>", ovlastenje.Djelatnik);
                FindAndReplace(wordApp, "<oib>", djelatnik.Oib);
                FindAndReplace(wordApp, "<br_ugovora>", vozilo.BrUgovora);
                FindAndReplace(wordApp, "<marka_vozila>", vozilo.Proizvodac);
                FindAndReplace(wordApp, "<model_vozila>", $"{vozilo.Model} {vozilo.Opis}");
                FindAndReplace(wordApp, "<br_sasije>", vozilo.BrSasije);
                FindAndReplace(wordApp, "<reg_oznaka>", ovlastenje.RegOznaka);
                FindAndReplace(wordApp, "<datum>", ovlastenje.DatumOvlastenja);
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
            MessageBox.Show("Ovlaštenje kreirano!", "Obavijest");
        }
        //Kreiranje Word dokumenta - Zadužnica/Razdužnica
        public void CreateWordDocument(object filename, object SaveAs, ZaRaDokumentModel zaRaDoc, List<string> popis)
        {
            Word.Application wordApp = new();
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

                this.FindAndReplace(wordApp, "<datum>", zaRaDoc.Datum);
                this.FindAndReplace(wordApp, "<TIP_DOKUMENTA>", zaRaDoc.TipDokumenta);
                this.FindAndReplace(wordApp, "<predao_preuzeo>", zaRaDoc.PredaoPreuzeo);
                this.FindAndReplace(wordApp, "<zadužio_razdužio1>", zaRaDoc.ZaduzioRazduzio.ToLower());
                this.FindAndReplace(wordApp, "<zadužio_razdužio2>", zaRaDoc.ZaduzioRazduzio);
                this.FindAndReplace(wordApp, "<djelatnik1>", zaRaDoc.Djelatnik);
                this.FindAndReplace(wordApp, "<djelatnik2>", zaRaDoc.Djelatnik);
                this.FindAndReplace(wordApp, "<korisnik>", zaRaDoc.Korisnik);

                for (int i = 0; i < popis.Count; i++)
                {
                    this.FindAndReplace(wordApp, $"<red{i}>", popis[i]);
                }

                for (int i = popis.Count; i < 15; i++)
                {
                    this.FindAndReplace(wordApp, $"<red{i}>", "");
                }
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
            MessageBox.Show($"{zaRaDoc.TipDokumenta} kreirana!");

        }
        //Kreiranje word dokumenta - UsersData
        public void CreateWordDocument(object filename, object SaveAs, UsersDataModel usersData, DjelatnikModel djelatnik)
        {
            Word.Application wordApp = new();
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
                FindAndReplace(wordApp, "<datum>", System.DateTime.Now.Date);
                FindAndReplace(wordApp, "<djelatnik.Ime>", djelatnik.Ime);
                FindAndReplace(wordApp, "<djelatnik.Prezime>", djelatnik.Prezime);
                FindAndReplace(wordApp, "<djelatnik.Pn1>", djelatnik.PerNum);
                FindAndReplace(wordApp, "<djelatnik.email>", usersData.Email);
                FindAndReplace(wordApp, "<djelatnik.username>", usersData.Username);
                FindAndReplace(wordApp, "<djelatnik.Pn2>", djelatnik.PerNum);
                FindAndReplace(wordApp, "<djelatnik.password1>", usersData.Password);
                FindAndReplace(wordApp, "<djelatnik.Pn3>-<djelatnik.password2>", $"{djelatnik.PerNum}-{usersData.Password}");
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
            MessageBox.Show("Korisnički podatci napravljeni!", "Obavijest");
        }
        //Otvaranje dokumenta za print
        public void OpenWordDocumentForPrint(string wordToOpen)
        {
            Word.Application ap = new();
            ap.Documents.Open(wordToOpen);
            ap.Visible = true;
        }
    }
}
