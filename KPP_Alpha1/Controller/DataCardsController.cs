using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Controller
{
    internal class DataCardsController
    {
        readonly DbClass db = new DbClass();

        internal bool Insert(DataCardModel dataCard)
        {
            var insert = "INSERT INTO dataCards(imei, serBr, korisnikId, ažurirano) " +
                "VALUES(?,?,?,?);";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(insert, conn);
            cmd.Parameters.AddWithValue("@imei",dataCard.Imei);
            cmd.Parameters.AddWithValue("@serBr", dataCard.SerBr);
            cmd.Parameters.AddWithValue("@korisnikId", dataCard.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", dataCard.Ažurirano);
            return db.ExcecuteNonQuery(cmd, conn);
        }

        internal bool Update(DataCardModel dataCard)
        {
            var update = "UPDATE dataCards SET imei=?, serBr=?, korisnikId=?, ažurirano=? " +
                "WHERE id=?;";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(update, conn);
            cmd.Parameters.AddWithValue("@imei", dataCard.Imei);
            cmd.Parameters.AddWithValue("@serBr", dataCard.SerBr);
            cmd.Parameters.AddWithValue("@korisnikId", dataCard.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", dataCard.Ažurirano);
            cmd.Parameters.AddWithValue("@id", dataCard.Id);
            return db.ExcecuteNonQuery(cmd, conn);

        }
    }
}
