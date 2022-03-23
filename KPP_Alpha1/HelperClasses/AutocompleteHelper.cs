using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPP_Alpha1.HelperClasses
{
    internal class AutocompleteHelper
    {
        private readonly DbClass db = new();
        private readonly EditClass edit = new ();

        #region PREOPTEREČENE METODE ZA IZRADU KOLEKCIJA
        // Kolekcija s tri varijble, tablica i dvije kolone
        public AutoCompleteStringCollection AutoComplete(string DbAc, string AcPrvi, string AcDrugi)
        {
            AutoCompleteStringCollection coll = new();
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(DbAc, conn);
            try
            {
                conn.Open();
                OleDbDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string prviString = myReader[AcPrvi].ToString();
                    string drugiString = myReader[AcDrugi].ToString();
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

        public AutoCompleteStringCollection AutoComplete(AutoCompleteStringCollection collectiion, string DbAc, string AcPrvi, string AcDrugi)
        {
            var coll = collectiion;
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(DbAc, conn);
            try
            {
                conn.Open();
                OleDbDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string prviString = myReader[AcPrvi].ToString();
                    string drugiString = myReader[AcDrugi].ToString();
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
        public AutoCompleteStringCollection AutoComplete(string DbAc, string AcPrvi)
        {
            AutoCompleteStringCollection coll = new();
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(DbAc, conn);
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

        public AutoCompleteStringCollection AutoComplete(AutoCompleteStringCollection collection, string DbAc, string AcPrvi)
        {
            var coll = collection;
            var conn = new OleDbConnection(db.connString);
            var cmd = new OleDbCommand(DbAc, conn);
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
