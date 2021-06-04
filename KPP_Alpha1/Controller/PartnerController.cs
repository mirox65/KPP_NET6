using KPP_Alpha1.Models;
using System;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class PartnerController
    {
        readonly DbClass db = new DbClass();

        internal bool Insert(PartnerModel partner)
        {
            string insert = "INSERT INTO partneri(naziv, idkorisnika, azurirano) VALUES(?, ?, ?);";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(insert, conn);
            cmd.Parameters.AddWithValue("@naziv", partner.Naziv);
            cmd.Parameters.AddWithValue("@idkorisnika", partner.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", partner.Azurirano);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }

        internal bool Edit(PartnerModel partner)
        {
            OleDbConnection conn = new OleDbConnection(db.connString);
            string edit = "UPDATE partneri SET naziv=?, idkorisnika=?, azurirano=? WHERE id=?;";
            OleDbCommand cmd = new OleDbCommand(edit, conn);
            cmd.Parameters.AddWithValue("@naziv", partner.Naziv);
            cmd.Parameters.AddWithValue("@idkorisnika", partner.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", partner.Azurirano);
            cmd.Parameters.AddWithValue("@id", partner.Id);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }
    }
}
