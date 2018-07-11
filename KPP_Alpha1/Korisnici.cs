using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class form_Korisnici : Form
    {
        dbClass dbc = new dbClass();
        EditClass uredi = new EditClass();

        public form_Korisnici()
        {
            InitializeComponent();
        }

        private void DTUpdate()
        {
            string Dbs = "SELECT * FROM korisnici ORDER BY ime ASC;";
            DataTable dt = dbc.Select(Dbs);
            dgv_korisnik.DataSource = dt;
        }

        private void Clear()
        {

        }

        private void form_Korisnici_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }

        private void lbl_dodaj_Click(object sender, EventArgs e)
        {
            if (txt_ime.Text == "" | txt_prezime.Text == "")
            {
                if (txt_ime.Text == "")
                {
                    txt_ime.BackColor = Color.LightPink;
                }
                else
                {
                    txt_ime.BackColor = Color.White;
                }
                if(txt_prezime.Text == "")
                {
                    txt_prezime.BackColor = Color.LightPink;
                }
                else
                {
                    txt_prezime.BackColor = Color.White;
                }
                MessageBox.Show(dbc.PraznaCelija);
            }
            else
            {
                uredi.KorisnikIme = txt_ime.Text;
                uredi.KorisnikPrezime = txt_prezime.Text;

                bool success = uredi.InsertKorisnik(uredi);

                if (success == true)
                {
                    DTUpdate();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Korisnik nije unešen!");
                }
            }
        }

        private void lbl_uredi_Click(object sender, EventArgs e)
        {
            uredi.KorisnikId = int.Parse(txt_id.Text);
            uredi.KorisnikIme = txt_ime.Text;
            uredi.KorisnikPrezime = txt_prezime.Text;

            bool success = uredi.UpdateKorsinik(uredi);

            if (success == true)
            {
                DTUpdate();
                Clear();
            }
            else
            {
                MessageBox.Show("Korisnik nije izmjenjen!");
            }
        }

        private void dgv_korisnik_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = dgv_korisnik.Rows[RowIndex].Cells[0].Value.ToString();
            txt_ime.Text = dgv_korisnik.Rows[RowIndex].Cells[1].Value.ToString();
            txt_prezime.Text = dgv_korisnik.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            string Pretraga = txt_pretrazivanje.Text;
            string Dbs = "SELECT * FROM korisnici" +
                " WHERE ime LIKE '%" + Pretraga + "%' OR prezime LIKE '%" + Pretraga + "%'";

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            OleDbDataAdapter a = new OleDbDataAdapter(Dbs, conn);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dgv_korisnik.DataSource = dt;
        }
    }
}
