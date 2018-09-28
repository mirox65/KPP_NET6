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
    public partial class form_Login : Form
    {
        dbClass dbc = new dbClass();
        form_Korisnici Kor = new form_Korisnici();
        
        public form_Login()
        {
            InitializeComponent();
        }
        private void btn_prijava_Click_1(object sender, EventArgs e)
        {
            string ole = "SELECT * FROM korisnici WHERE KorisnickoIme='" + txt_korIme.Text + "'and Lozinka='" + Kor.NapraviMD5(txt_lozinka.Text) + "'";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                OleDbCommand cmd = new OleDbCommand(ole, conn);
                conn.Open();
                OleDbDataReader korisnik = cmd.ExecuteReader();
                if (korisnik.HasRows)
                {
                    EditClass.KorisnickoIme = txt_korIme.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Korisničko ime ili lozinka nisu točni. Pokušaj ponovno!", dbc.CelijaNazivUpozorenje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(dbc.ExError + ex, dbc.CelijaNazivObavjest);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_izlaz_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btn_prijava.PerformClick();
            }
        }
    }
}
