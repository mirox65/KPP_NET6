using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace KPP_Alpha1
{
    public partial class form_KPP : Form
    {
        dbClass dbc = new dbClass();
        KPPeditClass uredi = new KPPeditClass();
        EditClass EditIt = new EditClass();

        public string _sifra { get; set; }
        public string TrazeniID { get; set; }
        public string IzTablice { get; set; }
        public string GdjeTrazim { get; set; }

        public form_KPP()
        {
            InitializeComponent();
            AutoCompPosiljatelj();
            AutoCompOdjel();
            AutoCompKorisnik();
        }

        public void AutoCompPosiljatelj()
        {
            string DbAc = "SELECT naziv FROM posiljatelji;";
            string AcPrvi = "naziv";
            AutoCompleteStringCollection AcPosiljatelj = dbc.AutoComplete(DbAc, AcPrvi);

            txt_Posiljatelj.AutoCompleteCustomSource = AcPosiljatelj;
        }

        public void AutoCompOdjel()
        {
            string DbAc = "SELECT naziv FROM odjeli;";
            string AcPrvi = "naziv";
            AutoCompleteStringCollection AcOdjel = dbc.AutoComplete(DbAc, AcPrvi);

            txt_Odjel.AutoCompleteCustomSource = AcOdjel;
        }

        public void AutoCompKorisnik()
        {
            string DbAc = "SELECT ime, prezime FROM korisnici;";
            string AcPrvi = "ime";
            string AcDrugi = "prezime";
            AutoCompleteStringCollection NoviAc = dbc.AutoComplete(DbAc, AcPrvi, AcDrugi);

            txt_Korisnik.AutoCompleteCustomSource = NoviAc;
        }

        private void DTUpdate()
        {
            string Dbs = "SELECT knjiga.id AS ID, knjiga.datumPrimitka AS 'Datum primitka', knjiga.pismeno AS Pismeno, knjiga.brojcano AS Brojčano, " +
                "posiljatelji.naziv AS Pošiljatelj, knjiga.datum AS Datum, odjeli.naziv AS Odjel, korisnici.ime +' '+ korisnici.prezime AS Korisnik FROM (([knjiga] LEFT JOIN [posiljatelji] " +
                "ON [posiljatelji].[id] = [knjiga].[idposiljatelj]) LEFT JOIN [odjeli] ON odjeli.id = knjiga.idodjel) LEFT JOIN [korisnici] ON korisnici.id = knjiga.idkorisnik " +
                "ORDER BY knjiga.id DESC;";
            DataTable dt = dbc.Select(Dbs);
            dgv_kpp.DataSource = dt;
        }
        
        private void form_KPP_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            if(txt_Korisnik.Text == "" | txt_Odjel.Text == "" | txt_Brojcano.Text =="" | txt_Pismeno.Text =="" | txt_Posiljatelj.Text =="")
            {
                if (txt_Korisnik.Text == "")
                {
                    txt_Korisnik.BackColor = Color.LightPink;
                }
                else
                {
                    txt_Korisnik.BackColor = Color.White;
                }
                if(txt_Odjel.Text == "")
                {
                    txt_Odjel.BackColor = Color.LightPink;
                }
                else
                {
                    txt_Odjel.BackColor = Color.White;
                }
                if(txt_Posiljatelj.Text == "")
                {
                    txt_Posiljatelj.BackColor = Color.LightPink;
                }
                else
                {
                    txt_Posiljatelj.BackColor = Color.White;
                }
                if(txt_Pismeno.Text == "")
                {
                    txt_Pismeno.BackColor = Color.LightPink;
                }
                else
                {
                    txt_Pismeno.BackColor = Color.White;
                }
                if(txt_Brojcano.Text == "")
                {
                    txt_Brojcano.BackColor = Color.LightPink;
                }
                else
                {
                    txt_Brojcano.BackColor = Color.White;
                }
                MessageBox.Show(dbc.PraznaCelija);
            }
            else
            {
                uredi.DatumPrimitka = date_primitka.Text;
                uredi.Pismeno = txt_Pismeno.Text;
                uredi.Brojcano = txt_Brojcano.Text;

                _sifra = txt_Posiljatelj.Text;
                IzTablice = "posiljatelji";
                GdjeTrazim = "naziv";
                uredi.Idposiljatelj = EditIt.Sifra(_sifra, IzTablice, GdjeTrazim);

                uredi.Datum = date_datum.Text;

                _sifra = txt_Odjel.Text;
                IzTablice = "odjeli";
                GdjeTrazim = "naziv";
                uredi.Idodjel = EditIt.Sifra(_sifra, IzTablice, GdjeTrazim);

                _sifra = txt_Korisnik.Text;
                IzTablice = "korisnici";
                GdjeTrazim = "ime+' '+prezime";
                uredi.Idkorisnik = EditIt.Sifra(_sifra, IzTablice, GdjeTrazim);

                bool success = uredi.Insert(uredi);
                if (success == true)
                {
                    DTUpdate();
                    Clear();
                    txt_Posiljatelj.BackColor = Color.White;
                    txt_Pismeno.BackColor = Color.White;
                    txt_Brojcano.BackColor = Color.White;
                    txt_Odjel.BackColor = Color.White;
                    txt_Korisnik.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("Stavka nije unešena!");
                }
            }
        }
        private void Clear()
        {
            txt_Posiljatelj.Text = "";
            txt_Pismeno.Text = "";
            txt_Brojcano.Text = "";
            txt_Odjel.Text = "";
        }

        private void txt_pretraži_TextChanged(object sender, EventArgs e)
        {
            string Pretraga = txt_pretrazivanje.Text;
            string Dbs = "SELECT * FROM knjiga" +
                " WHERE pismeno LIKE '%" + Pretraga + "%' OR brojcano LIKE '%" + Pretraga + "%'";

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            OleDbDataAdapter a = new OleDbDataAdapter(Dbs, conn);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dgv_kpp.DataSource = dt;
        }

        private void dgv_kpp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = dgv_kpp.Rows[RowIndex].Cells[0].Value.ToString();
            //date_primitka.Text = dgv_kpp.Rows[RowIndex].Cells[1].ToString();
            txt_Pismeno.Text = dgv_kpp.Rows[RowIndex].Cells[2].Value.ToString();
            txt_Brojcano.Text = dgv_kpp.Rows[RowIndex].Cells[3].Value.ToString();
            txt_Posiljatelj.Text = dgv_kpp.Rows[RowIndex].Cells[4].Value.ToString();
            date_datum.Text = dgv_kpp.Rows[RowIndex].Cells[5].Value.ToString();
            txt_Odjel.Text = dgv_kpp.Rows[RowIndex].Cells[6].Value.ToString();
            txt_Korisnik.Text = dgv_kpp.Rows[RowIndex].Cells[7].Value.ToString();                    
        }

        private void btn_uredi_Click(object sender, EventArgs e)
        {
            uredi.KnjigaID = int.Parse(txt_id.Text);
            uredi.DatumPrimitka = date_primitka.Text;
            uredi.Pismeno = txt_Pismeno.Text;
            uredi.Brojcano = txt_Brojcano.Text;

            _sifra = txt_Posiljatelj.Text;
            IzTablice = "posiljatelji";
            GdjeTrazim = "naziv";
            uredi.Idposiljatelj = EditIt.Sifra(_sifra, IzTablice, GdjeTrazim);

            uredi.Datum = date_datum.Text;

            _sifra = txt_Odjel.Text;
            IzTablice = "odjeli";
            GdjeTrazim = "naziv";
            uredi.Idodjel = EditIt.Sifra(_sifra, IzTablice, GdjeTrazim);

            _sifra = txt_Korisnik.Text;
            IzTablice = "korisnici";
            GdjeTrazim = "ime+' '+prezime";
            uredi.Idkorisnik = EditIt.Sifra(_sifra, IzTablice, GdjeTrazim);

            bool success = uredi.Update(uredi);

            if (success == true)
            {
                DTUpdate();
                Clear();
            }
            else
            {
                MessageBox.Show("Unos nije izmjenjen!");
            }
        }
    }
}
