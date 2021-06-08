using KPP_Alpha1.HelperClasses;
using KPP_Alpha1.Models;
using System;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    public class LoginController
    {
        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();
        readonly KorisnikController korisnikController = new KorisnikController();

        internal bool RequestAccess(LoginModel login)
        {
            bool access = false;
            var dbs = "SELECT k.id, [d.ime]&' '&[d.prezime] AS Korisnik, k.korisnickoIme, k.uloga " +
                        "FROM (korisnici AS k " +
                        "LEFT JOIN djelatnici AS d ON d.id=k.djelatnikId) " +
                        "WHERE k.korisnickoIme=? AND k.lozinka=? AND k.aktivan='DA';";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(dbs, conn);
            cmd.Parameters.AddWithValue("@korsinickoIme", login.KorisnickoIme);
            cmd.Parameters.AddWithValue("@lozinka", login.HashedLozinka);
            try
            {
                conn.Open();
                var korisnik = cmd.ExecuteReader();
                if (korisnik.HasRows)
                {
                    SetStaticProperties(korisnik, login.KorisnickoIme);
                    access = true;
                }
            }
            catch (Exception ex) { edit.MessageException(ex); }
            finally
            {
                conn.Close();
            }
            return access;
        }

        private void SetStaticProperties(OleDbDataReader korisnik, string korisnickoIme)
        {
            while (korisnik.Read())
            {
                if (korisnickoIme == korisnik.GetValue(2).ToString())
                {
                    LoginHelper.StaticId = int.Parse(korisnik.GetValue(0).ToString());
                    LoginHelper.StaticKorisnik = korisnik.GetValue(1).ToString();
                    LoginHelper.StaticKorisnickoIme = korisnik.GetValue(2).ToString();
                    LoginHelper.StaticUloga = korisnik.GetValue(3).ToString();
                }
            }
            korisnik.Close();
        }

        internal bool UpdatePasswordByUser(LoginModel login)
        {
            var success = korisnikController.UpdatePasswordByUser(login);
            return success;
        }
    }
}
