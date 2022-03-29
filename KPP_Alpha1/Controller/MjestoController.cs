using KPP_Alpha1.Models;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class MjestoController
    {
        readonly DbClass db = new();

        internal bool Update(MjestoModel mjesto)
        {
            string edit = "UPDATE mjesta SET ptt=?, mjesto=?, idZupanije=?, status=?, " +
                "korisnikId=?, azurirano=? WHERE ID=?";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(edit, conn);
            cmd.Parameters.AddWithValue("@ptt", mjesto.Ptt);
            cmd.Parameters.AddWithValue("@mjesto", mjesto.Mjesto);
            cmd.Parameters.AddWithValue("@idZupanije", mjesto.IdZupanije);
            cmd.Parameters.AddWithValue("@status", mjesto.Status);
            cmd.Parameters.AddWithValue("@korisnikId", mjesto.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirnao", mjesto.Azurirano);
            cmd.Parameters.AddWithValue("@id", mjesto.Id);

            return db.ExcecuteNonQuery(cmd, conn);
        }

        internal bool Insert(MjestoModel mjesto)
        {
            string Unos = "INSERT INTO mjesta(ptt, mjesto, idZupanije, status, korisnikId, azurirano) " +
                "VALUES(?, ?, ?, ?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Unos, conn);
            cmd.Parameters.AddWithValue("@ptt", mjesto.Ptt);
            cmd.Parameters.AddWithValue("@mjesto", mjesto.Mjesto);
            cmd.Parameters.AddWithValue("@idZupanije", mjesto.IdZupanije);
            cmd.Parameters.AddWithValue("@status", mjesto.Status);
            cmd.Parameters.AddWithValue("@korisnikId", mjesto.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirnao", mjesto.Azurirano);

            return db.ExcecuteNonQuery(cmd, conn);
        }
    }
}
