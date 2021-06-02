using KPP_Alpha1.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class PoslaneController
    {
        readonly dbClass db = new dbClass();

        internal bool Insert(PoslaneModel poslane)
        {
            bool success = false;
            string insert = "INSERT INTO poslane(datum, posiljateljid, djelatnikid, naziv, napomena, " +
                "partnerid, korisnikid, azurirano) VALUES(?, ?, ?, ?, ?, ?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(db.conn_string);
            OleDbCommand cmd = new OleDbCommand(insert, conn);
            cmd.Parameters.AddWithValue("@datum", poslane.Datum);
            cmd.Parameters.AddWithValue("@posiljateljid", poslane.PosiljateljId);
            cmd.Parameters.AddWithValue("@djelatnikid", poslane.DjelanikId);
            cmd.Parameters.AddWithValue("@naziv", poslane.Naziv);
            cmd.Parameters.AddWithValue("@napomena", poslane.Napomena);
            cmd.Parameters.AddWithValue("@partnerid", poslane.PartnerId);
            cmd.Parameters.AddWithValue("@korsinkid", poslane.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", poslane.Azurirano);
            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception) { throw; }
            finally
            {
                conn.Close();
            }
            return success;
        }

        internal bool Update(PoslaneModel poslane)
        {
            bool success = false;
            string update = "UPDATE poslane SET datum=?, posiljateljid=?, djelatnikid=?, naziv=?, " +
                "napomena=?, partnerid=?, korisnikid=?, azurirano=? WHERE id=?";
            OleDbConnection conn = new OleDbConnection(db.conn_string);
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
            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception) { throw; }
            finally
            {
                conn.Close();
            }
            return success;
        }
    }
}
