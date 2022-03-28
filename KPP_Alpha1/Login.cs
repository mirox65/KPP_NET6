using KPP_Alpha1.Controller;
using KPP_Alpha1.HelperClasses;
using KPP_Alpha1.Models;
using System;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    /// <summary>
    /// Login forma služi za provjeru prava pristupa korisniku.
    /// Osim ispravne lozinke, klasa postavalja korisničkiId u globalnu vbarijablu, 
    /// kao i ime i prezime za prikaze unutra prozora za vrijeme rada.
    /// I jako bitno Ulogu Korisnika koju možemo koristi kroz aplikaciju za davanje prava pristupa elementima
    /// </summary>

    public partial class FormLogin : Form
    {
        readonly EditClass edit = new();
        readonly LoginController controller = new();
        readonly LoginController loginController = new();

        public FormLogin()
        {
            InitializeComponent();
        }
        // BTN prijava zaduen za provjeru ima li korisnik sa svojim korisničkim imenom i lozinkom pravo pristupa
        // Baza sadrži i neaktivne korisnike koji su označeni sa NE i time korisnicima je isto ulaz zabranjen
        // Poziva metodu za isčitavanje podatka iz baze i postavljanje globalnih statičkih varijabli u Edit klasi
        private void Btn_prijava_Click_1(object sender, EventArgs e)
        {
            if (btn_prijava.Text == "Prijava")
            {
                var login = SetProperties();
                bool accessGranted = loginController.RequestAccess(login);
                if (accessGranted is true)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    edit.MessageAccessDenied();
                    Clear();
                }
            }
            else
            {
                LblBtnNameChanges();
            }
        }
        private void BtnPromjenaLozinke_Click(object sender, EventArgs e)
        {
            var login = SetProperties();
            if (BtnPromjenaLozinke.Text == "Promjena lozinke")
            {
                bool accessGranted = controller.RequestAccess(login);
                if (accessGranted is true)
                {
                    LblBtnNameChanges();
                }
                else
                {
                    edit.MessageAccessDenied();
                }
            }
            else
            {
                if (login.NovaLozinka == login.PonovljenaLozinka)
                {
                    bool success = controller.UpdatePasswordByUser(login);
                    if (success is true)
                    {
                        edit.MessagePasswordChanged();
                        LblBtnNameChanges();
                    }
                    else
                    {
                        edit.MessageDBErrorUpdate();
                    }
                }
                else
                {
                    edit.MessagePasswordMissmatch();
                }
            }
        }

        private void LblBtnNameChanges()
        {
            if (BtnPromjenaLozinke.Text == "Promjena lozinke")
            {
                txt_korIme.Clear();
                txt_lozinka.Clear();
                txt_korIme.UseSystemPasswordChar = true;
                LblKorIme.Text = "Nova lozinka:";
                LblLozinka.Text = "Ponovi lozinku:";
                BtnPromjenaLozinke.Text = "Spremi";
                btn_prijava.Text = "Odbaci";
                txt_korIme.Focus();
            }
            else
            {
                LblKorIme.Text = "Korisničko ime:";
                LblLozinka.Text = "Lozinka:";
                BtnPromjenaLozinke.Text = "Promjena lozinke";
                btn_prijava.Text = "Prijava";
                txt_korIme.UseSystemPasswordChar = false;
                txt_korIme.Text = LoginHelper.StaticKorisnickoIme;
                Clear();
            }
        }
        // Metoda postavalj globalne statiče varijable koje se koriste za vrije sesije
        private LoginModel SetProperties()
        {
            if (BtnPromjenaLozinke.Text == "Promjena lozinke")
            {
                var login = new LoginModel
                {
                    KorisnickoIme = txt_korIme.Text.Trim(),
                    Lozinka = txt_lozinka.Text.Trim()
                };
                login.HashedLozinka = login.HashLozinke();
                return login;
            }
            else
            {
                var login = new LoginModel();
                login.NovaLozinka = txt_korIme.Text.Trim();
                login.PonovljenaLozinka = txt_lozinka.Text.Trim();
                return login;
            }
        }
        // Brisanje polja i fokus na polje lozinka
        private void Clear()
        {
            txt_lozinka.Clear();
            txt_lozinka.Focus();
        }
        // BTN zadužen za izlaz iz apiakcije i zatvaranje ako se korisnik predomislio
        private void Btn_izlaz_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Enterom iz polja password može se isto "kliknuti" na Prijavu
        private void Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_prijava.PerformClick();
            }
        }
    }
}
