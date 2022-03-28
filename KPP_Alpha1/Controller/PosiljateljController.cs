using KPP_Alpha1.Models;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class PosiljateljController
    {
        readonly DbClass db = new DbClass();

        internal bool Insert(PosiljateljModel posiljatelj)
        {
            string Unos = "INSERT INTO posiljatelji(naziv, oib, idMjesto, status, korisnikId, azurirano) " +
                "VALUES(?, ?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Unos, conn);
            cmd.Parameters.AddWithValue("@naziv", posiljatelj.Naziv);
            cmd.Parameters.AddWithValue("@oib", posiljatelj.Oib);
            cmd.Parameters.AddWithValue("@idMjesto", posiljatelj.IdMjesto);
            cmd.Parameters.AddWithValue("@status", posiljatelj.Status);
            cmd.Parameters.AddWithValue("@korisnikId", posiljatelj.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", posiljatelj.Azurirano);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }

        internal bool Update(PosiljateljModel posiljatelj)
        {
            string Uredi = "UPDATE posiljatelji SET naziv=?, oib=?, idMjesto=?, status=?, korisnikId=?, azurirano=? " +
                "WHERE id=?";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@naziv", posiljatelj.Naziv);
            cmd.Parameters.AddWithValue("@oib", posiljatelj.Oib);
            cmd.Parameters.AddWithValue("@idMjesto", posiljatelj.IdMjesto);
            cmd.Parameters.AddWithValue("@status", posiljatelj.Status);
            cmd.Parameters.AddWithValue("@korisnikId", posiljatelj.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", posiljatelj.Azurirano);
            cmd.Parameters.AddWithValue("@id", posiljatelj.Id);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }
    }
}
