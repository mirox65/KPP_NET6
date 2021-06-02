using KPP_Alpha1.Models;
using System;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class PartnerController
    {
        readonly dbClass db = new dbClass();

        internal bool Insert(PartnerModel partner)
        {
            bool success = false;
            string insert = "INSERT INTO partneri(naziv, idkorisnika, azurirano) VALUES(?, ?, ?);";
            OleDbConnection conn = new OleDbConnection(db.conn_string);
            OleDbCommand cmd = new OleDbCommand(insert, conn);
            cmd.Parameters.AddWithValue("@naziv", partner.Naziv);
            cmd.Parameters.AddWithValue("@idkorisnika", partner.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", partner.Azurirano);

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
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return success;
        }

        internal bool Edit(PartnerModel partner)
        {
            bool success = false;
            OleDbConnection conn = new OleDbConnection(db.conn_string);
            string edit = "UPDATE partneri SET naziv=?, idkorisnika=?, azurirano=? WHERE id=?;";
            OleDbCommand cmd = new OleDbCommand(edit, conn);
            cmd.Parameters.AddWithValue("@naziv", partner.Naziv);
            cmd.Parameters.AddWithValue("@idkorisnika", partner.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", partner.Azurirano);
            cmd.Parameters.AddWithValue("@id", partner.Id);

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
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return success;
        }
    }
}
