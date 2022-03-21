using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Controller
{
    internal class KarticeUlazController
    {
        readonly DbClass db = new DbClass();

        internal bool Insert(KeyCardModel kartica)
        {
            var Insert = "INSERT INTO keyCards" +
                "(naziv, napomena, status, korisnikId, ažurirano) " +
                "VALUES(?, ?, ?, ?, ?)";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(Insert, conn);
            cmd.Parameters.AddWithValue("@naziv", kartica.Naziv);
            cmd.Parameters.AddWithValue("@napomena", kartica.Napomena);
            cmd.Parameters.AddWithValue("@status", kartica.Status);
            cmd.Parameters.AddWithValue("@korisnikId", kartica.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", kartica.DateEdited);

            return db.ExcecuteNonQuery(cmd, conn);
        }

        internal bool Update(KeyCardModel kartica)
        {
            string Update = "UPDATE keyCards SET naziv=?, napomena=?, status=?, " +
                "korisnikId=?, ažurirano=? WHERE id=?";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(Update, conn);
            cmd.Parameters.AddWithValue("@naziv", kartica.Naziv);
            cmd.Parameters.AddWithValue("@napomena", kartica.Napomena);
            cmd.Parameters.AddWithValue("@status", kartica.Status);
            cmd.Parameters.AddWithValue("@korisnikId", kartica.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", kartica.DateEdited);
            cmd.Parameters.AddWithValue("@id", kartica.Id);

            return db.ExcecuteNonQuery(cmd, conn);
        }
    }
}
