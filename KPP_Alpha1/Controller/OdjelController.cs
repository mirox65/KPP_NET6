using KPP_Alpha1.Models;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class OdjelController
    {
        readonly DbClass db = new DbClass();

        internal bool Insert(OdjelModel odjel)
        {
            string Unos = "INSERT INTO odjeli(Naziv, korisnikId, azurirano) VALUES(?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Unos, conn);
            cmd.Parameters.AddWithValue("@Naziv", odjel.Naziv);
            cmd.Parameters.AddWithValue("@korisnikId", odjel.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", odjel.Azurirano);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }

        internal bool Update(OdjelModel odjel)
        {
            string Uredi = "UPDATE odjeli SET Naziv=?, korisnikId=?, azurirano=? WHERE ID=?";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@Naziv", odjel.Naziv);
            cmd.Parameters.AddWithValue("@korisnikId", odjel.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", odjel.Azurirano);
            cmd.Parameters.AddWithValue("@ID", odjel.Id);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }
    }
}
