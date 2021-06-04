using KPP_Alpha1.Models;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class MjestoController
    {
        readonly DbClass db = new DbClass();

        internal bool Update(MjestoModel mjesto)
        {
            string edit = "UPDATE mjesta SET ptt=?, mjesto=?, idZupanije=?, " +
                "korisnikId=?, azurirano=? WHERE ID=?";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(edit, conn);
            cmd.Parameters.AddWithValue("@ptt", mjesto.Ptt);
            cmd.Parameters.AddWithValue("@mjesto", mjesto.Mjesto);
            cmd.Parameters.AddWithValue("@idZupanije", mjesto.IdZupanije);
            cmd.Parameters.AddWithValue("@korisnikId", mjesto.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirnao", mjesto.Azurirano);
            cmd.Parameters.AddWithValue("@id", mjesto.Id);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }

        internal bool Insert(MjestoModel mjesto)
        {
            string Unos = "INSERT INTO mjesta(ptt, mjesto, idZupanije, korisnikId, azurirano) " +
                "VALUES(?, ?, ?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Unos, conn);
            cmd.Parameters.AddWithValue("@ptt", mjesto.Ptt);
            cmd.Parameters.AddWithValue("@mjesto", mjesto.Mjesto);
            cmd.Parameters.AddWithValue("@idZupanije", mjesto.IdZupanije);
            cmd.Parameters.AddWithValue("@korisnikId", mjesto.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirnao", mjesto.Azurirano);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }
    }
}
