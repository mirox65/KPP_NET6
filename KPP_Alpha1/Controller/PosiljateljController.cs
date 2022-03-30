using KPP_Alpha1.Models;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class PosiljateljController
    {
        readonly DbClass db = new();

        internal bool Insert(PosiljateljModel posiljatelj)
        {
            var insert = "INSERT INTO posiljatelji(naziv, oib, idMjesto, status, korisnikId, azurirano) " +
                "VALUES(?, ?, ?, ?, ?, ?)";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(insert, conn);
            cmd.Parameters.AddWithValue("@naziv", posiljatelj.Naziv);
            cmd.Parameters.AddWithValue("@oib", posiljatelj.Oib);
            cmd.Parameters.AddWithValue("@idMjesto", posiljatelj.IdMjesto);
            cmd.Parameters.AddWithValue("@status", posiljatelj.Status);
            cmd.Parameters.AddWithValue("@korisnikId", posiljatelj.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", posiljatelj.Azurirano);
            
            return db.ExcecuteNonQuery(cmd, conn);
        }

        internal bool Update(PosiljateljModel posiljatelj)
        {
            var update = "UPDATE posiljatelji SET naziv=?, oib=?, idMjesto=?, status=?, korisnikId=?, azurirano=? " +
                "WHERE id=?";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(update, conn);
            cmd.Parameters.AddWithValue("@naziv", posiljatelj.Naziv);
            cmd.Parameters.AddWithValue("@oib", posiljatelj.Oib);
            cmd.Parameters.AddWithValue("@idMjesto", posiljatelj.IdMjesto);
            cmd.Parameters.AddWithValue("@status", posiljatelj.Status);
            cmd.Parameters.AddWithValue("@korisnikId", posiljatelj.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", posiljatelj.Azurirano);
            cmd.Parameters.AddWithValue("@id", posiljatelj.Id);
            
            return db.ExcecuteNonQuery(cmd, conn);
        }
    }
}
