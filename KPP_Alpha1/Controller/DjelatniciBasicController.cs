using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPP_Alpha1.Controller
{
    internal class DjelatniciBasicController
    {
        private readonly DbClass db = new();
        internal bool Insert(DjelatnikBasicModel djelatnikBasic)
        {
            var insert = "INSERT INTO djelatniciBasic(djelatnikId, dateOfBirth, spol, adresa, mjestoId, [position], chartNumber, " +
                "workRegion, workRelationship, korisnikId, ažurirano) " +
                "VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?);";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(insert, conn);
            cmd.Parameters.AddWithValue("@djelatnikId", djelatnikBasic.DjelatnikId);
            cmd.Parameters.AddWithValue("@dateOfBirth", djelatnikBasic.DateOfBirth);
            cmd.Parameters.AddWithValue("@spol", djelatnikBasic.Spol);
            cmd.Parameters.AddWithValue("@adresa", djelatnikBasic.Adresa);
            cmd.Parameters.AddWithValue("@mjestoId", djelatnikBasic.MjestoId);
            cmd.Parameters.AddWithValue("@position", djelatnikBasic.Postion);
            cmd.Parameters.AddWithValue("@chartNumber", djelatnikBasic.ChartNumber);
            cmd.Parameters.AddWithValue("@workRegion", djelatnikBasic.WorkRegion);
            cmd.Parameters.AddWithValue("@workRelationship", djelatnikBasic.WorkRelationship);
            cmd.Parameters.AddWithValue("@korisnikId", djelatnikBasic.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", djelatnikBasic.Ažurirano);

            return db.ExcecuteNonQuery(cmd, conn);
        }

        internal bool Update(DjelatnikBasicModel djelatnikBasic)
        {
            var edit = "UPDATE djelatniciBasic SET djelatnikId=?, dateOfBirth=?, spol=?, adresa=?, mjestoId=?, [position]=?, chartNumber=?, " +
                "workRegion=?, workRelationship=?, korisnikId=?, ažurirano=? " +
                "WHERE id=?";
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(edit, conn);
            cmd.Parameters.AddWithValue("@djelatnikId", djelatnikBasic.DjelatnikId);
            cmd.Parameters.AddWithValue("@dateOfBirth", djelatnikBasic.DateOfBirth);
            cmd.Parameters.AddWithValue("@spol", djelatnikBasic.Spol);
            cmd.Parameters.AddWithValue("@adresa", djelatnikBasic.Adresa);
            cmd.Parameters.AddWithValue("@mjestoId", djelatnikBasic.MjestoId);
            cmd.Parameters.AddWithValue("@position", djelatnikBasic.Postion);
            cmd.Parameters.AddWithValue("@chartNumber", djelatnikBasic.ChartNumber);
            cmd.Parameters.AddWithValue("@workRegion", djelatnikBasic.WorkRegion);
            cmd.Parameters.AddWithValue("@workRelationship", djelatnikBasic.WorkRelationship);
            cmd.Parameters.AddWithValue("@korisnikId", djelatnikBasic.KorisnikId);
            cmd.Parameters.AddWithValue("@ažurirano", djelatnikBasic.Ažurirano);
            cmd.Parameters.AddWithValue("@id", djelatnikBasic.Id);

            return db.ExcecuteNonQuery(cmd, conn);
        }
    }
}
