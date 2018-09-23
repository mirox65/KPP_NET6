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
        private void TipkaEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_prijava.PerformClick();
            }
        }
private void btn_prijava_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ole = "SELECT * FROM korisnici WHERE KorisnickoIme='" + txt_korIme.Text + "'and Lozinka='" + Kor.NapraviMD5(txt_lozinka.Text) + "'";
                OleDbConnection conn = new OleDbConnection(dbc.conn_string);
                OleDbCommand cmd = new OleDbCommand(ole, conn);
                conn.Open();
                OleDbDataReader korisnik = cmd.ExecuteReader();
                if (korisnik.HasRows)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Korisničko ime ili lozinka nisu točni. Pokušaj ponovno!");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        private void btn_izlaz_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void polje_lozinka(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_prijava.PerformClick();
            }
        }
    }
}
