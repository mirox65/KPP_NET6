using KPP_Alpha1.Models;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class OdjelController
    {
        readonly DbClass db = new();

        internal bool Insert(OdjelModel odjel)
        {
            string Unos = "INSERT INTO odjeli(Naziv, status, korisnikId, azurirano) VALUES(?, ?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Unos, conn);
            cmd.Parameters.AddWithValue("@Naziv", odjel.Naziv);
            cmd.Parameters.AddWithValue("@status", odjel.Status);
            cmd.Parameters.AddWithValue("@korisnikId", odjel.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", odjel.Azurirano);

            return db.ExcecuteNonQuery(cmd, conn);
        }

        internal bool Update(OdjelModel odjel)
        {
            string Uredi = "UPDATE odjeli SET Naziv=?, status=?, korisnikId=?, azurirano=? WHERE ID=?";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@Naziv", odjel.Naziv);
            cmd.Parameters.AddWithValue("@status", odjel.Status);
            cmd.Parameters.AddWithValue("@korisnikId", odjel.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", odjel.Azurirano);
            cmd.Parameters.AddWithValue("@ID", odjel.Id);

            return db.ExcecuteNonQuery(cmd, conn);
        }
    }
}
