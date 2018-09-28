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
using System.Data.OleDb;

namespace KPP_Alpha1
{
    public partial class form_ExportData : Form
    {
        dbClass dbc = new dbClass();

        public form_ExportData()
        {
            InitializeComponent();
        }

        private void Btn_IzvozPodataka_Click(object sender, EventArgs e)
        {
            string Dbs = "SELECT knjiga.id AS ID, knjiga.datumPrimitka AS 'Datum primitka', knjiga.pismeno AS Pismeno, knjiga.brojcano AS Brojčano, " +
                "posiljatelji.naziv AS Pošiljatelj, knjiga.datum AS Datum, odjeli.naziv AS Odjel, korisnici.ime +' '+ korisnici.prezime AS Korisnik FROM (([knjiga] LEFT JOIN [posiljatelji] " +
                "ON [posiljatelji].[id] = [knjiga].[idposiljatelj]) LEFT JOIN [odjeli] ON odjeli.id = knjiga.idodjel) LEFT JOIN [korisnici] ON korisnici.id = knjiga.idkorisnik " +
                "WHERE YEAR(knjiga.datumPrimitka) LIKE'%" + Txt_Godina.Text + "%';";
            
            string DatotekaIzvoz = "Izvoz_podataka _za_" + Txt_Godina.Text + ".txt";
            if (!File.Exists(DatotekaIzvoz))
            {
                File.Create(DatotekaIzvoz).Close();
                MessageBox.Show("Kreirana je datoteka " + DatotekaIzvoz);
            }
            else
            {
                File.Delete(DatotekaIzvoz);
                File.Create(DatotekaIzvoz).Close();
                MessageBox.Show("Kreirana je datoteka " + DatotekaIzvoz);
            }
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            OleDbCommand cmd = new OleDbCommand(Dbs, conn);
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();
            StreamWriter Ispis = new StreamWriter(DatotekaIzvoz);
            try
            {
                conn.Open();
                OleDbDataReader myReader = cmd.ExecuteReader();
                dt.Load(myReader);
                foreach (DataRow red in dt.Rows)
                {
                    foreach (DataColumn stup in dt.Columns)
                    {
                        sb.ToString();
                        sb.Append(";");
                        sb.Append(red[stup].ToString());
                    }
                    sb.Append("\n");
                }
                Ispis.Write(sb);
                Ispis.Flush();
                Ispis.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(dbc.ExError +ex, dbc.CelijaNazivObavjest);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
