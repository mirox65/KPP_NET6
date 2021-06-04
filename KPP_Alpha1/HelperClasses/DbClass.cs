using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    class DbClass
    {
        readonly EditClass edit = new EditClass();

        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        public string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\KPP.accdb; Persist Security Info = false";

        #region METODE ZA PRISTUP BAZI I IZVRŠAVANJE ZADATAKA QUERY
        internal bool ExcecuteNonQuery(OleDbCommand cmd, OleDbConnection conn)
        {
            bool success = false;
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
        #endregion

        // Metoda zadužena za popunjavanje DataGridView-ova na svima fromama
        public DataTable Select(string Dbs)
        {
            conn = new OleDbConnection(connString);
            cmd = new OleDbCommand(Dbs, conn);
            DataTable dt = new DataTable();
            try
            {
                OleDbDataAdapter a = new OleDbDataAdapter(cmd);
                conn.Open();
                a.Fill(dt);
            }
            catch (Exception ex) { edit.MessageException(ex); }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        // Izvoz podataka za arhivu ovo ne radi treba mu se posvetiti
        public DataTable IzvozPodataka(string Dbs)
        {
            conn = new OleDbConnection(connString);
            cmd = new OleDbCommand(Dbs, conn);
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();
            OleDbDataReader myReader = cmd.ExecuteReader();
            try
            {
                conn.Open();
                dt.Load(myReader);
                foreach (DataRow red in dt.Rows)
                {
                    foreach (DataColumn stup in dt.Columns)
                    {
                        sb.ToString();
                        sb.Append(";");
                        sb.Append(red[stup.ColumnName].ToString());
                    }
                    sb.Append("\n");
                }
            }
            catch (Exception ex) { edit.MessageException(ex); }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        #region PREOPTEREČENE METODE ZA IZRADU KOLEKCIJA
        // Kolekcija s tri varijble, tablica i dvije kolone
        public AutoCompleteStringCollection AutoComplete(string DbAc, string AcPrvi, string AcDrugi)
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            conn = new OleDbConnection(connString);
            cmd = new OleDbCommand(DbAc, conn);
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
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            conn = new OleDbConnection(connString);
            cmd = new OleDbCommand(DbAc, conn);
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

        #region PREOPTEREČENE METODE ZA IZRADU RIJEČNIKA
        // Rijećnik sa dvije varijable, jedna kolona i tablica
        internal Dictionary<int, string> DictFill(string kolona, string tablica)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            var dbs = $"SELECT id, {kolona} FROM {tablica};";
            var conn = new OleDbConnection(connString);
            var cmd = new OleDbCommand(dbs, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var key = Convert.ToInt32(reader["id"].ToString());
                    var value = reader[$"{kolona}"].ToString();
                    dict.Add(key, value);
                }
            }
            catch (Exception) { throw; }
            finally
            {
                conn.Close();
            }
            return dict;
        }
        // Riječnik sa tri varijable, tablica i dvije kolone
        internal Dictionary<int, string> DictFill(string kolona1, string kolona2, string tablica)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            var dbs = $"SELECT id, {kolona1}, {kolona2} FROM {tablica};";
            var conn = new OleDbConnection(connString);
            var cmd = new OleDbCommand(dbs, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var key = Convert.ToInt32(reader["id"].ToString());
                    var kol1 = reader[$"{kolona1}"].ToString();
                    var kol2 = reader[$"{kolona2}"].ToString();
                    var value = $"{kol1} {kol2}";
                    dict.Add(key, value);
                }
            }
            catch (Exception) { throw; }
            finally
            {
                conn.Close();
            }
            return dict;
        }
        #endregion
    }
}
