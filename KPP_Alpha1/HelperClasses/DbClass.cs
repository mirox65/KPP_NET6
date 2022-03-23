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
        readonly EditClass edit = new();

        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        public string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\KPP.accdb; Jet OLEDB:Database Password=SunceJeLijepo1#;";

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
            DataTable dt = new();
            try
            {
                OleDbDataAdapter a = new(cmd);
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

        internal bool ExecuteScalar(OleDbCommand cmd, OleDbConnection conn)
        {
            var success = true;
            try
            {
                conn.Open();
                int provjera = (int)cmd.ExecuteScalar();
                if(provjera > 0) 
                {
                    success = false; 
                }
            }
            catch (Exception)
            {
                throw;
            }

            return success;
        }

        // Izvoz podataka za arhivu ovo ne radi treba mu se posvetiti
        public DataTable IzvozPodataka(string Dbs)
        {
            conn = new OleDbConnection(connString);
            cmd = new OleDbCommand(Dbs, conn);
            DataTable dt = new();
            StringBuilder sb = new();
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


    }
}
