using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Controller
{
    internal class VozilaController
    {
        readonly DbClass db = new DbClass();

        internal bool Insert(VozilaModel vozilo)
        {
            var Insert = "INSERT INTO vozila" +
                "(proizvođač, model, opis, brŠasije, regOznaka, brUgovora, korisnikId, ažurirano) " +
                "VALUES(?, ?, ?, ?, ?, ?, ?, ?)";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(Insert, conn);
            cmd.Parameters.AddWithValue("@proizvođač", vozilo.Proizvodac);
            cmd.Parameters.AddWithValue("@model", vozilo.Model);
            cmd.Parameters.AddWithValue("@opis", vozilo.Opis);
            cmd.Parameters.AddWithValue("@brŠasije", vozilo.BrSasije);
            cmd.Parameters.AddWithValue("@regOznaka", vozilo.RegOznaka);
            cmd.Parameters.AddWithValue("@brUgovora", vozilo.BrUgovora);
            cmd.Parameters.AddWithValue("@korisnikId", vozilo.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", vozilo.DateEdited);

            return db.ExcecuteNonQuery(cmd, conn);
        }

        internal bool Update(VozilaModel vozilo)
        {
            string Update = "UPDATE vozila SET proizvođač=?, model=?, opis=?, brŠasije=?, regOznaka=?, brUgovora=?, " +
                "korisnikId=?, ažurirano=? WHERE id=?";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(Update, conn);
            cmd.Parameters.AddWithValue("@proizvođač", vozilo.Proizvodac);
            cmd.Parameters.AddWithValue("@model", vozilo.Model);
            cmd.Parameters.AddWithValue("@opis", vozilo.Opis);
            cmd.Parameters.AddWithValue("@brŠasije", vozilo.BrSasije);
            cmd.Parameters.AddWithValue("@regOznaka", vozilo.RegOznaka);
            cmd.Parameters.AddWithValue("@brUgovora", vozilo.BrUgovora);
            cmd.Parameters.AddWithValue("@korisnikId", vozilo.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", vozilo.DateEdited);
            cmd.Parameters.AddWithValue("@id", vozilo.Id);

            return db.ExcecuteNonQuery(cmd, conn);
        }
    }
}
