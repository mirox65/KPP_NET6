using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Controller
{
    internal class OpremaController
    {
        readonly DbClass db = new DbClass();

        internal bool Insert(OpremaModel oprema)
        {
            var Insert = "INSERT INTO ictOprema" +
                "(naziv, serBr, invBr, status, datKupovine, vijek, datZamjene, korisnikId, dateEdited) " +
                "VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?)";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(Insert, conn);
            cmd.Parameters.AddWithValue("@naziv", oprema.Naziv);
            cmd.Parameters.AddWithValue("@serBr", oprema.SerijskiBroj);
            cmd.Parameters.AddWithValue("@invBr", oprema.InventarniBroj);
            cmd.Parameters.AddWithValue("@status", oprema.StatusOpreme);
            cmd.Parameters.AddWithValue("@datKupovine", oprema.DatumKupovine);
            cmd.Parameters.AddWithValue("@vijek", oprema.VijekTrajanja);
            cmd.Parameters.AddWithValue("@datZamjene", oprema.DatumZamjene);
            cmd.Parameters.AddWithValue("@korisnikId", oprema.KorisnikId);
            cmd.Parameters.AddWithValue("@dateEdited", oprema.DateEdited);

            return db.ExcecuteNonQuery(cmd, conn);            
        }

        internal bool Update(OpremaModel oprema)
        {
            string Update = "UPDATE ictOprema SET naziv=?, serBr=?, invBr=?, status=?, datKupovine=?, vijek=?, " +
                "datZamjene=?, korisnikId=?, dateEdited=? WHERE id=?";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(Update, conn);
            cmd.Parameters.AddWithValue("@naziv", oprema.Naziv);
            cmd.Parameters.AddWithValue("@serBr", oprema.SerijskiBroj);
            cmd.Parameters.AddWithValue("@invBr", oprema.InventarniBroj);
            cmd.Parameters.AddWithValue("@status", oprema.StatusOpreme);
            cmd.Parameters.AddWithValue("@datKupovine", oprema.DatumKupovine);
            cmd.Parameters.AddWithValue("@vijek", oprema.VijekTrajanja);
            cmd.Parameters.AddWithValue("@datZamjene", oprema.DatumZamjene);
            cmd.Parameters.AddWithValue("@korisnikId", oprema.KorisnikId);
            cmd.Parameters.AddWithValue("@dateEdited", oprema.DateEdited);
            cmd.Parameters.AddWithValue("@id", oprema.Id);

            return db.ExcecuteNonQuery(cmd, conn);
        }
    }
}
