using KPP_Alpha1.HelperClasses;
using System;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    public partial class Form1 : Form
    {
        readonly FormLogin LogFrm = new();

        //O aplikaciji
        string MB_NazivAplikacija = "O aplikaciji KPP";
        string appName = "Knjiga primljenih pošiljki (KPP)";
        string appVersion = "Version 1.0.0.0";
        string appAuthor = "Miroslav Vranić";
        string aboutApp = "Aplikcaija Knjiga primljenih pošiljki je napravaljena kao projekt na predmetu Objektno orijentirano programiranje 2 " +
            "na TVZ-u godina 2017/2018";

        public Form1()
        {
            InitializeComponent();
        }

        #region One form to open them all

        private void Forma(Form form)
        {
            CloseMdiChild();
            form.Show();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }

        private void CloseMdiChild()
        {
            if (ActiveMdiChild is not null)
            {
                ActiveMdiChild.Close();
            }
        }
        #endregion

        #region Tool strip menu item click events
        private void otvoriKPPToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormKPP());
        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormKorisnici());
        private void dodajOdjelToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormOdjeli());
        private void pošiljateljiToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormPosiljatelji());
        private void mjestaToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormMjesta());
        private void izvozPodatakaToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormExportData());
        private void djelatniciToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormDjelatnici());
        private void partneriToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormPartneri());
        private void knjigaPoslanihPošiljkiToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormPoslane());
        private void ovlastenjaToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormOvlastenja());
        private void iTOpremaToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormIctOprema());
        private void zaRaToolStripMenuItem1_Click(object sender, EventArgs e) => Forma(new FormZaRa());
        private void vozilaToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormVozila());
        private void podatkovneKarticeToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormDataCards());
        private void karticeZaUlazToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormKeyCards());
        private void eNCUređajiToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new FormEnc());
        private void PodatciODjelatnicimaToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new DjelatniciBasic());
        private void UserDataToolStripMenuItem_Click(object sender, EventArgs e) => Forma(new UsersData());

        private void izađiIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is null)
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
            MessageBox.Show("Aplikacija:\t\t" + appName + "\nVerzija aplikacije:\t" + appVersion +
                "\nAutor aplikacije:\t" + appAuthor + "\n\nO aplikaciji:\n" + aboutApp, MB_NazivAplikacija);
        }
        #endregion

        // Metoda load prekida otvaranje aplikacije i poziva formu za prijavu/autentifikaciju korisnika
        // prava korisnika i prikazivanje elemenata po pravima
        private void form_Main_Load(object sender, EventArgs e)
        {
            using (FormLogin LogForm = new())
            {
                if (LogFrm.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
                else
                {
                    if (LoginHelper.StaticUloga == "Administrator")
                    {
                        dodajKorisnikaToolStripMenuItem.Visible = true;

                        if (LoginHelper.StaticOdjel == "ICT")
                        {
                            ICTToolStripMenuItem.Visible = true;
                        }
                        if (LoginHelper.StaticOdjel == "ICT" || LoginHelper.StaticOdjel == "HR")
                        {
                            HRToolStripMenuItem.Visible = true;
                        }
                    }
                    tssl_korisnik.Text = LoginHelper.StaticKorisnik;
                }
            }
        }
    }
}
