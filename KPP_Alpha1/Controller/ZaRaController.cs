using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Controller
{
    internal class ZaRaController
    {
        readonly DbClass db = new DbClass();

        internal bool Insert(ZaRaModel zaRa)
        {
            var insert = $"INSERT INTO {zaRa.NazivZaRaTablice}(opremaId, djelatnikId, datZaduženja, korisnikId, ažurirano) " +
                "VALUES(?, ?, ?, ?, ?)";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(insert, conn);
            cmd.Parameters.AddWithValue("@opremaId", zaRa.OpremaId);
            cmd.Parameters.AddWithValue("@djelatnikId", zaRa.DjelatnikId);
            cmd.Parameters.AddWithValue("@datZaduženja", zaRa.DatumZaduženja);
            cmd.Parameters.AddWithValue("@korisnikId", zaRa.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", zaRa.EditedOn);

            return db.ExcecuteNonQuery(cmd, conn);
        }

        internal bool Update(ZaRaModel zaRa)
        {
            var update = $"UPDATE {zaRa.NazivZaRaTablice} SET opremaId=?, djelatnikId=?, datZaduženja=?, korisnikId=?, " +
                $"ažurirano=? WHERE id=?;";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(update, conn);
            cmd.Parameters.AddWithValue("@opremaId", zaRa.OpremaId);
            cmd.Parameters.AddWithValue("@djelatnikId", zaRa.DjelatnikId);
            cmd.Parameters.AddWithValue("@datZaduženja", zaRa.DatumZaduženja);
            cmd.Parameters.AddWithValue("@korisnikId", zaRa.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", zaRa.EditedOn);
            cmd.Parameters.AddWithValue("@id", zaRa.Id);

            return db.ExcecuteNonQuery(cmd, conn);
        }

        internal bool UpdateRazudženje(ZaRaModel zaRa)
        {
            var update = $"UPDATE {zaRa.NazivZaRaTablice} SET datRazduženja=?, korisnikId=?, ažurirano=? " +
                $"WHERE id=?;";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(update, conn);
            cmd.Parameters.AddWithValue("@datRazduženja", zaRa.DatumRazduženja);
            cmd.Parameters.AddWithValue("@korisnikId", zaRa.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", zaRa.EditedOn);
            cmd.Parameters.AddWithValue("@id", zaRa.Id);

            return db.ExcecuteNonQuery(cmd, conn);
        }
    }
}
