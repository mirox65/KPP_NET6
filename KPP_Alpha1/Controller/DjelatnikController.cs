using KPP_Alpha1.Models;
using System;
using System.Data.OleDb;

namespace KPP_Alpha1.Controller
{
    class DjelatnikController
    {
        readonly dbClass dbc = new dbClass();

        internal bool Insert(DjelatnikModel djelatnik)
        {
            bool isSuccess = false;
            string Unos = "INSERT INTO djelatnici(pn, ime, prezime, idodjel, idkorisnika, azurirano) VALUES(?, ?, ?, ?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            try
            {
                OleDbCommand cmd = new OleDbCommand(Unos, conn);
                cmd.Parameters.AddWithValue("@pn", djelatnik.PerNum);
                cmd.Parameters.AddWithValue("@ime", djelatnik.Ime);
                cmd.Parameters.AddWithValue("@prezime", djelatnik.Prezime);
                cmd.Parameters.AddWithValue("@idojdel", djelatnik.OdjelId);
                cmd.Parameters.AddWithValue("@idkorisnika", djelatnik.KorisnikId);
                cmd.Parameters.AddWithValue("@azurirano", djelatnik.Azurirano);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        internal bool Update(DjelatnikModel djelatnik)
        {
            bool isSuccess = false;
            string Uredi = "UPDATE djelatnici SET pn=?, ime=?, " +
            "prezime=?, idodjel=?, idkorisnika=?, azurirano=? WHERE ID=?";

            OleDbConnection conn = new OleDbConnection(dbc.conn_string);
            OleDbCommand cmd = new OleDbCommand(Uredi, conn);
            cmd.Parameters.AddWithValue("@pn", djelatnik.PerNum);
            cmd.Parameters.AddWithValue("@ime", djelatnik.Ime);
            cmd.Parameters.AddWithValue("@prezime", djelatnik.Prezime);
            cmd.Parameters.AddWithValue("@idodjel", djelatnik.OdjelId);
            cmd.Parameters.AddWithValue("@idkorisnika", djelatnik.KorisnikId);
            cmd.Parameters.AddWithValue("@azurirano", djelatnik.Azurirano);
            cmd.Parameters.AddWithValue("@id", djelatnik.Id);

            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex) { dbc.MessageGeneralDError(ex); }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

    }
}
