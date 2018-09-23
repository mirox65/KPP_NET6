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
    public partial class form_Odjeli : Form
    {
        dbClass dbc = new dbClass();
        EditClass uredi = new EditClass();

        public form_Odjeli()
        {
            InitializeComponent();
        }

        private void form_Odjeli_Load(object sender, EventArgs e)
        {
            DTUpdate();
        }
        private void DTUpdate()
        {
            string Dbs = "SELECT * FROM odjeli ORDER BY naziv ASC;";
            DataTable dt = dbc.Select(Dbs);
            dgv_odjel.DataSource = dt;
        }
        private void Clear()
        {
            txt_naziv.Text = "";
            txt_id.Text = "";
        }
        private void lbl_dodaj_Click(object sender, EventArgs e)
        {
            if (txt_naziv.Text == "")
            {
                txt_naziv.BackColor = Color.LightPink;
                MessageBox.Show(dbc.PraznaCelija);
            }
            else
            {
                txt_naziv.BackColor = Color.White;
                uredi.NazivOdjela = txt_naziv.Text.Trim();                

                bool success = uredi.InsertOdjel(uredi);

                if (success == true)
                {
                    DTUpdate();
                    Clear();
                    txt_naziv.Focus();
                }
                else
                {
                    MessageBox.Show(dbc.UnosError);
                }
            }
        }

        private void lbl_uredi_Click(object sender, EventArgs e)
        {
            if(txt_naziv.Text == "")
            {
                txt_naziv.BackColor = Color.LightPink;
                MessageBox.Show(dbc.PraznaCelija);
            }
            else
            {
                txt_naziv.BackColor = Color.White;
                uredi.OdjelId = int.Parse(txt_id.Text.Trim());
                uredi.NazivOdjela = txt_naziv.Text.Trim();

                bool success = uredi.UpdateMjesto(uredi);

                if (success == true)
                {
                    DTUpdate();
                    Clear();
                    txt_naziv.Focus();
                }
                else
                {
                    MessageBox.Show(dbc.IzmjenaError);
                }
            }            
        }

        private void dgv_odjel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = dgv_odjel.Rows[RowIndex].Cells[0].Value.ToString();
            txt_naziv.Text = dgv_odjel.Rows[RowIndex].Cells[1].Value.ToString();            
        }

        private void txt_pretrazivanje_TextChanged(object sender, EventArgs e)
        {
            string Pretraga = txt_pretrazivanje.Text;
            string Dbs = "SELECT * FROM odjeli" +
                " WHERE naziv LIKE '%" + Pretraga + "%'";

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            OleDbDataAdapter a = new OleDbDataAdapter(Dbs, conn);
            DataTable dt = new DataTable();
            a.Fill(dt);
            dgv_odjel.DataSource = dt;
        }

        private void dodajNoviUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_dodaj.PerformClick();
        }

        private void spremiIzmjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_uredi.PerformClick();
        }
    }
}
