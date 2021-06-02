using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class form_Main : Form
    {
        readonly dbClass dbc = new dbClass();

        form_Login LogFrm = new form_Login();
        OleDbConnection conn = null;

        //O aplikaciji
        string MB_NazivAplikacija = "O aplikaciji KPP";
        string appName = "Knjiga primljenih pošiljki (KPP)";
        string appVersion = "Version 1.0.0.0";
        string appAuthor = "Miroslav Vranić";
        string aboutApp = "Aplikcaija Knjiga primljenih pošiljki je napravaljena kao projekt na predmetu Objektno orijentirano programiranje 2 " +
            "na TVZ-u godina 2017/2018";

        public form_Main()
        {
            InitializeComponent();
        }

        #region Nove forme
        private void FormaKPP()
        {
            form_KPP form = new form_KPP();
            Forma(form);
        }
        private void FormaKorisnici()
        {
            form_Korisnici form = new form_Korisnici();
            Forma(form);
        }
        private void FormaOdjeli()
        {
            form_Odjeli form = new form_Odjeli();
            Forma(form);
        }
        private void FormaPosiljatelji()
        {
            form_Posiljatelji form = new form_Posiljatelji();
            Forma(form);
        }
        private void FormaMjesta()
        {
            form_Mjesta form = new form_Mjesta();
            Forma(form);
        }
        private void FormaIzvoz()
        {
            form_ExportData form = new form_ExportData();
            Forma(form);
        }

        private void FormaDjelatnici()
        {
            Djelatnici form = new Djelatnici();
            Forma(form);
        }

        private void FormaPartneri()
        {
            Partneri form = new Partneri();
            Forma(form);
        }

        private void FormaPoslane()
        {
            Poslane form = new Poslane();
            Forma(form);
        }


        private void Forma(Form form)
        {
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region Tool strip menu item click events
        private void otvoriKPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
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
            if (ActiveMdiChild != null)
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
        private void izvozPodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaIzvoz();
            }
            else
            {
                FormaIzvoz();
            }
        }

        private void djelatniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaDjelatnici();
            }
            else
            {
                FormaDjelatnici();
            }
        }

        private void partneriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaPartneri();
            }
            else
            {
                FormaPartneri();
            }
        }

        private void knjigaPoslanihPošiljkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                FormaPoslane();
            }
            else
            {
                FormaPoslane();
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
            catch (Exception ex)
            {
                MessageBox.Show(dbc.ExError + ex.Message, dbc.CelijaNazivUpozorenje);
            }
        }
        private void odspojiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            conn.Close();
            odspojiToolStripMenuItem.Enabled = false;
            spojiToolStripMenuItem.Enabled = true;
        }
        private void izađiIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                this.Close();
            }
            else
            {
                ActiveMdiChild.Close();
            }
        }
        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikacija:\t\t" + appName + "\nVerzija aplikacije:\t" + appVersion + "\nAutor aplikacije:\t" + appAuthor + "\n\nO aplikaciji:\n" + aboutApp, MB_NazivAplikacija);
        }
        #endregion

        private void form_Main_Load(object sender, EventArgs e)
        {
            spojiToolStripMenuItem.PerformClick();
            using (form_Login LogForm = new form_Login())
            {
                if (LogFrm.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
                else
                {
                    FormaKPP();
                    tssl_korisnik.Text = EditClass.Korisnik;
                }
            }
        }

        private void form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            odspojiToolStripMenuItem.PerformClick();
        }
    }
}
