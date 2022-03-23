using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Controller
{
    internal class EncController
    {
        readonly DbClass db = new DbClass();
        internal bool Insert(EncModel enc)
        {
            var insert = "INSERT INTO enc(naziv, status, napomena, korisnikId, ažurirano) " +
                "VALUES(?, ?, ?, ?, ?);";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(insert, conn);
            cmd.Parameters.AddWithValue("@naziv", enc.Naziv);
            cmd.Parameters.AddWithValue("@status", enc.Status);
            cmd.Parameters.AddWithValue("@napomena", enc.Napomena);
            cmd.Parameters.AddWithValue("@korisnikId", enc.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", enc.Ažurirano);

            return db.ExcecuteNonQuery(cmd, conn);

        }

        internal bool Update(EncModel enc)
        {
            var update = "UPDATE enc SET naziv=?, status=?, napomena=?, korisnikId=?, ažurirano=? " +
                "WHERE id=?;";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(update, conn);
            cmd.Parameters.AddWithValue("@naziv", enc.Naziv);
            cmd.Parameters.AddWithValue("@status", enc.Status);
            cmd.Parameters.AddWithValue("@napomena", enc.Napomena);
            cmd.Parameters.AddWithValue("@korisnikId", enc.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", enc.Ažurirano);
            cmd.Parameters.AddWithValue("@id", enc.Id);

            return db.ExcecuteNonQuery(cmd, conn);
        }
    }
}
