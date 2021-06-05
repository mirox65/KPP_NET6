using KPP_Alpha1.HelperClasses;
using System;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    public class LoginController
    {
        readonly DbClass db = new DbClass();
        readonly EditClass edit = new EditClass();
        readonly KorisnikController controller = new KorisnikController();

        internal bool RequestAccess(string korisnickoIme, string lozinka)
        {
            bool access = false;
            var dbs = "SELECT k.id, [d.ime]&' '&[d.prezime] AS Korisnik, k.korisnickoIme, k.uloga " +
                        "FROM (korisnici AS k " +
                        "LEFT JOIN djelatnici AS d ON d.id=k.djelatnikId) " +
                        "WHERE k.korisnickoIme=? AND k.lozinka=? AND aktivan='DA';";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(dbs, conn);
            cmd.Parameters.AddWithValue("@korsinickoIme", korisnickoIme);
            cmd.Parameters.AddWithValue("@lozinka", controller.NapraviMD5(lozinka));
            try
            {
                conn.Open();
                var korisnik = cmd.ExecuteReader();
                if (korisnik.HasRows)
                {
                    SetStaticProperties(korisnik, korisnickoIme);
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
                    EditClass.IdKorisnika = int.Parse(korisnik.GetValue(0).ToString());
                    EditClass.KorisnikAplikacije = korisnik.GetValue(1).ToString();
                    EditClass.UlogaKorisnika = korisnik.GetValue(3).ToString();
                    LoginHelper.StaticId = int.Parse(korisnik.GetValue(0).ToString());
                    LoginHelper.StaticKorisnickoIme = korisnik.GetValue(1).ToString();
                    LoginHelper.StaticKorisnik = korisnik.GetValue(3).ToString();
                }
            }
            korisnik.Close();
        }

        internal bool UpdatePasswordByUser(int staticId, string lozinka)
        {
            string Uredi = "UPDATE korisnici SET lozinka=?, korisnikId=?, azurirano=? " +
                "WHERE id=?";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@lozinka", controller.NapraviMD5(lozinka));
            cmd.Parameters.AddWithValue("@korisnikId", staticId);
            cmd.Parameters.AddWithValue("@azurirano", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@id", staticId);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }
    }
}
