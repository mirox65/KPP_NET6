using KPP_Alpha1.Models;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class KnjigaController
    {
        readonly DbClass db = new DbClass();
        internal bool Update(KnjigaModel knjiga)
        {
            string Uredi = "UPDATE knjiga SET datumPrimitka=?, pismeno=?, brojcano=?," +
                "idPosiljatelj=?, datum=?, idOdjel=?, idkorisnik=?, azurirano= ? WHERE id=?";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@datumPrimitka", knjiga.DatumPrimitka);
            cmd.Parameters.AddWithValue("@pismeno", knjiga.Pismeno);
            cmd.Parameters.AddWithValue("@brojcano", knjiga.Brojcano);
            cmd.Parameters.AddWithValue("@idPosiljatelj", knjiga.PosiljateljId);
            cmd.Parameters.AddWithValue("@datum", knjiga.Datum);
            cmd.Parameters.AddWithValue("@idOdjel", knjiga.OdjelId);
            cmd.Parameters.AddWithValue("@idkorisnik", knjiga.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", knjiga.Azurirano);
            cmd.Parameters.AddWithValue("@id", knjiga.Id);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }

        internal bool Insert(KnjigaModel knjiga)
        {
            string ole = "INSERT INTO knjiga(datumPrimitka, pismeno, brojcano, idPosiljatelj, datum, IDodjel, IDkorisnik, azurirano)" +
                "VALUES(?, ?, ?, ?, ?, ?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(ole, conn);
            cmd.Parameters.AddWithValue("@datumPrimitka", knjiga.DatumPrimitka);
            cmd.Parameters.AddWithValue("@pismeno", knjiga.Pismeno);
            cmd.Parameters.AddWithValue("@brojcano", knjiga.Brojcano);
            cmd.Parameters.AddWithValue("@idPosiljatelj", knjiga.PosiljateljId);
            cmd.Parameters.AddWithValue("@datum", knjiga.Datum);
            cmd.Parameters.AddWithValue("@IDodjel", knjiga.OdjelId);
            cmd.Parameters.AddWithValue("@IDkorisnik", knjiga.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", knjiga.Azurirano);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }
    }
}
