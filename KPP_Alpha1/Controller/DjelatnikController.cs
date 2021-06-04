using KPP_Alpha1.Models;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class DjelatnikController
    {
        readonly DbClass db = new DbClass();

        internal bool Insert(DjelatnikModel djelatnik)
        {
            string Unos = "INSERT INTO djelatnici(pn, ime, prezime, idodjel, idkorisnika, azurirano) " +
                "VALUES(?, ?, ?, ?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Unos, conn);
            cmd.Parameters.AddWithValue("@pn", djelatnik.PerNum);
            cmd.Parameters.AddWithValue("@ime", djelatnik.Ime);
            cmd.Parameters.AddWithValue("@prezime", djelatnik.Prezime);
            cmd.Parameters.AddWithValue("@idojdel", djelatnik.OdjelId);
            cmd.Parameters.AddWithValue("@idkorisnika", djelatnik.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", djelatnik.Azurirano);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }

        internal bool Update(DjelatnikModel djelatnik)
        {
            string Uredi = "UPDATE djelatnici SET pn=?, ime=?, " +
                "prezime=?, idodjel=?, idkorisnika=?, azurirano=? WHERE ID=?";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@pn", djelatnik.PerNum);
            cmd.Parameters.AddWithValue("@ime", djelatnik.Ime);
            cmd.Parameters.AddWithValue("@prezime", djelatnik.Prezime);
            cmd.Parameters.AddWithValue("@idodjel", djelatnik.OdjelId);
            cmd.Parameters.AddWithValue("@idkorisnika", djelatnik.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", djelatnik.Azurirano);
            cmd.Parameters.AddWithValue("@id", djelatnik.Id);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }
    }
}
