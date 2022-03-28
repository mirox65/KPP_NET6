using KPP_Alpha1.Models;
using System;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class DjelatnikController
    {
        readonly DbClass db = new();

        internal bool Insert(DjelatnikModel djelatnik)
        {
            string Unos = "INSERT INTO djelatnici(pn, ime, prezime, oib, idodjel, datZaposlen, status, " +
                "idkorisnika, azurirano) " +
                "VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Unos, conn);
            cmd.Parameters.AddWithValue("@pn", djelatnik.PerNum);
            cmd.Parameters.AddWithValue("@ime", djelatnik.Ime);
            cmd.Parameters.AddWithValue("@prezime", djelatnik.Prezime);
            cmd.Parameters.AddWithValue("@oib", djelatnik.Oib);
            cmd.Parameters.AddWithValue("@idojdel", djelatnik.OdjelId);
            cmd.Parameters.AddWithValue("@datZaposlen", djelatnik.DatZaposlen);
            cmd.Parameters.AddWithValue("@aktivan", djelatnik.Status);
            cmd.Parameters.AddWithValue("@idkorisnika", djelatnik.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", djelatnik.Azurirano);
            
            return db.ExcecuteNonQuery(cmd, conn);
        }

        internal bool Update(DjelatnikModel djelatnik)
        {
            string Uredi = "UPDATE djelatnici SET pn=?, ime=?, prezime=?, oib=?, idodjel=?, " +
                "datZaposlen=?, status=?, idkorisnika=?, azurirano=? WHERE ID=?";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@pn", djelatnik.PerNum);
            cmd.Parameters.AddWithValue("@ime", djelatnik.Ime);
            cmd.Parameters.AddWithValue("@prezime", djelatnik.Prezime);
            cmd.Parameters.AddWithValue("@oib", djelatnik.Oib);
            cmd.Parameters.AddWithValue("@idodjel", djelatnik.OdjelId);
            cmd.Parameters.AddWithValue("@datZaposlen", djelatnik.DatZaposlen);
            cmd.Parameters.AddWithValue("@aktivan", djelatnik.Status);
            cmd.Parameters.AddWithValue("@idkorisnika", djelatnik.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", djelatnik.Azurirano);
            cmd.Parameters.AddWithValue("@id", djelatnik.Id);
            
            return db.ExcecuteNonQuery(cmd, conn);            
        }

        internal bool UpdateOtkaz(DjelatnikModel djelatnik)
        {
            var update = "UPDATE djelatnici SET datOtkaz=? WHERE id=?;";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(update, conn);
            cmd.Parameters.AddWithValue("@datOtkaz", djelatnik.DatOtkaz);
            cmd.Parameters.AddWithValue("@id", djelatnik.Id);

            return db.ExcecuteNonQuery(cmd, conn);
        }
    }
}
