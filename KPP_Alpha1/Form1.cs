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
    public partial class form_Main : Form
    {
        dbClass dbc = new dbClass();
        string por = null; //string za poruke sustava korisniku
        form_Login LogFrm = new form_Login();
        OleDbConnection conn = null;
        //O aplikaciji
        string CelijaNazivAplikacija = "O aplikaciji KPP";
        string appName = "Knjiga primljenih pošiljki (KPP)";
        string appVersion = "Version 1.0.0.0";
        string appAuthor = "Miroslav Vranić";
        string aboutApp = "Aplikcaija Knjiga primljenih pošiljki je napravaljena kao projekt na predmetu Objektno orijentirano programiranje 2 " +
            "na TVZ-u godina 2017/2018";
        private void stat()
        {
            //status bar poruka
            toolStripStatusLabel1.Text = por;
        }
        public form_Main()
        {
            InitializeComponent();
        }
        private void otvoriKPPToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            por = "Otvori Knjigu primljenih pošiljki";
            stat();
        }
        private void zatvoriToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            por = "Zatvori aktivni prozor";
            stat();
        }
        private void izađiIzAplikacijeToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            por = "Izađi iz aplikacije";
            stat();
        }
        private void dodajKorisnikaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            por = "Dodavanje novih korisnika za unos u KPP";
            stat();
        }
        private void dodajOdjelToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            por = "Dodavanje odjela";
            stat();
        }
        private void oAplikacijiToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            por = "O aplikaciji KPP";
            stat();
        }
        private void izađiIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild == null)
            {
                this.Close();
            }
            else
            {
                ActiveMdiChild.Close(); 
            }            
        }
        private void FormaKPP()
        {
            form_Mjesta form = new form_Mjesta();
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }
        private void FormaKorisnici()
        {
            form_Korisnici form = new form_Korisnici();
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }
        private void FormaOdjeli()
        {
            form_Odjeli form = new form_Odjeli();
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }
        private void FormaPosiljatelji()
        {
            form_Posiljatelji form = new form_Posiljatelji();
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }
        private void FormaMjesta()
        {
            form_Mjesta form = new form_Mjesta();
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }
        private void otvoriKPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaKPP();
            }
            else
            {
                FormaKPP();
            }
        }
        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaKorisnici();
            }
            else
            {
                FormaKorisnici();
            }
        }
        private void dodajOdjelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaOdjeli();
            }
            else
            {
                FormaOdjeli();
            }
        }
        private void pošiljateljiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaPosiljatelji();
            }
            else
            {
                FormaPosiljatelji();
            }
        }
        private void mjestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaMjesta();
            }
            else
            {
                FormaMjesta();
            }
        }
        private void spojiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(dbc.conn_string);
                conn.Open();
                odspojiToolStripMenuItem.Enabled = true;
                spojiToolStripMenuItem.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, dbc.CelijaNazivUpozorenje); }
        }
        private void odspojiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            conn.Close();
            odspojiToolStripMenuItem.Enabled = false;
            spojiToolStripMenuItem.Enabled = true;
        }
        private void form_Main_Load(object sender, EventArgs e)
        {
            spojiToolStripMenuItem.PerformClick();
            using (form_Login LogForm = new form_Login())
            {
                if(LogFrm.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
                else
                {
                    FormaKPP();
                }
            }
        }
        private void form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            odspojiToolStripMenuItem.PerformClick();
        }
        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacija:\t\t" + appName + "\nVerzija aplikacije:\t" + appVersion + "\nAutor aplikacije:\t" + appAuthor + "\n\nO aplikaciji:\n" + aboutApp, CelijaNazivAplikacija);
        }
    }
}
