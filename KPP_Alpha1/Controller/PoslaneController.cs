using KPP_Alpha1.Models;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class PoslaneController
    {
        readonly DbClass db = new DbClass();

        internal bool Insert(PoslaneModel poslane)
        {
            string insert = "INSERT INTO poslane(datum, posiljateljid, djelatnikid, naziv, napomena, " +
                "partnerid, korisnikid, azurirano) VALUES(?, ?, ?, ?, ?, ?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(insert, conn);
            cmd.Parameters.AddWithValue("@datum", poslane.Datum);
            cmd.Parameters.AddWithValue("@posiljateljid", poslane.PosiljateljId);
            cmd.Parameters.AddWithValue("@djelatnikid", poslane.DjelanikId);
            cmd.Parameters.AddWithValue("@naziv", poslane.Naziv);
            cmd.Parameters.AddWithValue("@napomena", poslane.Napomena);
            cmd.Parameters.AddWithValue("@partnerid", poslane.PartnerId);
            cmd.Parameters.AddWithValue("@korsinkid", poslane.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", poslane.Azurirano);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }

        internal bool Update(PoslaneModel poslane)
        {
            string update = "UPDATE poslane SET datum=?, posiljateljid=?, djelatnikid=?, naziv=?, " +
                "napomena=?, partnerid=?, korisnikid=?, azurirano=? WHERE id=?";
            OleDbConnection conn = new OleDbConnection(db.connString);
            OleDbCommand cmd = new OleDbCommand(update, conn);
            cmd.Parameters.AddWithValue("@datum", poslane.Datum);
            cmd.Parameters.AddWithValue("@posiljateljid", poslane.PosiljateljId);
            cmd.Parameters.AddWithValue("@djelatnikid", poslane.DjelanikId);
            cmd.Parameters.AddWithValue("@naziv", poslane.Naziv);
            cmd.Parameters.AddWithValue("@napomena", poslane.Napomena);
            cmd.Parameters.AddWithValue("@partnerid", poslane.PartnerId);
            cmd.Parameters.AddWithValue("@korsinkid", poslane.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", poslane.Azurirano);
            cmd.Parameters.AddWithValue("@id", poslane.Id);
            bool success = db.ExcecuteNonQuery(cmd, conn);
            return success;
        }
    }
}
