using KPP_Alpha1.Models;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class KorisnikController
    {
        readonly DbClass db = new DbClass();

        internal bool Edit(KorisnikModel korisnik)
        {
            string Uredi = "UPDATE korisnici SET djelatnikId=?, korisnickoIme=?, " +
                "uloga=?, aktivan=?, korisnikId=?, azurirano=? WHERE id=?";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@djelatnikId", korisnik.DjelatnikId);
            cmd.Parameters.AddWithValue("@korisnickoIme", korisnik.KorisnickoIme);
            cmd.Parameters.AddWithValue("@uloga", korisnik.Uloga);
            cmd.Parameters.AddWithValue("@aktivan", korisnik.Aktivan);
            cmd.Parameters.AddWithValue("@korisnikId", korisnik.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", korisnik.Azurirano);
            cmd.Parameters.AddWithValue("@id", korisnik.Id);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }

        internal bool EditWithPassword(KorisnikModel korisnik)
        {
            string Uredi = "UPDATE korisnici SET djelatnikId=?, korisnickoIme=?, " +
                "lozinka=?, uloga=?, aktivan=?, korisnikId=?, azurirano=? WHERE id=?";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@djelatnikId", korisnik.DjelatnikId);
            cmd.Parameters.AddWithValue("@korisnickoIme", korisnik.KorisnickoIme);
            cmd.Parameters.AddWithValue("@lozinka", korisnik.Lozinka);
            cmd.Parameters.AddWithValue("@uloga", korisnik.Uloga);
            cmd.Parameters.AddWithValue("@aktivan", korisnik.Aktivan);
            cmd.Parameters.AddWithValue("@korisnikId", korisnik.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", korisnik.Azurirano);
            cmd.Parameters.AddWithValue("@id", korisnik.Id);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }

        internal bool Insert(KorisnikModel korisnik)
        {
            string Unos = "INSERT INTO korisnici(djelatnikId, korisnickoIme, lozinka, uloga, aktivan, korisnikId, azurirano) " +
                "VALUES(?, ?, ?, ?, ?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Unos, conn);
            cmd.Parameters.AddWithValue("@djelatnikId", korisnik.DjelatnikId);
            cmd.Parameters.AddWithValue("@korisnickoIme", korisnik.KorisnickoIme);
            cmd.Parameters.AddWithValue("@lozinka", korisnik.Lozinka);
            cmd.Parameters.AddWithValue("@uloga", korisnik.Uloga);
            cmd.Parameters.AddWithValue("@korisnikId", korisnik.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", korisnik.Azurirano);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }
    }
}
