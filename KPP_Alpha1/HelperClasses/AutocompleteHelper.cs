using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KPP_Alpha1.HelperClasses
{
    internal class AutocompleteHelper
    {
        private readonly DbClass db = new();
        private readonly EditClass edit = new();

        #region PREOPTEREČENE METODE ZA IZRADU KOLEKCIJA
        // Kolekcija s tri varijble, tablica i dvije kolone
        public AutoCompleteStringCollection AutoComplete(string tablica, string acPrvi, string acDrugi)
        {
            var select = $"SELECT * FROM {tablica} WHERE status='Aktivno';";
            var coll = new AutoCompleteStringCollection();
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(select, conn);
            try
            {
                conn.Open();
                OleDbDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string prviString = myReader[acPrvi].ToString();
                    string drugiString = myReader[acDrugi].ToString();
                    coll.Add(prviString + " " + drugiString);
                }
            }
            catch (Exception ex) { edit.MessageException(ex); }
            finally
            {
                conn.Close();
            }
            return coll;
        }

        public AutoCompleteStringCollection AutoComplete(AutoCompleteStringCollection collectiion, string tablica, string acPrvi, string acDrugi)
        {
            var select = $"SELECT * FROM {tablica} WHERE status='Aktivno';";
            var coll = collectiion;
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(select, conn);
            try
            {
                conn.Open();
                OleDbDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string prviString = myReader[acPrvi].ToString();
                    string drugiString = myReader[acDrugi].ToString();
                    coll.Add(prviString + " " + drugiString);
                }
            }
            catch (Exception ex) { edit.MessageException(ex); }
            finally
            {
                conn.Close();
            }
            return coll;
        }
        // Kolekcija za dvije varijable, tablica i jedna kolona
        public AutoCompleteStringCollection AutoComplete(string tablica, string acPrvi)
        {
            var select = $"SELECT * FROM {tablica} WHERE status='Aktivno';";
            var coll = new AutoCompleteStringCollection();
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(select, conn);
            try
            {
                conn.Open();
                OleDbDataReader myReader = cmd.ExecuteReader();
                int jedan = myReader.GetOrdinal(acPrvi);
                while (myReader.Read())
                {
                    string prviString = myReader.GetString(jedan);
                    coll.Add(prviString);
                }
            }
            catch (Exception ex) { edit.MessageException(ex); }
            finally
            {
                conn.Close();
            }
            return coll;
        }

        public AutoCompleteStringCollection AutoComplete(AutoCompleteStringCollection collection, string tablica, string AcPrvi)
        {
            var select = $"SELECT * FROM {tablica} WHERE status='Aktivno';";
            var coll = collection;
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(select, conn);
            try
            {
                conn.Open();
                OleDbDataReader myReader = cmd.ExecuteReader();
                int jedan = myReader.GetOrdinal(AcPrvi);
                while (myReader.Read())
                {
                    string prviString = myReader.GetString(jedan);
                    coll.Add(prviString);
                }
            }
            catch (Exception ex) { edit.MessageException(ex); }
            finally
            {
                conn.Close();
            }
            return coll;
        }
        #endregion

    }
}
