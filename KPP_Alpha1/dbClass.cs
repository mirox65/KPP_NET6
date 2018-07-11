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
        //public String conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\users\\miro\\Dropbox\\OOP2_projekt\\KPP_DB\\KPP.accdb; Persist Security Info = false";
        //public String conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\\Dropbox\\OOP2_projekt\\KPP_DB\\KPP.accdb; Persist Security Info = false";
        public String conn_string = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=R:\\Studenti\\DB\\KPP_DB\\KPP.accdb; Persist Security Info = false";

        public string PraznaCelija = "Čelije ne smiju biti prazne!";
        public string IzmjenaError = "Izmjena nije izvršena!";
        public string UnosError = "Unos nije napravljen!";
        public string IdError = "ID stavke nije prondađen!";

        public DataTable Select(string Dbs)
        {
            OleDbConnection conn = new OleDbConnection(conn_string);
            DataTable dt = new DataTable();
            try
            {
                OleDbCommand cmd = new OleDbCommand(Dbs, conn);
                OleDbDataAdapter a = new OleDbDataAdapter(cmd);
                conn.Open();
                a.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            conn.Close();
            return dt;
        }

        public AutoCompleteStringCollection AutoComplete(string DbAc, string AcPrvi, string AcDrugi)
        {                        
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            OleDbConnection conn = new OleDbConnection(conn_string);

            conn.Open();            
            OleDbCommand cmd = new OleDbCommand(DbAc, conn);
            OleDbDataReader myReader = cmd.ExecuteReader();
                        
            while (myReader.Read())
            {
                string prviString = myReader[AcPrvi].ToString();
                string drugiString = myReader[AcDrugi].ToString();
                coll.Add(prviString + " " + drugiString);
            }
            conn.Close();
            return coll;
        }

        public AutoCompleteStringCollection AutoComplete(string DbAc, string AcPrvi)
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            OleDbConnection conn = new OleDbConnection(conn_string);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(DbAc, conn);
            OleDbDataReader myReader = cmd.ExecuteReader();

            int jedan = myReader.GetOrdinal(AcPrvi);
            while (myReader.Read())
            {
                string prviString = myReader.GetString(jedan);
                coll.Add(prviString);
            }
            conn.Close();
            return coll;
        }
    }
}
