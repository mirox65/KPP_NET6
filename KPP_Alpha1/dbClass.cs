using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace KPP_Alpha1
{
    class dbClass
    {
        OleDbConnection conn = null;
        OleDbCommand cmd = null;
        public string conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\KPP.accdb; Persist Security Info = false";
        //poruke korisniku kad nešto nije kako treba
        public string PraznaCelija = "Ćelije ne smiju biti prazne!";
        public string CelijaNazivUpozorenje = "Upozorenje";
        public string CelijaNazivObavjest = "Obavjest aplikacije";
        public string IzmjenaError = "Izmjena nije izvršena!";
        public string UnosError = "Unos nije napravljen!";
        public string IdError = "ID stavke nije prondađen!";
        public string ExError = "Dogodila se greška:\n";

        public DataTable Select(string Dbs)
        {
            conn = new OleDbConnection(conn_string);
            cmd = new OleDbCommand(Dbs, conn);
            DataTable dt = new DataTable();
            try
            {
                OleDbDataAdapter a = new OleDbDataAdapter(cmd);
                conn.Open();
                a.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CelijaNazivObavjest);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable IzvozPodataka(string Dbs)
        {
            conn = new OleDbConnection(conn_string);
            cmd = new OleDbCommand(Dbs, conn);
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();
            try
            {
                OleDbDataReader myReader = cmd.ExecuteReader();
                conn.Open();
                dt.Load(myReader);
                foreach(DataRow red in dt.Rows)
                {
                    foreach(DataColumn stup in dt.Columns)
                    {
                        sb.ToString();
                        sb.Append(";");
                        sb.Append(red[stup.ColumnName].ToString());
                    }
                    sb.Append("\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CelijaNazivObavjest);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public AutoCompleteStringCollection AutoComplete(string DbAc, string AcPrvi, string AcDrugi)
        {                        
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            conn = new OleDbConnection(conn_string);
            cmd = new OleDbCommand(DbAc, conn);
            conn.Open();
            try
            {
                OleDbDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string prviString = myReader[AcPrvi].ToString();
                    string drugiString = myReader[AcDrugi].ToString();
                    coll.Add(prviString + " " + drugiString);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ExError + ex, CelijaNazivObavjest);
            }
            finally
            {
                conn.Close();
            }
            return coll;
        }

        public AutoCompleteStringCollection AutoComplete(string DbAc, string AcPrvi)
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            conn = new OleDbConnection(conn_string);
            cmd = new OleDbCommand(DbAc, conn);
            conn.Open();
            try
            {
                OleDbDataReader myReader = cmd.ExecuteReader();
                int jedan = myReader.GetOrdinal(AcPrvi);
                while (myReader.Read())
                {
                    string prviString = myReader.GetString(jedan);
                    coll.Add(prviString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExError + ex, CelijaNazivObavjest);
            }
            finally
            {
                conn.Close();
            }
            return coll;
        }
    }
}
