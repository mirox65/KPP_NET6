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
    public partial class form_Mjesta : Form
    {
        dbClass dbc = new dbClass();
        EditClass uredi = new EditClass();

        public int idZupaija { get; set; }
        public string _sifra { get; set; }
        public string IzTablice { get; set; }
        public string GdjeTrazim { get; set; }

        public form_Mjesta()
        {
            InitializeComponent();
            AutoCompZupanija();
        }
        private void AutoCompZupanija()
        {
            string DbAc = "SELECT * FROM zupanije;";
            string AcPrvi = "zupanija";
            AutoCompleteStringCollection AcZup = dbc.AutoComplete(DbAc, AcPrvi);
            txt_Zupanija.AutoCompleteCustomSource = AcZup;
        }
        private void DTUpdate()
        {
            string Dbs = "SELECT mjesta.id AS ID, mjesta.ptt AS 'Poštanski broj', mjesta.mjesto AS Mjesto, zupanije.zupanija AS Županija, mjesta.secKey AS 'Poštanski ured'" +
                            " FROM mjesta INNER JOIN zupanije ON mjesta.idZupanije = zupanije.id ORDER BY ptt ASC, mjesta.id ASC;";
            DataTable dt = dbc.Select(Dbs);
            dgv_mjesta.DataSource = dt;
        }
        private void Form_Mjesta_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }
        private void btn_Uredi_Click(object sender, EventArgs e)
        {
            if (txt_Mjesto.Text == "" | txt_Ptt.Text == "" | txt_Zupanija.Text == "")
            {
                PrazneCelije();
            }
            else
            {
                uredi.idMjesto = int.Parse(txt_id.Text);
                uredi.Ptt = txt_Ptt.Text;
                uredi.Mjesto = txt_Mjesto.Text;

                _sifra = txt_Zupanija.Text;
                GdjeTrazim = "zupanija";
                IzTablice = "zupanije";
                uredi.idZupaija = uredi.Sifra(_sifra, IzTablice, GdjeTrazim);

                _sifra = txt_secKey.Text;
                GdjeTrazim = "mjesto";
                IzTablice = "mjesta";
                uredi.secKey = uredi.Sifra(_sifra, IzTablice, GdjeTrazim);
                bool success = uredi.UpdateMjesto(uredi);
                if (success == true)
                {
                    DTUpdate();
                    Clear();
                    txt_Ptt.Focus();
                }
                else
                {
                    MessageBox.Show(dbc.IzmjenaError, dbc.CelijaNazivUpozorenje);
                }
            }
        }
        private void dgv_mjesta_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = dgv_mjesta.Rows[RowIndex].Cells[0].Value.ToString();
            txt_Ptt.Text = dgv_mjesta.Rows[RowIndex].Cells[1].Value.ToString();
            txt_Mjesto.Text = dgv_mjesta.Rows[RowIndex].Cells[2].Value.ToString();
            txt_Zupanija.Text = dgv_mjesta.Rows[RowIndex].Cells[3].Value.ToString();
            txt_secKey.Text = dgv_mjesta.Rows[RowIndex].Cells[4].Value.ToString();
        }
        private void txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            string Pretraga = txt_pretrazivanje.Text;
            string Dbs = "SELECT mjesta.id AS ID, mjesta.ptt AS 'Poštanski broj', mjesta.mjesto AS Mjesto, zupanije.zupanija AS Županija, mjesta.secKey AS 'Poštanski ured'" +
            " FROM mjesta INNER JOIN zupanije ON mjesta.idZupanije = zupanije.id WHERE mjesta.mjesto LIKE '%" +Pretraga+ "%' OR mjesta.ptt LIKE '%" + Pretraga + "%'";

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            OleDbDataAdapter a = new OleDbDataAdapter(Dbs, conn);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dgv_mjesta.DataSource = dt;
        }
        private void Clear()
        {
            txt_id.Text = "";
            txt_Ptt.Text = "";
            txt_Mjesto.Text = "";
            txt_Zupanija.Text = "";
            txt_secKey.Text = "";
            txt_Mjesto.Focus();
        }
        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            if (txt_Mjesto.Text == "" | txt_Ptt.Text=="" | txt_Zupanija.Text=="")
            {
                PrazneCelije();
            }
            else
            {
                uredi.Mjesto = txt_Mjesto.Text.Trim();
                uredi.Ptt = txt_Ptt.Text.Trim();

                _sifra = txt_Zupanija.Text.Trim();
                GdjeTrazim = "zupanija";
                IzTablice = "zupanije";
                uredi.idZupaija = uredi.Sifra(_sifra, IzTablice, GdjeTrazim);

                _sifra = txt_secKey.Text.Trim();
                GdjeTrazim = "mjesto";
                IzTablice = "mjesta";
                uredi.secKey = uredi.Sifra(_sifra, IzTablice, GdjeTrazim);
                if(idZupaija < 1)
                {
                    MessageBox.Show(dbc.IdError, dbc.CelijaNazivUpozorenje);
                }
                else
                {
                    bool success = uredi.InsertMjesto(uredi);
                    if (success == true)
                    {
                        DTUpdate();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show(dbc.UnosError, dbc.CelijaNazivUpozorenje);
                    }
                }                
            }            
        }
        private void dodajNoviUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_dodaj.PerformClick();
        }
        private void spremiIzmjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Uredi.PerformClick();
        }
        private void PrazneCelije()
        {
                if (txt_Mjesto.Text == "")
                {
                    txt_Mjesto.BackColor = Color.LightPink;
                }
                else
                {
                    txt_Mjesto.BackColor = Color.White;
                }
                if (txt_Ptt.Text == "")
                {
                    txt_Ptt.BackColor = Color.LightPink;
                }
                else
                {
                    txt_Ptt.BackColor = Color.White;
                }
                if (txt_Zupanija.Text == "")
                {
                    txt_Zupanija.BackColor = Color.LightPink;
                }
                else
                {
                    txt_Zupanija.BackColor = Color.White;
                }
                MessageBox.Show(dbc.PraznaCelija, dbc.CelijaNazivUpozorenje);           
        }
    }
}
